// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/support/v2beta/escalation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Support.V2Beta {

  /// <summary>Holder for reflection information generated from google/cloud/support/v2beta/escalation.proto</summary>
  public static partial class EscalationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/support/v2beta/escalation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EscalationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvY2xvdWQvc3VwcG9ydC92MmJldGEvZXNjYWxhdGlvbi5wcm90",
            "bxIbZ29vZ2xlLmNsb3VkLnN1cHBvcnQudjJiZXRhGh9nb29nbGUvYXBpL2Zp",
            "ZWxkX2JlaGF2aW9yLnByb3RvItIBCgpFc2NhbGF0aW9uEkMKBnJlYXNvbhgE",
            "IAEoDjIuLmdvb2dsZS5jbG91ZC5zdXBwb3J0LnYyYmV0YS5Fc2NhbGF0aW9u",
            "LlJlYXNvbkID4EECEhoKDWp1c3RpZmljYXRpb24YBSABKAlCA+BBAiJjCgZS",
            "ZWFzb24SFgoSUkVBU09OX1VOU1BFQ0lGSUVEEAASEwoPUkVTT0xVVElPTl9U",
            "SU1FEAESFwoTVEVDSE5JQ0FMX0VYUEVSVElTRRACEhMKD0JVU0lORVNTX0lN",
            "UEFDVBADQswBCh9jb20uZ29vZ2xlLmNsb3VkLnN1cHBvcnQudjJiZXRhQg9F",
            "c2NhbGF0aW9uUHJvdG9QAVo5Y2xvdWQuZ29vZ2xlLmNvbS9nby9zdXBwb3J0",
            "L2FwaXYyYmV0YS9zdXBwb3J0cGI7c3VwcG9ydHBiqgIbR29vZ2xlLkNsb3Vk",
            "LlN1cHBvcnQuVjJCZXRhygIbR29vZ2xlXENsb3VkXFN1cHBvcnRcVjJiZXRh",
            "6gIeR29vZ2xlOjpDbG91ZDo6U3VwcG9ydDo6VjJiZXRhYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Support.V2Beta.Escalation), global::Google.Cloud.Support.V2Beta.Escalation.Parser, new[]{ "Reason", "Justification" }, null, new[]{ typeof(global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An escalation of a support case.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Escalation : pb::IMessage<Escalation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Escalation> _parser = new pb::MessageParser<Escalation>(() => new Escalation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Escalation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Support.V2Beta.EscalationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Escalation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Escalation(Escalation other) : this() {
      reason_ = other.reason_;
      justification_ = other.justification_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Escalation Clone() {
      return new Escalation(this);
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 4;
    private global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason reason_ = global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason.Unspecified;
    /// <summary>
    /// Required. The reason why the Case is being escalated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "justification" field.</summary>
    public const int JustificationFieldNumber = 5;
    private string justification_ = "";
    /// <summary>
    /// Required. A free text description to accompany the `reason` field above.
    /// Provides additional context on why the case is being escalated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Justification {
      get { return justification_; }
      set {
        justification_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Escalation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Escalation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Reason != other.Reason) return false;
      if (Justification != other.Justification) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Reason != global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason.Unspecified) hash ^= Reason.GetHashCode();
      if (Justification.Length != 0) hash ^= Justification.GetHashCode();
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
      if (Reason != global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Reason);
      }
      if (Justification.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Justification);
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
      if (Reason != global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Reason);
      }
      if (Justification.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Justification);
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
      if (Reason != global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (Justification.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Justification);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Escalation other) {
      if (other == null) {
        return;
      }
      if (other.Reason != global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason.Unspecified) {
        Reason = other.Reason;
      }
      if (other.Justification.Length != 0) {
        Justification = other.Justification;
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
          case 32: {
            Reason = (global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason) input.ReadEnum();
            break;
          }
          case 42: {
            Justification = input.ReadString();
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
          case 32: {
            Reason = (global::Google.Cloud.Support.V2Beta.Escalation.Types.Reason) input.ReadEnum();
            break;
          }
          case 42: {
            Justification = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Escalation message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// An enum detailing the possible reasons a case may be escalated.
      /// </summary>
      public enum Reason {
        /// <summary>
        /// The escalation reason is in an unknown state or has not been specified.
        /// </summary>
        [pbr::OriginalName("REASON_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The case is taking too long to resolve.
        /// </summary>
        [pbr::OriginalName("RESOLUTION_TIME")] ResolutionTime = 1,
        /// <summary>
        /// The support agent does not have the expertise required to successfully
        /// resolve the issue.
        /// </summary>
        [pbr::OriginalName("TECHNICAL_EXPERTISE")] TechnicalExpertise = 2,
        /// <summary>
        /// The issue is having a significant business impact.
        /// </summary>
        [pbr::OriginalName("BUSINESS_IMPACT")] BusinessImpact = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
