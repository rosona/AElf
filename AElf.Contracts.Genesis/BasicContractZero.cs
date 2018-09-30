﻿using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AElf.Kernel;
using AElf.Kernel.KernelAccount;
using AElf.Sdk.CSharp;
using AElf.Sdk.CSharp.Types;
using Google.Protobuf;

namespace AElf.Contracts.Genesis
{
    #region Field Names

    public static class FieldNames
    {
        public static readonly string ContractSerialNumber = "__ContractSerialNumber__";
        public static readonly string ContractInfos = "__ContractInfos__";
    }

    #endregion Field Names

    #region Events

    public class ContractHasBeenDeployed : Event
    {
        [Indexed] public Hash Creator;
        [Indexed] public Hash Address;
        [Indexed] public Hash CodeHash;
    }

    public class SideChainCreationRequested : Event
    {
        public Hash Creator;
        public Hash ChainId;
    }

    public class OwnerHasBeenChanged : Event
    {
        [Indexed] public Hash Address;
        [Indexed] public Hash OldOwner;
        [Indexed] public Hash NewOwner;
    }

    #endregion Events

    #region Customized Field Types

    internal class ContractSerialNumber : UInt64Field
    {
        internal static ContractSerialNumber Instance { get; } = new ContractSerialNumber();

        private ContractSerialNumber() : this(FieldNames.ContractSerialNumber)
        {
        }

        private ContractSerialNumber(string name) : base(name)
        {
        }

        private ulong _value;

        public ulong Value
        {
            get
            {
                if (_value == 0)
                {
                    _value = GetValue();
                }

                if (Globals.BasicContractZeroSerialNumber > _value)
                {
                    _value = Globals.BasicContractZeroSerialNumber;
                }
                return _value;
            }
            private set => _value = value;
        }

        public ContractSerialNumber Increment()
        {
            Value = Value + 1;
            SetValue(Value);
            Globals.BasicContractZeroSerialNumber = Value;
            return this;
        }
    }


    #endregion Customized Field Types

    public class BasicContractZero : CSharpSmartContract, ISmartContractZero
    {
        #region Fields

        private readonly ContractSerialNumber _contractSerialNumber = ContractSerialNumber.Instance;
        private readonly Map<Hash, ContractInfo> _contractInfos = new Map<Hash, ContractInfo>(FieldNames.ContractInfos);

        #endregion Fields

        [View]
        public ulong CurrentContractSerialNumber()
        {
            return _contractSerialNumber.Value;
        }

        [View]
        public string GetContractInfoFor(Hash contractAddress)
        {
            var info = _contractInfos[contractAddress];
            if (info == null)
            {
                return string.Empty;
            }

            return info.ToString();
        }

        public async Task<byte[]> DeploySmartContract(int category, byte[] code)
        {
            ulong serialNumber = _contractSerialNumber.Increment().Value;

            Hash creator = Api.GetTransaction().From;

            var info = new ContractInfo
            {
                Owner = creator,
                SerialNumber = serialNumber
            };

            var address = info.Address;

            _contractInfos[address] = info;

            var reg = new SmartContractRegistration
            {
                Category = category,
                ContractBytes = ByteString.CopyFrom(code),
                ContractHash = SHA256.Create().ComputeHash(code)
            };

            await Api.DeployContractAsync(address, reg);

            /*
            // TODO: Enable back
            // This is a quick fix, see https://github.com/AElfProject/AElf/issues/377
            new ContractHasBeenDeployed()
            {
                Creator = creator,
                Address = address,
                CodeHash = SHA256.Create().ComputeHash(code)
            }.Fire();
            */

            Console.WriteLine($"SerialNumber: {info.SerialNumber}");
            Console.WriteLine("BasicContractZero - Deployment success: " + address.ToHex());
            return address.GetHashBytes();
        }

        
        public void ChangeContractOwner(Hash contractAddress, Hash newOwner)
        {
            var info = _contractInfos[contractAddress];
            Api.Assert(info.Owner.Equals(Api.GetTransaction().From));
            var oldOwner = info.Owner;
            info.Owner = newOwner;
            _contractInfos[contractAddress] = info;
            new OwnerHasBeenChanged
            {
                Address = contractAddress,
                OldOwner = oldOwner,
                NewOwner = newOwner
            }.Fire();
        }

        public Hash GetContractOwner(Hash contractAddress)
        {
            var info = _contractInfos[contractAddress];
            return info.Owner;
        }
    }
}