// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/llm_utility_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/llm_utility_service.proto</summary>
  public static partial class LlmUtilityServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/llm_utility_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LlmUtilityServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9sbG1fdXRpbGl0eV9zZXJ2",
            "aWNlLnByb3RvEhpnb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MRocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJv",
            "dG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9h",
            "cGkvcmVzb3VyY2UucHJvdG8aKGdvb2dsZS9jbG91ZC9haXBsYXRmb3JtL3Yx",
            "L2NvbnRlbnQucHJvdG8aM2dvb2dsZS9jbG91ZC9haXBsYXRmb3JtL3YxL3By",
            "ZWRpY3Rpb25fc2VydmljZS5wcm90bxocZ29vZ2xlL3Byb3RvYnVmL3N0cnVj",
            "dC5wcm90byLUAQoUQ29tcHV0ZVRva2Vuc1JlcXVlc3QSPAoIZW5kcG9pbnQY",
            "ASABKAlCKuBBAvpBJAoiYWlwbGF0Zm9ybS5nb29nbGVhcGlzLmNvbS9FbmRw",
            "b2ludBIuCglpbnN0YW5jZXMYAiADKAsyFi5nb29nbGUucHJvdG9idWYuVmFs",
            "dWVCA+BBARISCgVtb2RlbBgDIAEoCUID4EEBEjoKCGNvbnRlbnRzGAQgAygL",
            "MiMuZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuQ29udGVudEID4EEBIkIK",
            "ClRva2Vuc0luZm8SDgoGdG9rZW5zGAEgAygMEhEKCXRva2VuX2lkcxgCIAMo",
            "AxIRCgRyb2xlGAMgASgJQgPgQQEiVAoVQ29tcHV0ZVRva2Vuc1Jlc3BvbnNl",
            "EjsKC3Rva2Vuc19pbmZvGAEgAygLMiYuZ29vZ2xlLmNsb3VkLmFpcGxhdGZv",
            "cm0udjEuVG9rZW5zSW5mbzL4BgoRTGxtVXRpbGl0eVNlcnZpY2USgQMKC0Nv",
            "dW50VG9rZW5zEi4uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuQ291bnRU",
            "b2tlbnNSZXF1ZXN0Gi8uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuQ291",
            "bnRUb2tlbnNSZXNwb25zZSKQAtpBEmVuZHBvaW50LGluc3RhbmNlc4LT5JMC",
            "9AEiPS92MS97ZW5kcG9pbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9lbmRw",
            "b2ludHMvKn06Y291bnRUb2tlbnM6ASpaTCJHL3YxL3tlbmRwb2ludD1wcm9q",
            "ZWN0cy8qL2xvY2F0aW9ucy8qL3B1Ymxpc2hlcnMvKi9tb2RlbHMvKn06Y291",
            "bnRUb2tlbnM6ASpaKyImL3YxL3tlbmRwb2ludD1lbmRwb2ludHMvKn06Y291",
            "bnRUb2tlbnM6ASpaNSIwL3YxL3tlbmRwb2ludD1wdWJsaXNoZXJzLyovbW9k",
            "ZWxzLyp9OmNvdW50VG9rZW5zOgEqEo8DCg1Db21wdXRlVG9rZW5zEjAuZ29v",
            "Z2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuQ29tcHV0ZVRva2Vuc1JlcXVlc3Qa",
            "MS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5Db21wdXRlVG9rZW5zUmVz",
            "cG9uc2UimALaQRJlbmRwb2ludCxpbnN0YW5jZXOC0+STAvwBIj8vdjEve2Vu",
            "ZHBvaW50PXByb2plY3RzLyovbG9jYXRpb25zLyovZW5kcG9pbnRzLyp9OmNv",
            "bXB1dGVUb2tlbnM6ASpaTiJJL3YxL3tlbmRwb2ludD1wcm9qZWN0cy8qL2xv",
            "Y2F0aW9ucy8qL3B1Ymxpc2hlcnMvKi9tb2RlbHMvKn06Y29tcHV0ZVRva2Vu",
            "czoBKlotIigvdjEve2VuZHBvaW50PWVuZHBvaW50cy8qfTpjb21wdXRlVG9r",
            "ZW5zOgEqWjciMi92MS97ZW5kcG9pbnQ9cHVibGlzaGVycy8qL21vZGVscy8q",
            "fTpjb21wdXRlVG9rZW5zOgEqGk3KQRlhaXBsYXRmb3JtLmdvb2dsZWFwaXMu",
            "Y29t0kEuaHR0cHM6Ly93d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9jbG91ZC1w",
            "bGF0Zm9ybULUAQoeY29tLmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxQhZM",
            "bG1VdGlsaXR5U2VydmljZVByb3RvUAFaPmNsb3VkLmdvb2dsZS5jb20vZ28v",
            "YWlwbGF0Zm9ybS9hcGl2MS9haXBsYXRmb3JtcGI7YWlwbGF0Zm9ybXBiqgIa",
            "R29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0uVjHKAhpHb29nbGVcQ2xvdWRcQUlQ",
            "bGF0Zm9ybVxWMeoCHUdvb2dsZTo6Q2xvdWQ6OkFJUGxhdGZvcm06OlYxYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.ContentReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.PredictionServiceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.ComputeTokensRequest), global::Google.Cloud.AIPlatform.V1.ComputeTokensRequest.Parser, new[]{ "Endpoint", "Instances", "Model", "Contents" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.TokensInfo), global::Google.Cloud.AIPlatform.V1.TokensInfo.Parser, new[]{ "Tokens", "TokenIds", "Role" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.ComputeTokensResponse), global::Google.Cloud.AIPlatform.V1.ComputeTokensResponse.Parser, new[]{ "TokensInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for ComputeTokens RPC call.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ComputeTokensRequest : pb::IMessage<ComputeTokensRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ComputeTokensRequest> _parser = new pb::MessageParser<ComputeTokensRequest>(() => new ComputeTokensRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ComputeTokensRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.LlmUtilityServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComputeTokensRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComputeTokensRequest(ComputeTokensRequest other) : this() {
      endpoint_ = other.endpoint_;
      instances_ = other.instances_.Clone();
      model_ = other.model_;
      contents_ = other.contents_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComputeTokensRequest Clone() {
      return new ComputeTokensRequest(this);
    }

    /// <summary>Field number for the "endpoint" field.</summary>
    public const int EndpointFieldNumber = 1;
    private string endpoint_ = "";
    /// <summary>
    /// Required. The name of the Endpoint requested to get lists of tokens and
    /// token ids.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Endpoint {
      get { return endpoint_; }
      set {
        endpoint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "instances" field.</summary>
    public const int InstancesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Value> _repeated_instances_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.Value.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Value> instances_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Value>();
    /// <summary>
    /// Optional. The instances that are the input to token computing API call.
    /// Schema is identical to the prediction schema of the text model, even for
    /// the non-text models, like chat models, or Codey models.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Value> Instances {
      get { return instances_; }
    }

    /// <summary>Field number for the "model" field.</summary>
    public const int ModelFieldNumber = 3;
    private string model_ = "";
    /// <summary>
    /// Optional. The name of the publisher model requested to serve the
    /// prediction. Format:
    /// projects/{project}/locations/{location}/publishers/*/models/*
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Model {
      get { return model_; }
      set {
        model_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "contents" field.</summary>
    public const int ContentsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Cloud.AIPlatform.V1.Content> _repeated_contents_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Cloud.AIPlatform.V1.Content.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.Content> contents_ = new pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.Content>();
    /// <summary>
    /// Optional. Input content.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.Content> Contents {
      get { return contents_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ComputeTokensRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ComputeTokensRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Endpoint != other.Endpoint) return false;
      if(!instances_.Equals(other.instances_)) return false;
      if (Model != other.Model) return false;
      if(!contents_.Equals(other.contents_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Endpoint.Length != 0) hash ^= Endpoint.GetHashCode();
      hash ^= instances_.GetHashCode();
      if (Model.Length != 0) hash ^= Model.GetHashCode();
      hash ^= contents_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Endpoint.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Endpoint);
      }
      instances_.WriteTo(output, _repeated_instances_codec);
      if (Model.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Model);
      }
      contents_.WriteTo(output, _repeated_contents_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Endpoint.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Endpoint);
      }
      instances_.WriteTo(ref output, _repeated_instances_codec);
      if (Model.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Model);
      }
      contents_.WriteTo(ref output, _repeated_contents_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Endpoint.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Endpoint);
      }
      size += instances_.CalculateSize(_repeated_instances_codec);
      if (Model.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Model);
      }
      size += contents_.CalculateSize(_repeated_contents_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ComputeTokensRequest other) {
      if (other == null) {
        return;
      }
      if (other.Endpoint.Length != 0) {
        Endpoint = other.Endpoint;
      }
      instances_.Add(other.instances_);
      if (other.Model.Length != 0) {
        Model = other.Model;
      }
      contents_.Add(other.contents_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Endpoint = input.ReadString();
            break;
          }
          case 18: {
            instances_.AddEntriesFrom(input, _repeated_instances_codec);
            break;
          }
          case 26: {
            Model = input.ReadString();
            break;
          }
          case 34: {
            contents_.AddEntriesFrom(input, _repeated_contents_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Endpoint = input.ReadString();
            break;
          }
          case 18: {
            instances_.AddEntriesFrom(ref input, _repeated_instances_codec);
            break;
          }
          case 26: {
            Model = input.ReadString();
            break;
          }
          case 34: {
            contents_.AddEntriesFrom(ref input, _repeated_contents_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Tokens info with a list of tokens and the corresponding list of token ids.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TokensInfo : pb::IMessage<TokensInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TokensInfo> _parser = new pb::MessageParser<TokensInfo>(() => new TokensInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TokensInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.LlmUtilityServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TokensInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TokensInfo(TokensInfo other) : this() {
      tokens_ = other.tokens_.Clone();
      tokenIds_ = other.tokenIds_.Clone();
      role_ = other.role_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TokensInfo Clone() {
      return new TokensInfo(this);
    }

    /// <summary>Field number for the "tokens" field.</summary>
    public const int TokensFieldNumber = 1;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_tokens_codec
        = pb::FieldCodec.ForBytes(10);
    private readonly pbc::RepeatedField<pb::ByteString> tokens_ = new pbc::RepeatedField<pb::ByteString>();
    /// <summary>
    /// A list of tokens from the input.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<pb::ByteString> Tokens {
      get { return tokens_; }
    }

    /// <summary>Field number for the "token_ids" field.</summary>
    public const int TokenIdsFieldNumber = 2;
    private static readonly pb::FieldCodec<long> _repeated_tokenIds_codec
        = pb::FieldCodec.ForInt64(18);
    private readonly pbc::RepeatedField<long> tokenIds_ = new pbc::RepeatedField<long>();
    /// <summary>
    /// A list of token ids from the input.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<long> TokenIds {
      get { return tokenIds_; }
    }

    /// <summary>Field number for the "role" field.</summary>
    public const int RoleFieldNumber = 3;
    private string role_ = "";
    /// <summary>
    /// Optional. Optional fields for the role from the corresponding Content.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Role {
      get { return role_; }
      set {
        role_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TokensInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TokensInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!tokens_.Equals(other.tokens_)) return false;
      if(!tokenIds_.Equals(other.tokenIds_)) return false;
      if (Role != other.Role) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= tokens_.GetHashCode();
      hash ^= tokenIds_.GetHashCode();
      if (Role.Length != 0) hash ^= Role.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      tokens_.WriteTo(output, _repeated_tokens_codec);
      tokenIds_.WriteTo(output, _repeated_tokenIds_codec);
      if (Role.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Role);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      tokens_.WriteTo(ref output, _repeated_tokens_codec);
      tokenIds_.WriteTo(ref output, _repeated_tokenIds_codec);
      if (Role.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Role);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += tokens_.CalculateSize(_repeated_tokens_codec);
      size += tokenIds_.CalculateSize(_repeated_tokenIds_codec);
      if (Role.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Role);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TokensInfo other) {
      if (other == null) {
        return;
      }
      tokens_.Add(other.tokens_);
      tokenIds_.Add(other.tokenIds_);
      if (other.Role.Length != 0) {
        Role = other.Role;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            tokens_.AddEntriesFrom(input, _repeated_tokens_codec);
            break;
          }
          case 18:
          case 16: {
            tokenIds_.AddEntriesFrom(input, _repeated_tokenIds_codec);
            break;
          }
          case 26: {
            Role = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            tokens_.AddEntriesFrom(ref input, _repeated_tokens_codec);
            break;
          }
          case 18:
          case 16: {
            tokenIds_.AddEntriesFrom(ref input, _repeated_tokenIds_codec);
            break;
          }
          case 26: {
            Role = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for ComputeTokens RPC call.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ComputeTokensResponse : pb::IMessage<ComputeTokensResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ComputeTokensResponse> _parser = new pb::MessageParser<ComputeTokensResponse>(() => new ComputeTokensResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ComputeTokensResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.LlmUtilityServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComputeTokensResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComputeTokensResponse(ComputeTokensResponse other) : this() {
      tokensInfo_ = other.tokensInfo_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComputeTokensResponse Clone() {
      return new ComputeTokensResponse(this);
    }

    /// <summary>Field number for the "tokens_info" field.</summary>
    public const int TokensInfoFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.AIPlatform.V1.TokensInfo> _repeated_tokensInfo_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.AIPlatform.V1.TokensInfo.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.TokensInfo> tokensInfo_ = new pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.TokensInfo>();
    /// <summary>
    /// Lists of tokens info from the input. A ComputeTokensRequest could have
    /// multiple instances with a prompt in each instance. We also need to return
    /// lists of tokens info for the request with multiple instances.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.TokensInfo> TokensInfo {
      get { return tokensInfo_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ComputeTokensResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ComputeTokensResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!tokensInfo_.Equals(other.tokensInfo_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= tokensInfo_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      tokensInfo_.WriteTo(output, _repeated_tokensInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      tokensInfo_.WriteTo(ref output, _repeated_tokensInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += tokensInfo_.CalculateSize(_repeated_tokensInfo_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ComputeTokensResponse other) {
      if (other == null) {
        return;
      }
      tokensInfo_.Add(other.tokensInfo_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            tokensInfo_.AddEntriesFrom(input, _repeated_tokensInfo_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            tokensInfo_.AddEntriesFrom(ref input, _repeated_tokensInfo_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
