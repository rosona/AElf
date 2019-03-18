// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: token_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using aelf = global::AElf.Types.CSharp;

namespace AElf.Contracts.MultiToken.Messages {
  public static partial class TokenContractContainer
  {
    static readonly string __ServiceName = "TokenContract";

    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.CreateInput> __Marshaller_CreateInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.CreateInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.Nothing> __Marshaller_Nothing = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.Nothing.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.IssueInput> __Marshaller_IssueInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.IssueInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.TransferInput> __Marshaller_TransferInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.TransferInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.TransferFromInput> __Marshaller_TransferFromInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.TransferFromInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.ApproveInput> __Marshaller_ApproveInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.ApproveInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.UnApproveInput> __Marshaller_UnApproveInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.UnApproveInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.BurnInput> __Marshaller_BurnInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.BurnInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.ChargeTransactionFeesInput> __Marshaller_ChargeTransactionFeesInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.ChargeTransactionFeesInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.ClaimTransactionFeesInput> __Marshaller_ClaimTransactionFeesInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.ClaimTransactionFeesInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Common.Address> __Marshaller_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Common.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.GetTokenInfoInput> __Marshaller_GetTokenInfoInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.GetTokenInfoInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.TokenInfo> __Marshaller_TokenInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.TokenInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.GetBalanceInput> __Marshaller_GetBalanceInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.GetBalanceInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.GetBalanceOutput> __Marshaller_GetBalanceOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.GetBalanceOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.GetAllowanceInput> __Marshaller_GetAllowanceInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.GetAllowanceInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.MultiToken.Messages.GetAllowanceOutput> __Marshaller_GetAllowanceOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.MultiToken.Messages.GetAllowanceOutput.Parser.ParseFrom);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.CreateInput, global::AElf.Contracts.MultiToken.Messages.Nothing> __Method_Create = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.CreateInput, global::AElf.Contracts.MultiToken.Messages.Nothing>(
        aelf::MethodType.Action,
        __ServiceName,
        "Create",
        __Marshaller_CreateInput,
        __Marshaller_Nothing);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.IssueInput, global::AElf.Contracts.MultiToken.Messages.Nothing> __Method_Issue = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.IssueInput, global::AElf.Contracts.MultiToken.Messages.Nothing>(
        aelf::MethodType.Action,
        __ServiceName,
        "Issue",
        __Marshaller_IssueInput,
        __Marshaller_Nothing);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.TransferInput, global::AElf.Contracts.MultiToken.Messages.Nothing> __Method_Transfer = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.TransferInput, global::AElf.Contracts.MultiToken.Messages.Nothing>(
        aelf::MethodType.Action,
        __ServiceName,
        "Transfer",
        __Marshaller_TransferInput,
        __Marshaller_Nothing);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.TransferFromInput, global::AElf.Contracts.MultiToken.Messages.Nothing> __Method_TransferFrom = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.TransferFromInput, global::AElf.Contracts.MultiToken.Messages.Nothing>(
        aelf::MethodType.Action,
        __ServiceName,
        "TransferFrom",
        __Marshaller_TransferFromInput,
        __Marshaller_Nothing);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.ApproveInput, global::AElf.Contracts.MultiToken.Messages.Nothing> __Method_Approve = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.ApproveInput, global::AElf.Contracts.MultiToken.Messages.Nothing>(
        aelf::MethodType.Action,
        __ServiceName,
        "Approve",
        __Marshaller_ApproveInput,
        __Marshaller_Nothing);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.UnApproveInput, global::AElf.Contracts.MultiToken.Messages.Nothing> __Method_UnApprove = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.UnApproveInput, global::AElf.Contracts.MultiToken.Messages.Nothing>(
        aelf::MethodType.Action,
        __ServiceName,
        "UnApprove",
        __Marshaller_UnApproveInput,
        __Marshaller_Nothing);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.BurnInput, global::AElf.Contracts.MultiToken.Messages.Nothing> __Method_Burn = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.BurnInput, global::AElf.Contracts.MultiToken.Messages.Nothing>(
        aelf::MethodType.Action,
        __ServiceName,
        "Burn",
        __Marshaller_BurnInput,
        __Marshaller_Nothing);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.ChargeTransactionFeesInput, global::AElf.Contracts.MultiToken.Messages.Nothing> __Method_ChargeTransactionFees = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.ChargeTransactionFeesInput, global::AElf.Contracts.MultiToken.Messages.Nothing>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChargeTransactionFees",
        __Marshaller_ChargeTransactionFeesInput,
        __Marshaller_Nothing);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.ClaimTransactionFeesInput, global::AElf.Contracts.MultiToken.Messages.Nothing> __Method_ClaimTransactionFees = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.ClaimTransactionFeesInput, global::AElf.Contracts.MultiToken.Messages.Nothing>(
        aelf::MethodType.Action,
        __ServiceName,
        "ClaimTransactionFees",
        __Marshaller_ClaimTransactionFeesInput,
        __Marshaller_Nothing);

    static readonly aelf::Method<global::AElf.Common.Address, global::AElf.Contracts.MultiToken.Messages.Nothing> __Method_SetConsensusContractAddress = new aelf::Method<global::AElf.Common.Address, global::AElf.Contracts.MultiToken.Messages.Nothing>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetConsensusContractAddress",
        __Marshaller_Address,
        __Marshaller_Nothing);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.GetTokenInfoInput, global::AElf.Contracts.MultiToken.Messages.TokenInfo> __Method_GetTokenInfo = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.GetTokenInfoInput, global::AElf.Contracts.MultiToken.Messages.TokenInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetTokenInfo",
        __Marshaller_GetTokenInfoInput,
        __Marshaller_TokenInfo);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.GetBalanceInput, global::AElf.Contracts.MultiToken.Messages.GetBalanceOutput> __Method_GetBalance = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.GetBalanceInput, global::AElf.Contracts.MultiToken.Messages.GetBalanceOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetBalance",
        __Marshaller_GetBalanceInput,
        __Marshaller_GetBalanceOutput);

    static readonly aelf::Method<global::AElf.Contracts.MultiToken.Messages.GetAllowanceInput, global::AElf.Contracts.MultiToken.Messages.GetAllowanceOutput> __Method_GetAllowance = new aelf::Method<global::AElf.Contracts.MultiToken.Messages.GetAllowanceInput, global::AElf.Contracts.MultiToken.Messages.GetAllowanceOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetAllowance",
        __Marshaller_GetAllowanceInput,
        __Marshaller_GetAllowanceOutput);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.MultiToken.Messages.TokenContractReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for the contract of TokenContract</summary>
    public abstract partial class TokenContractBase : AElf.Sdk.CSharp.CSharpSmartContract<AElf.Contracts.MultiToken.TokenContractState>
    {
      /// <summary>
      /// Actions
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::AElf.Contracts.MultiToken.Messages.Nothing Create(global::AElf.Contracts.MultiToken.Messages.CreateInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.Nothing Issue(global::AElf.Contracts.MultiToken.Messages.IssueInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.Nothing Transfer(global::AElf.Contracts.MultiToken.Messages.TransferInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.Nothing TransferFrom(global::AElf.Contracts.MultiToken.Messages.TransferFromInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.Nothing Approve(global::AElf.Contracts.MultiToken.Messages.ApproveInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.Nothing UnApprove(global::AElf.Contracts.MultiToken.Messages.UnApproveInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.Nothing Burn(global::AElf.Contracts.MultiToken.Messages.BurnInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.Nothing ChargeTransactionFees(global::AElf.Contracts.MultiToken.Messages.ChargeTransactionFeesInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.Nothing ClaimTransactionFees(global::AElf.Contracts.MultiToken.Messages.ClaimTransactionFeesInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.Nothing SetConsensusContractAddress(global::AElf.Common.Address request)
      {
        throw new global::System.NotImplementedException();
      }

      /// <summary>
      /// Views
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::AElf.Contracts.MultiToken.Messages.TokenInfo GetTokenInfo(global::AElf.Contracts.MultiToken.Messages.GetTokenInfoInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.GetBalanceOutput GetBalance(global::AElf.Contracts.MultiToken.Messages.GetBalanceInput request)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.MultiToken.Messages.GetAllowanceOutput GetAllowance(global::AElf.Contracts.MultiToken.Messages.GetAllowanceInput request)
      {
        throw new global::System.NotImplementedException();
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static aelf::ServerServiceDefinition BindService(TokenContractBase serviceImpl)
    {
      return aelf::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Create, serviceImpl.Create)
          .AddMethod(__Method_Issue, serviceImpl.Issue)
          .AddMethod(__Method_Transfer, serviceImpl.Transfer)
          .AddMethod(__Method_TransferFrom, serviceImpl.TransferFrom)
          .AddMethod(__Method_Approve, serviceImpl.Approve)
          .AddMethod(__Method_UnApprove, serviceImpl.UnApprove)
          .AddMethod(__Method_Burn, serviceImpl.Burn)
          .AddMethod(__Method_ChargeTransactionFees, serviceImpl.ChargeTransactionFees)
          .AddMethod(__Method_ClaimTransactionFees, serviceImpl.ClaimTransactionFees)
          .AddMethod(__Method_SetConsensusContractAddress, serviceImpl.SetConsensusContractAddress)
          .AddMethod(__Method_GetTokenInfo, serviceImpl.GetTokenInfo)
          .AddMethod(__Method_GetBalance, serviceImpl.GetBalance)
          .AddMethod(__Method_GetAllowance, serviceImpl.GetAllowance).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(aelf::ServiceBinderBase serviceBinder, TokenContractBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Create, serviceImpl.Create);
      serviceBinder.AddMethod(__Method_Issue, serviceImpl.Issue);
      serviceBinder.AddMethod(__Method_Transfer, serviceImpl.Transfer);
      serviceBinder.AddMethod(__Method_TransferFrom, serviceImpl.TransferFrom);
      serviceBinder.AddMethod(__Method_Approve, serviceImpl.Approve);
      serviceBinder.AddMethod(__Method_UnApprove, serviceImpl.UnApprove);
      serviceBinder.AddMethod(__Method_Burn, serviceImpl.Burn);
      serviceBinder.AddMethod(__Method_ChargeTransactionFees, serviceImpl.ChargeTransactionFees);
      serviceBinder.AddMethod(__Method_ClaimTransactionFees, serviceImpl.ClaimTransactionFees);
      serviceBinder.AddMethod(__Method_SetConsensusContractAddress, serviceImpl.SetConsensusContractAddress);
      serviceBinder.AddMethod(__Method_GetTokenInfo, serviceImpl.GetTokenInfo);
      serviceBinder.AddMethod(__Method_GetBalance, serviceImpl.GetBalance);
      serviceBinder.AddMethod(__Method_GetAllowance, serviceImpl.GetAllowance);
    }

  }
}
#endregion