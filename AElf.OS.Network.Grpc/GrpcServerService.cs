using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using AElf.Common;
using AElf.Cryptography;
using AElf.Kernel;
using AElf.Kernel.Account.Application;
using AElf.Kernel.Blockchain.Application;
using AElf.Kernel.TransactionPool.Infrastructure;
using AElf.OS.Network.Events;
using AElf.OS.Network.Infrastructure;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.EventBus.Local;
using Volo.Abp.Threading;

namespace AElf.OS.Network.Grpc
{
    /// <summary>
    /// Implementation of the grpc generated service. It contains the rpc methods
    /// exposed to peers.
    /// </summary>
    public class GrpcServerService : PeerService.PeerServiceBase
    {
        private readonly IPeerPool _peerPool;
        private readonly IBlockchainService _blockChainService;
        private readonly IAccountService _accountService;

        public ILocalEventBus EventBus { get; set; }

        public ILogger<GrpcServerService> Logger { get; set; }

        public GrpcServerService(IPeerPool peerPool, IBlockchainService blockChainService, IAccountService accountService)
        {
            _peerPool = peerPool;
            _blockChainService = blockChainService;
            _accountService = accountService;

            EventBus = NullLocalEventBus.Instance;
            Logger = NullLogger<GrpcServerService>.Instance;
        }

        /// <summary>
        /// First step of the connect/auth process. Used to initiate a connection. The provided payload should be the
        /// clients authentication information. When receiving this call, protocol dictates you send the client your auth
        /// information. The response says whether or not you can connect.
        /// </summary>
        public override async Task<ConnectReply> Connect(Handshake handshake, ServerCallContext context)
        {
            Logger.LogTrace($"{context.Peer} has initiated a connection request.");

            if (handshake?.HskData == null)
                return new ConnectReply { Err = AuthError.InvalidHandshake };
            
            var peer = GrpcUrl.Parse(context.Peer);
            var peerAddress = peer.IpAddress + ":" + handshake.HskData.ListeningPort;

            Logger.LogDebug($"Attempting to create channel to {peerAddress}");

            Channel channel = new Channel(peerAddress, ChannelCredentials.Insecure);
            var client = new PeerService.PeerServiceClient(channel.Intercept(metadata =>
            {
                metadata.Add(GrpcConsts.PubkeyMetadataKey, AsyncHelper.RunSync(() => _accountService.GetPublicKeyAsync()).ToHex());
                return metadata;
            }));

            if (channel.State != ChannelState.Ready)
            {
                var c = channel.WaitForStateChangedAsync(channel.State);
            }

            var pubKey = handshake.HskData.PublicKey.ToHex();
            var grpcPeer = new GrpcPeer(channel, client, pubKey, peerAddress);

            // Verify auth
            bool valid = _peerPool.IsAuthenticatePeer(pubKey);

            if (!valid)
            {
                await channel.ShutdownAsync();
                return new ConnectReply {Err = AuthError.WrongAuth};
            }

            // send our credentials
            var hsk = await _peerPool.GetHandshakeAsync();
            
            // If auth ok -> add it to our peers
            _peerPool.AddPeer(grpcPeer);

            return new ConnectReply { Handshake = hsk };
        }

        /// <summary>
        /// This method is called when another peer broadcasts a transaction.
        /// </summary>
        public override async Task<VoidReply> SendTransaction(Transaction tx, ServerCallContext context)
        {
            _ = EventBus.PublishAsync(new TransactionsReceivedEvent { Transactions = new List<Transaction> {tx} });

            return new VoidReply();
        }

        /// <summary>
        /// This method is called when a peer wants to broadcast an announcement.
        /// </summary>
        public override Task<VoidReply> Announce(PeerNewBlockAnnouncement an, ServerCallContext context)
        {
            if (an?.BlockHash == null)
            {
                Logger.LogError($"Received null announcement or header from {context.Peer}.");
                return Task.FromResult(new VoidReply());
            }

            var peerInPool = _peerPool.FindPeerByPublicKey(context.GetPublicKey());
            if (peerInPool != null)
            {
                peerInPool.CurrentBlockHash = an.BlockHash;
                peerInPool.CurrentBlockHeight = an.BlockHeight;
            }

            Logger.LogDebug($"Received announce {an.BlockHash} from {context.Peer}.");
            
            _ = EventBus.PublishAsync(new AnnouncementReceivedEventData(an, context.GetPublicKey()));

            return Task.FromResult(new VoidReply());
        }

        /// <summary>
        /// This method returns a block. The parameter is a <see cref="BlockRequest"/> object, if the value
        /// of <see cref="BlockRequest.Id"/> is not null, the request is by ID, otherwise it will be
        /// by height.
        /// </summary>
        public override async Task<BlockReply> RequestBlock(BlockRequest request, ServerCallContext context)
        {
            if (request == null || request.Hash == null) 
                return new BlockReply();
            
            Logger.LogDebug($"Peer {context.Peer} requested block {request.Hash}.");
            
            var block = await _blockChainService.GetBlockByHashAsync(request.Hash);

            Logger.LogDebug($"Sending {block} to {context.Peer}.");

            return new BlockReply { Block = block };
        }

        public override async Task<BlockList> RequestBlocks(BlocksRequest request, ServerCallContext context)
        {
            if (request == null || request.PreviousBlockHash == null) 
                return new BlockList();

            var blockList = new BlockList();
            
            var blocks = await _blockChainService.GetBlocksInBestChainBranchAsync(request.PreviousBlockHash, request.Count);

            if (blocks == null)
                return blockList;

            blockList.Blocks.AddRange(blocks);

            Logger.LogTrace($"Response {blockList.Blocks.Count} blocks for request {request}");
            return blockList;
        }

        /// <summary>
        /// Clients should call this method to disconnect explicitly.
        /// </summary>
        public override async Task<VoidReply> Disconnect(DisconnectReason request, ServerCallContext context)
        {
            await _peerPool.ProcessDisconnection(context.GetPublicKey());
            return new VoidReply();
        }
    }
}