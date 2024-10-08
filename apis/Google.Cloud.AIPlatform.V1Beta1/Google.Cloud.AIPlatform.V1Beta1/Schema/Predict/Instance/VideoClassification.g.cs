// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1beta1/schema/predict/instance/video_classification.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Instance {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1beta1/schema/predict/instance/video_classification.proto</summary>
  public static partial class VideoClassificationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1beta1/schema/predict/instance/video_classification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoClassificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClJnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MWJldGExL3NjaGVtYS9wcmVk",
            "aWN0L2luc3RhbmNlL3ZpZGVvX2NsYXNzaWZpY2F0aW9uLnByb3RvEjdnb29n",
            "bGUuY2xvdWQuYWlwbGF0Zm9ybS52MWJldGExLnNjaGVtYS5wcmVkaWN0Lmlu",
            "c3RhbmNlIoEBCiVWaWRlb0NsYXNzaWZpY2F0aW9uUHJlZGljdGlvbkluc3Rh",
            "bmNlEg8KB2NvbnRlbnQYASABKAkSEQoJbWltZV90eXBlGAIgASgJEhoKEnRp",
            "bWVfc2VnbWVudF9zdGFydBgDIAEoCRIYChB0aW1lX3NlZ21lbnRfZW5kGAQg",
            "ASgJQvgCCjtjb20uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjFiZXRhMS5z",
            "Y2hlbWEucHJlZGljdC5pbnN0YW5jZUIqVmlkZW9DbGFzc2lmaWNhdGlvblBy",
            "ZWRpY3Rpb25JbnN0YW5jZVByb3RvUAFaV2Nsb3VkLmdvb2dsZS5jb20vZ28v",
            "YWlwbGF0Zm9ybS9hcGl2MWJldGExL3NjaGVtYS9wcmVkaWN0L2luc3RhbmNl",
            "L2luc3RhbmNlcGI7aW5zdGFuY2VwYqoCN0dvb2dsZS5DbG91ZC5BSVBsYXRm",
            "b3JtLlYxQmV0YTEuU2NoZW1hLlByZWRpY3QuSW5zdGFuY2XKAjdHb29nbGVc",
            "Q2xvdWRcQUlQbGF0Zm9ybVxWMWJldGExXFNjaGVtYVxQcmVkaWN0XEluc3Rh",
            "bmNl6gI9R29vZ2xlOjpDbG91ZDo6QUlQbGF0Zm9ybTo6VjFiZXRhMTo6U2No",
            "ZW1hOjpQcmVkaWN0OjpJbnN0YW5jZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Instance.VideoClassificationPredictionInstance), global::Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Instance.VideoClassificationPredictionInstance.Parser, new[]{ "Content", "MimeType", "TimeSegmentStart", "TimeSegmentEnd" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction input format for Video Classification.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class VideoClassificationPredictionInstance : pb::IMessage<VideoClassificationPredictionInstance>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VideoClassificationPredictionInstance> _parser = new pb::MessageParser<VideoClassificationPredictionInstance>(() => new VideoClassificationPredictionInstance());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VideoClassificationPredictionInstance> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1Beta1.Schema.Predict.Instance.VideoClassificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoClassificationPredictionInstance() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoClassificationPredictionInstance(VideoClassificationPredictionInstance other) : this() {
      content_ = other.content_;
      mimeType_ = other.mimeType_;
      timeSegmentStart_ = other.timeSegmentStart_;
      timeSegmentEnd_ = other.timeSegmentEnd_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoClassificationPredictionInstance Clone() {
      return new VideoClassificationPredictionInstance(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private string content_ = "";
    /// <summary>
    /// The Google Cloud Storage location of the video on which to perform the
    /// prediction.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mime_type" field.</summary>
    public const int MimeTypeFieldNumber = 2;
    private string mimeType_ = "";
    /// <summary>
    /// The MIME type of the content of the video. Only the following are
    /// supported: video/mp4 video/avi video/quicktime
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MimeType {
      get { return mimeType_; }
      set {
        mimeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time_segment_start" field.</summary>
    public const int TimeSegmentStartFieldNumber = 3;
    private string timeSegmentStart_ = "";
    /// <summary>
    /// The beginning, inclusive, of the video's time segment on which to perform
    /// the prediction. Expressed as a number of seconds as measured from the
    /// start of the video, with "s" appended at the end. Fractions are allowed,
    /// up to a microsecond precision.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TimeSegmentStart {
      get { return timeSegmentStart_; }
      set {
        timeSegmentStart_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time_segment_end" field.</summary>
    public const int TimeSegmentEndFieldNumber = 4;
    private string timeSegmentEnd_ = "";
    /// <summary>
    /// The end, exclusive, of the video's time segment on which to perform
    /// the prediction. Expressed as a number of seconds as measured from the
    /// start of the video, with "s" appended at the end. Fractions are allowed,
    /// up to a microsecond precision, and "inf" or "Infinity" is allowed, which
    /// means the end of the video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TimeSegmentEnd {
      get { return timeSegmentEnd_; }
      set {
        timeSegmentEnd_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VideoClassificationPredictionInstance);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VideoClassificationPredictionInstance other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (MimeType != other.MimeType) return false;
      if (TimeSegmentStart != other.TimeSegmentStart) return false;
      if (TimeSegmentEnd != other.TimeSegmentEnd) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (MimeType.Length != 0) hash ^= MimeType.GetHashCode();
      if (TimeSegmentStart.Length != 0) hash ^= TimeSegmentStart.GetHashCode();
      if (TimeSegmentEnd.Length != 0) hash ^= TimeSegmentEnd.GetHashCode();
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
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (MimeType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MimeType);
      }
      if (TimeSegmentStart.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TimeSegmentStart);
      }
      if (TimeSegmentEnd.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TimeSegmentEnd);
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
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (MimeType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MimeType);
      }
      if (TimeSegmentStart.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TimeSegmentStart);
      }
      if (TimeSegmentEnd.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TimeSegmentEnd);
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
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (MimeType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MimeType);
      }
      if (TimeSegmentStart.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeSegmentStart);
      }
      if (TimeSegmentEnd.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeSegmentEnd);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VideoClassificationPredictionInstance other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.MimeType.Length != 0) {
        MimeType = other.MimeType;
      }
      if (other.TimeSegmentStart.Length != 0) {
        TimeSegmentStart = other.TimeSegmentStart;
      }
      if (other.TimeSegmentEnd.Length != 0) {
        TimeSegmentEnd = other.TimeSegmentEnd;
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
            Content = input.ReadString();
            break;
          }
          case 18: {
            MimeType = input.ReadString();
            break;
          }
          case 26: {
            TimeSegmentStart = input.ReadString();
            break;
          }
          case 34: {
            TimeSegmentEnd = input.ReadString();
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
            Content = input.ReadString();
            break;
          }
          case 18: {
            MimeType = input.ReadString();
            break;
          }
          case 26: {
            TimeSegmentStart = input.ReadString();
            break;
          }
          case 34: {
            TimeSegmentEnd = input.ReadString();
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
