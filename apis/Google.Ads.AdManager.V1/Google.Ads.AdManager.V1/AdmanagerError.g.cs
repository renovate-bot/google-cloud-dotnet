// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/admanager/v1/admanager_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.AdManager.V1 {

  /// <summary>Holder for reflection information generated from google/ads/admanager/v1/admanager_error.proto</summary>
  public static partial class AdmanagerErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/admanager/v1/admanager_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdmanagerErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvYWRzL2FkbWFuYWdlci92MS9hZG1hbmFnZXJfZXJyb3IucHJv",
            "dG8SF2dvb2dsZS5hZHMuYWRtYW5hZ2VyLnYxGhlnb29nbGUvcHJvdG9idWYv",
            "YW55LnByb3RvIpYBCg5BZE1hbmFnZXJFcnJvchISCgplcnJvcl9jb2RlGAEg",
            "ASgJEg8KB21lc3NhZ2UYAiABKAkSEgoKZmllbGRfcGF0aBgDIAEoCRIPCgd0",
            "cmlnZ2VyGAQgASgJEhMKC3N0YWNrX3RyYWNlGAUgASgJEiUKB2RldGFpbHMY",
            "BiADKAsyFC5nb29nbGUucHJvdG9idWYuQW55QscBChtjb20uZ29vZ2xlLmFk",
            "cy5hZG1hbmFnZXIudjFCE0FkTWFuYWdlckVycm9yUHJvdG9QAVpAZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvYWRtYW5hZ2Vy",
            "L3YxO2FkbWFuYWdlcqoCF0dvb2dsZS5BZHMuQWRNYW5hZ2VyLlYxygIXR29v",
            "Z2xlXEFkc1xBZE1hbmFnZXJcVjHqAhpHb29nbGU6OkFkczo6QWRNYW5hZ2Vy",
            "OjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.AdManager.V1.AdManagerError), global::Google.Ads.AdManager.V1.AdManagerError.Parser, new[]{ "ErrorCode", "Message", "FieldPath", "Trigger", "StackTrace", "Details" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// / AdManagerError contains all the information required for processing a
  /// / particular error thrown by the AdManager API.
  /// /
  /// / At least one AdManagerError should be included in all error messages sent
  /// to / the client.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AdManagerError : pb::IMessage<AdManagerError>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdManagerError> _parser = new pb::MessageParser<AdManagerError>(() => new AdManagerError());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdManagerError> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.AdManager.V1.AdmanagerErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdManagerError() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdManagerError(AdManagerError other) : this() {
      errorCode_ = other.errorCode_;
      message_ = other.message_;
      fieldPath_ = other.fieldPath_;
      trigger_ = other.trigger_;
      stackTrace_ = other.stackTrace_;
      details_ = other.details_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdManagerError Clone() {
      return new AdManagerError(this);
    }

    /// <summary>Field number for the "error_code" field.</summary>
    public const int ErrorCodeFieldNumber = 1;
    private string errorCode_ = "";
    /// <summary>
    /// The unique identifying string for this error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ErrorCode {
      get { return errorCode_; }
      set {
        errorCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    /// <summary>
    /// A publisher appropriate explanation of this error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "field_path" field.</summary>
    public const int FieldPathFieldNumber = 3;
    private string fieldPath_ = "";
    /// <summary>
    /// The field path that triggered this error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FieldPath {
      get { return fieldPath_; }
      set {
        fieldPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "trigger" field.</summary>
    public const int TriggerFieldNumber = 4;
    private string trigger_ = "";
    /// <summary>
    /// The value that triggered this error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Trigger {
      get { return trigger_; }
      set {
        trigger_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stack_trace" field.</summary>
    public const int StackTraceFieldNumber = 5;
    private string stackTrace_ = "";
    /// <summary>
    /// The stack trace that accompanies this error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StackTrace {
      get { return stackTrace_; }
      set {
        stackTrace_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "details" field.</summary>
    public const int DetailsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Any> _repeated_details_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Protobuf.WellKnownTypes.Any.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> details_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any>();
    /// <summary>
    /// A list of messages that carry any additional error details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> Details {
      get { return details_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdManagerError);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdManagerError other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ErrorCode != other.ErrorCode) return false;
      if (Message != other.Message) return false;
      if (FieldPath != other.FieldPath) return false;
      if (Trigger != other.Trigger) return false;
      if (StackTrace != other.StackTrace) return false;
      if(!details_.Equals(other.details_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ErrorCode.Length != 0) hash ^= ErrorCode.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (FieldPath.Length != 0) hash ^= FieldPath.GetHashCode();
      if (Trigger.Length != 0) hash ^= Trigger.GetHashCode();
      if (StackTrace.Length != 0) hash ^= StackTrace.GetHashCode();
      hash ^= details_.GetHashCode();
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
      if (ErrorCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ErrorCode);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (FieldPath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FieldPath);
      }
      if (Trigger.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Trigger);
      }
      if (StackTrace.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StackTrace);
      }
      details_.WriteTo(output, _repeated_details_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ErrorCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ErrorCode);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (FieldPath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FieldPath);
      }
      if (Trigger.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Trigger);
      }
      if (StackTrace.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StackTrace);
      }
      details_.WriteTo(ref output, _repeated_details_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ErrorCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ErrorCode);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (FieldPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FieldPath);
      }
      if (Trigger.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Trigger);
      }
      if (StackTrace.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StackTrace);
      }
      size += details_.CalculateSize(_repeated_details_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdManagerError other) {
      if (other == null) {
        return;
      }
      if (other.ErrorCode.Length != 0) {
        ErrorCode = other.ErrorCode;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.FieldPath.Length != 0) {
        FieldPath = other.FieldPath;
      }
      if (other.Trigger.Length != 0) {
        Trigger = other.Trigger;
      }
      if (other.StackTrace.Length != 0) {
        StackTrace = other.StackTrace;
      }
      details_.Add(other.details_);
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
            ErrorCode = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            FieldPath = input.ReadString();
            break;
          }
          case 34: {
            Trigger = input.ReadString();
            break;
          }
          case 42: {
            StackTrace = input.ReadString();
            break;
          }
          case 50: {
            details_.AddEntriesFrom(input, _repeated_details_codec);
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
            ErrorCode = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            FieldPath = input.ReadString();
            break;
          }
          case 34: {
            Trigger = input.ReadString();
            break;
          }
          case 42: {
            StackTrace = input.ReadString();
            break;
          }
          case 50: {
            details_.AddEntriesFrom(ref input, _repeated_details_codec);
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
