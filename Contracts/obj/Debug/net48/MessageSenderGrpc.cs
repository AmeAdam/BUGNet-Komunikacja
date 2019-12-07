// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageSender.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Contracts {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class MessageSender
  {
    static readonly string __ServiceName = "Contracts.MessageSender";

    static readonly grpc::Marshaller<global::Contracts.Message2> __Marshaller_Contracts_Message2 = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Contracts.Message2.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Contracts.Reply> __Marshaller_Contracts_Reply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Contracts.Reply.Parser.ParseFrom);

    static readonly grpc::Method<global::Contracts.Message2, global::Contracts.Reply> __Method_Send = new grpc::Method<global::Contracts.Message2, global::Contracts.Reply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Send",
        __Marshaller_Contracts_Message2,
        __Marshaller_Contracts_Reply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Contracts.MessageSenderReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MessageSender</summary>
    public abstract partial class MessageSenderBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Contracts.Reply> Send(global::Contracts.Message2 request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MessageSender</summary>
    public partial class MessageSenderClient : grpc::ClientBase<MessageSenderClient>
    {
      /// <summary>Creates a new client for MessageSender</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MessageSenderClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MessageSender that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MessageSenderClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MessageSenderClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MessageSenderClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Contracts.Reply Send(global::Contracts.Message2 request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Send(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Contracts.Reply Send(global::Contracts.Message2 request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Send, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Contracts.Reply> SendAsync(global::Contracts.Message2 request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Contracts.Reply> SendAsync(global::Contracts.Message2 request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Send, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MessageSenderClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MessageSenderClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MessageSenderBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Send, serviceImpl.Send).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MessageSenderBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Send, serviceImpl.Send);
    }

  }
}
#endregion