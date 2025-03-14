// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/cx/v3/page.proto
// </auto-generated>
// Original file comments:
// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Dialogflow.Cx.V3 {
  /// <summary>
  /// Service for managing [Pages][google.cloud.dialogflow.cx.v3.Page].
  /// </summary>
  public static partial class Pages
  {
    static readonly string __ServiceName = "google.cloud.dialogflow.cx.v3.Pages";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListPagesRequest> __Marshaller_google_cloud_dialogflow_cx_v3_ListPagesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.ListPagesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListPagesResponse> __Marshaller_google_cloud_dialogflow_cx_v3_ListPagesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.ListPagesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.GetPageRequest> __Marshaller_google_cloud_dialogflow_cx_v3_GetPageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.GetPageRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.Page> __Marshaller_google_cloud_dialogflow_cx_v3_Page = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.Page.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.CreatePageRequest> __Marshaller_google_cloud_dialogflow_cx_v3_CreatePageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.CreatePageRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.UpdatePageRequest> __Marshaller_google_cloud_dialogflow_cx_v3_UpdatePageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.UpdatePageRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.DeletePageRequest> __Marshaller_google_cloud_dialogflow_cx_v3_DeletePageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.DeletePageRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListPagesRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListPagesResponse> __Method_ListPages = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListPagesRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListPagesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListPages",
        __Marshaller_google_cloud_dialogflow_cx_v3_ListPagesRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_ListPagesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetPageRequest, global::Google.Cloud.Dialogflow.Cx.V3.Page> __Method_GetPage = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetPageRequest, global::Google.Cloud.Dialogflow.Cx.V3.Page>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPage",
        __Marshaller_google_cloud_dialogflow_cx_v3_GetPageRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Page);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.CreatePageRequest, global::Google.Cloud.Dialogflow.Cx.V3.Page> __Method_CreatePage = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.CreatePageRequest, global::Google.Cloud.Dialogflow.Cx.V3.Page>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreatePage",
        __Marshaller_google_cloud_dialogflow_cx_v3_CreatePageRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Page);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.UpdatePageRequest, global::Google.Cloud.Dialogflow.Cx.V3.Page> __Method_UpdatePage = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.UpdatePageRequest, global::Google.Cloud.Dialogflow.Cx.V3.Page>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePage",
        __Marshaller_google_cloud_dialogflow_cx_v3_UpdatePageRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Page);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.DeletePageRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeletePage = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.DeletePageRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePage",
        __Marshaller_google_cloud_dialogflow_cx_v3_DeletePageRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dialogflow.Cx.V3.PageReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Pages</summary>
    [grpc::BindServiceMethod(typeof(Pages), "BindService")]
    public abstract partial class PagesBase
    {
      /// <summary>
      /// Returns the list of all pages in the specified flow.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.ListPagesResponse> ListPages(global::Google.Cloud.Dialogflow.Cx.V3.ListPagesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves the specified page.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Page> GetPage(global::Google.Cloud.Dialogflow.Cx.V3.GetPageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a page in the specified flow.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Page> CreatePage(global::Google.Cloud.Dialogflow.Cx.V3.CreatePageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the specified page.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Page> UpdatePage(global::Google.Cloud.Dialogflow.Cx.V3.UpdatePageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the specified page.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeletePage(global::Google.Cloud.Dialogflow.Cx.V3.DeletePageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Pages</summary>
    public partial class PagesClient : grpc::ClientBase<PagesClient>
    {
      /// <summary>Creates a new client for Pages</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PagesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Pages that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PagesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PagesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PagesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the list of all pages in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListPagesResponse ListPages(global::Google.Cloud.Dialogflow.Cx.V3.ListPagesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPages(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all pages in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListPagesResponse ListPages(global::Google.Cloud.Dialogflow.Cx.V3.ListPagesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListPages, null, options, request);
      }
      /// <summary>
      /// Returns the list of all pages in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListPagesResponse> ListPagesAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListPagesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPagesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all pages in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListPagesResponse> ListPagesAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListPagesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListPages, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified page.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Page GetPage(global::Google.Cloud.Dialogflow.Cx.V3.GetPageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified page.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Page GetPage(global::Google.Cloud.Dialogflow.Cx.V3.GetPageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPage, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified page.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Page> GetPageAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetPageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified page.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Page> GetPageAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetPageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPage, null, options, request);
      }
      /// <summary>
      /// Creates a page in the specified flow.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Page CreatePage(global::Google.Cloud.Dialogflow.Cx.V3.CreatePageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreatePage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a page in the specified flow.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Page CreatePage(global::Google.Cloud.Dialogflow.Cx.V3.CreatePageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreatePage, null, options, request);
      }
      /// <summary>
      /// Creates a page in the specified flow.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Page> CreatePageAsync(global::Google.Cloud.Dialogflow.Cx.V3.CreatePageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreatePageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a page in the specified flow.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Page> CreatePageAsync(global::Google.Cloud.Dialogflow.Cx.V3.CreatePageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreatePage, null, options, request);
      }
      /// <summary>
      /// Updates the specified page.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Page UpdatePage(global::Google.Cloud.Dialogflow.Cx.V3.UpdatePageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified page.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Page UpdatePage(global::Google.Cloud.Dialogflow.Cx.V3.UpdatePageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdatePage, null, options, request);
      }
      /// <summary>
      /// Updates the specified page.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Page> UpdatePageAsync(global::Google.Cloud.Dialogflow.Cx.V3.UpdatePageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified page.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Page> UpdatePageAsync(global::Google.Cloud.Dialogflow.Cx.V3.UpdatePageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdatePage, null, options, request);
      }
      /// <summary>
      /// Deletes the specified page.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeletePage(global::Google.Cloud.Dialogflow.Cx.V3.DeletePageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified page.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeletePage(global::Google.Cloud.Dialogflow.Cx.V3.DeletePageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeletePage, null, options, request);
      }
      /// <summary>
      /// Deletes the specified page.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeletePageAsync(global::Google.Cloud.Dialogflow.Cx.V3.DeletePageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified page.
      ///
      /// Note: You should always train a flow prior to sending it queries. See the
      /// [training
      /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeletePageAsync(global::Google.Cloud.Dialogflow.Cx.V3.DeletePageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeletePage, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PagesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PagesClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PagesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListPages, serviceImpl.ListPages)
          .AddMethod(__Method_GetPage, serviceImpl.GetPage)
          .AddMethod(__Method_CreatePage, serviceImpl.CreatePage)
          .AddMethod(__Method_UpdatePage, serviceImpl.UpdatePage)
          .AddMethod(__Method_DeletePage, serviceImpl.DeletePage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PagesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListPages, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.ListPagesRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListPagesResponse>(serviceImpl.ListPages));
      serviceBinder.AddMethod(__Method_GetPage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.GetPageRequest, global::Google.Cloud.Dialogflow.Cx.V3.Page>(serviceImpl.GetPage));
      serviceBinder.AddMethod(__Method_CreatePage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.CreatePageRequest, global::Google.Cloud.Dialogflow.Cx.V3.Page>(serviceImpl.CreatePage));
      serviceBinder.AddMethod(__Method_UpdatePage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.UpdatePageRequest, global::Google.Cloud.Dialogflow.Cx.V3.Page>(serviceImpl.UpdatePage));
      serviceBinder.AddMethod(__Method_DeletePage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.DeletePageRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeletePage));
    }

  }
}
#endregion
