// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/deployment_resource_pool.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/deployment_resource_pool.proto</summary>
  public static partial class DeploymentResourcePoolReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/deployment_resource_pool.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeploymentResourcePoolReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9kZXBsb3ltZW50X3Jlc291",
            "cmNlX3Bvb2wucHJvdG8SGmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGh9n",
            "b29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jl",
            "c291cmNlLnByb3RvGjBnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9lbmNy",
            "eXB0aW9uX3NwZWMucHJvdG8aMmdvb2dsZS9jbG91ZC9haXBsYXRmb3JtL3Yx",
            "L21hY2hpbmVfcmVzb3VyY2VzLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGlt",
            "ZXN0YW1wLnByb3RvIoEEChZEZXBsb3ltZW50UmVzb3VyY2VQb29sEhEKBG5h",
            "bWUYASABKAlCA+BBBRJQChNkZWRpY2F0ZWRfcmVzb3VyY2VzGAIgASgLMi4u",
            "Z29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuRGVkaWNhdGVkUmVzb3VyY2Vz",
            "QgPgQQISQwoPZW5jcnlwdGlvbl9zcGVjGAUgASgLMiouZ29vZ2xlLmNsb3Vk",
            "LmFpcGxhdGZvcm0udjEuRW5jcnlwdGlvblNwZWMSFwoPc2VydmljZV9hY2Nv",
            "dW50GAYgASgJEiEKGWRpc2FibGVfY29udGFpbmVyX2xvZ2dpbmcYByABKAgS",
            "NAoLY3JlYXRlX3RpbWUYBCABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0",
            "YW1wQgPgQQMSGgoNc2F0aXNmaWVzX3B6cxgIIAEoCEID4EEDEhoKDXNhdGlz",
            "Zmllc19wemkYCSABKAhCA+BBAzqSAepBjgEKMGFpcGxhdGZvcm0uZ29vZ2xl",
            "YXBpcy5jb20vRGVwbG95bWVudFJlc291cmNlUG9vbBJacHJvamVjdHMve3By",
            "b2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259L2RlcGxveW1lbnRSZXNvdXJj",
            "ZVBvb2xzL3tkZXBsb3ltZW50X3Jlc291cmNlX3Bvb2x9QtkBCh5jb20uZ29v",
            "Z2xlLmNsb3VkLmFpcGxhdGZvcm0udjFCG0RlcGxveW1lbnRSZXNvdXJjZVBv",
            "b2xQcm90b1ABWj5jbG91ZC5nb29nbGUuY29tL2dvL2FpcGxhdGZvcm0vYXBp",
            "djEvYWlwbGF0Zm9ybXBiO2FpcGxhdGZvcm1wYqoCGkdvb2dsZS5DbG91ZC5B",
            "SVBsYXRmb3JtLlYxygIaR29vZ2xlXENsb3VkXEFJUGxhdGZvcm1cVjHqAh1H",
            "b29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.EncryptionSpecReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.MachineResourcesReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.DeploymentResourcePool), global::Google.Cloud.AIPlatform.V1.DeploymentResourcePool.Parser, new[]{ "Name", "DedicatedResources", "EncryptionSpec", "ServiceAccount", "DisableContainerLogging", "CreateTime", "SatisfiesPzs", "SatisfiesPzi" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A description of resources that can be shared by multiple DeployedModels,
  /// whose underlying specification consists of a DedicatedResources.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DeploymentResourcePool : pb::IMessage<DeploymentResourcePool>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DeploymentResourcePool> _parser = new pb::MessageParser<DeploymentResourcePool>(() => new DeploymentResourcePool());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DeploymentResourcePool> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.DeploymentResourcePoolReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeploymentResourcePool() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeploymentResourcePool(DeploymentResourcePool other) : this() {
      name_ = other.name_;
      dedicatedResources_ = other.dedicatedResources_ != null ? other.dedicatedResources_.Clone() : null;
      encryptionSpec_ = other.encryptionSpec_ != null ? other.encryptionSpec_.Clone() : null;
      serviceAccount_ = other.serviceAccount_;
      disableContainerLogging_ = other.disableContainerLogging_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      satisfiesPzs_ = other.satisfiesPzs_;
      satisfiesPzi_ = other.satisfiesPzi_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeploymentResourcePool Clone() {
      return new DeploymentResourcePool(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Immutable. The resource name of the DeploymentResourcePool.
    /// Format:
    /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dedicated_resources" field.</summary>
    public const int DedicatedResourcesFieldNumber = 2;
    private global::Google.Cloud.AIPlatform.V1.DedicatedResources dedicatedResources_;
    /// <summary>
    /// Required. The underlying DedicatedResources that the DeploymentResourcePool
    /// uses.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.DedicatedResources DedicatedResources {
      get { return dedicatedResources_; }
      set {
        dedicatedResources_ = value;
      }
    }

    /// <summary>Field number for the "encryption_spec" field.</summary>
    public const int EncryptionSpecFieldNumber = 5;
    private global::Google.Cloud.AIPlatform.V1.EncryptionSpec encryptionSpec_;
    /// <summary>
    /// Customer-managed encryption key spec for a DeploymentResourcePool. If set,
    /// this DeploymentResourcePool will be secured by this key. Endpoints and the
    /// DeploymentResourcePool they deploy in need to have the same EncryptionSpec.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.EncryptionSpec EncryptionSpec {
      get { return encryptionSpec_; }
      set {
        encryptionSpec_ = value;
      }
    }

    /// <summary>Field number for the "service_account" field.</summary>
    public const int ServiceAccountFieldNumber = 6;
    private string serviceAccount_ = "";
    /// <summary>
    /// The service account that the DeploymentResourcePool's container(s) run as.
    /// Specify the email address of the service account. If this service account
    /// is not specified, the container(s) run as a service account that doesn't
    /// have access to the resource project.
    ///
    /// Users deploying the Models to this DeploymentResourcePool must have the
    /// `iam.serviceAccounts.actAs` permission on this service account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ServiceAccount {
      get { return serviceAccount_; }
      set {
        serviceAccount_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "disable_container_logging" field.</summary>
    public const int DisableContainerLoggingFieldNumber = 7;
    private bool disableContainerLogging_;
    /// <summary>
    /// If the DeploymentResourcePool is deployed with custom-trained Models or
    /// AutoML Tabular Models, the container(s) of the DeploymentResourcePool will
    /// send `stderr` and `stdout` streams to Cloud Logging by default.
    /// Please note that the logs incur cost, which are subject to [Cloud Logging
    /// pricing](https://cloud.google.com/logging/pricing).
    ///
    /// User can disable container logging by setting this flag to true.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool DisableContainerLogging {
      get { return disableContainerLogging_; }
      set {
        disableContainerLogging_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this DeploymentResourcePool was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "satisfies_pzs" field.</summary>
    public const int SatisfiesPzsFieldNumber = 8;
    private bool satisfiesPzs_;
    /// <summary>
    /// Output only. Reserved for future use.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SatisfiesPzs {
      get { return satisfiesPzs_; }
      set {
        satisfiesPzs_ = value;
      }
    }

    /// <summary>Field number for the "satisfies_pzi" field.</summary>
    public const int SatisfiesPziFieldNumber = 9;
    private bool satisfiesPzi_;
    /// <summary>
    /// Output only. Reserved for future use.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SatisfiesPzi {
      get { return satisfiesPzi_; }
      set {
        satisfiesPzi_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DeploymentResourcePool);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DeploymentResourcePool other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(DedicatedResources, other.DedicatedResources)) return false;
      if (!object.Equals(EncryptionSpec, other.EncryptionSpec)) return false;
      if (ServiceAccount != other.ServiceAccount) return false;
      if (DisableContainerLogging != other.DisableContainerLogging) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (SatisfiesPzs != other.SatisfiesPzs) return false;
      if (SatisfiesPzi != other.SatisfiesPzi) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (dedicatedResources_ != null) hash ^= DedicatedResources.GetHashCode();
      if (encryptionSpec_ != null) hash ^= EncryptionSpec.GetHashCode();
      if (ServiceAccount.Length != 0) hash ^= ServiceAccount.GetHashCode();
      if (DisableContainerLogging != false) hash ^= DisableContainerLogging.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (SatisfiesPzs != false) hash ^= SatisfiesPzs.GetHashCode();
      if (SatisfiesPzi != false) hash ^= SatisfiesPzi.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (dedicatedResources_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DedicatedResources);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      if (encryptionSpec_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EncryptionSpec);
      }
      if (ServiceAccount.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ServiceAccount);
      }
      if (DisableContainerLogging != false) {
        output.WriteRawTag(56);
        output.WriteBool(DisableContainerLogging);
      }
      if (SatisfiesPzs != false) {
        output.WriteRawTag(64);
        output.WriteBool(SatisfiesPzs);
      }
      if (SatisfiesPzi != false) {
        output.WriteRawTag(72);
        output.WriteBool(SatisfiesPzi);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (dedicatedResources_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DedicatedResources);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      if (encryptionSpec_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EncryptionSpec);
      }
      if (ServiceAccount.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ServiceAccount);
      }
      if (DisableContainerLogging != false) {
        output.WriteRawTag(56);
        output.WriteBool(DisableContainerLogging);
      }
      if (SatisfiesPzs != false) {
        output.WriteRawTag(64);
        output.WriteBool(SatisfiesPzs);
      }
      if (SatisfiesPzi != false) {
        output.WriteRawTag(72);
        output.WriteBool(SatisfiesPzi);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (dedicatedResources_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DedicatedResources);
      }
      if (encryptionSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EncryptionSpec);
      }
      if (ServiceAccount.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServiceAccount);
      }
      if (DisableContainerLogging != false) {
        size += 1 + 1;
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (SatisfiesPzs != false) {
        size += 1 + 1;
      }
      if (SatisfiesPzi != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DeploymentResourcePool other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.dedicatedResources_ != null) {
        if (dedicatedResources_ == null) {
          DedicatedResources = new global::Google.Cloud.AIPlatform.V1.DedicatedResources();
        }
        DedicatedResources.MergeFrom(other.DedicatedResources);
      }
      if (other.encryptionSpec_ != null) {
        if (encryptionSpec_ == null) {
          EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
        }
        EncryptionSpec.MergeFrom(other.EncryptionSpec);
      }
      if (other.ServiceAccount.Length != 0) {
        ServiceAccount = other.ServiceAccount;
      }
      if (other.DisableContainerLogging != false) {
        DisableContainerLogging = other.DisableContainerLogging;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.SatisfiesPzs != false) {
        SatisfiesPzs = other.SatisfiesPzs;
      }
      if (other.SatisfiesPzi != false) {
        SatisfiesPzi = other.SatisfiesPzi;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (dedicatedResources_ == null) {
              DedicatedResources = new global::Google.Cloud.AIPlatform.V1.DedicatedResources();
            }
            input.ReadMessage(DedicatedResources);
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42: {
            if (encryptionSpec_ == null) {
              EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
            }
            input.ReadMessage(EncryptionSpec);
            break;
          }
          case 50: {
            ServiceAccount = input.ReadString();
            break;
          }
          case 56: {
            DisableContainerLogging = input.ReadBool();
            break;
          }
          case 64: {
            SatisfiesPzs = input.ReadBool();
            break;
          }
          case 72: {
            SatisfiesPzi = input.ReadBool();
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (dedicatedResources_ == null) {
              DedicatedResources = new global::Google.Cloud.AIPlatform.V1.DedicatedResources();
            }
            input.ReadMessage(DedicatedResources);
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42: {
            if (encryptionSpec_ == null) {
              EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
            }
            input.ReadMessage(EncryptionSpec);
            break;
          }
          case 50: {
            ServiceAccount = input.ReadString();
            break;
          }
          case 56: {
            DisableContainerLogging = input.ReadBool();
            break;
          }
          case 64: {
            SatisfiesPzs = input.ReadBool();
            break;
          }
          case 72: {
            SatisfiesPzi = input.ReadBool();
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
