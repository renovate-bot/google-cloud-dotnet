// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/chat/v1/chat_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Apps.Chat.V1 {

  /// <summary>Holder for reflection information generated from google/chat/v1/chat_service.proto</summary>
  public static partial class ChatServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/chat/v1/chat_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFnb29nbGUvY2hhdC92MS9jaGF0X3NlcnZpY2UucHJvdG8SDmdvb2dsZS5j",
            "aGF0LnYxGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUv",
            "YXBpL2NsaWVudC5wcm90bxofZ29vZ2xlL2NoYXQvdjEvYXR0YWNobWVudC5w",
            "cm90bxofZ29vZ2xlL2NoYXQvdjEvbWVtYmVyc2hpcC5wcm90bxocZ29vZ2xl",
            "L2NoYXQvdjEvbWVzc2FnZS5wcm90bxodZ29vZ2xlL2NoYXQvdjEvcmVhY3Rp",
            "b24ucHJvdG8aGmdvb2dsZS9jaGF0L3YxL3NwYWNlLnByb3RvGiBnb29nbGUv",
            "Y2hhdC92MS9zcGFjZV9ldmVudC5wcm90bxolZ29vZ2xlL2NoYXQvdjEvc3Bh",
            "Y2VfcmVhZF9zdGF0ZS5wcm90bxogZ29vZ2xlL2NoYXQvdjEvc3BhY2Vfc2V0",
            "dXAucHJvdG8aJmdvb2dsZS9jaGF0L3YxL3RocmVhZF9yZWFkX3N0YXRlLnBy",
            "b3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8ymikKC0NoYXRTZXJ2",
            "aWNlEpsBCg1DcmVhdGVNZXNzYWdlEiQuZ29vZ2xlLmNoYXQudjEuQ3JlYXRl",
            "TWVzc2FnZVJlcXVlc3QaFy5nb29nbGUuY2hhdC52MS5NZXNzYWdlIkvaQRlw",
            "YXJlbnQsbWVzc2FnZSxtZXNzYWdlX2lkgtPkkwIpIh4vdjEve3BhcmVudD1z",
            "cGFjZXMvKn0vbWVzc2FnZXM6B21lc3NhZ2USigEKDExpc3RNZXNzYWdlcxIj",
            "Lmdvb2dsZS5jaGF0LnYxLkxpc3RNZXNzYWdlc1JlcXVlc3QaJC5nb29nbGUu",
            "Y2hhdC52MS5MaXN0TWVzc2FnZXNSZXNwb25zZSIv2kEGcGFyZW50gtPkkwIg",
            "Eh4vdjEve3BhcmVudD1zcGFjZXMvKn0vbWVzc2FnZXMSkgEKD0xpc3RNZW1i",
            "ZXJzaGlwcxImLmdvb2dsZS5jaGF0LnYxLkxpc3RNZW1iZXJzaGlwc1JlcXVl",
            "c3QaJy5nb29nbGUuY2hhdC52MS5MaXN0TWVtYmVyc2hpcHNSZXNwb25zZSIu",
            "2kEGcGFyZW50gtPkkwIfEh0vdjEve3BhcmVudD1zcGFjZXMvKn0vbWVtYmVy",
            "cxJ/Cg1HZXRNZW1iZXJzaGlwEiQuZ29vZ2xlLmNoYXQudjEuR2V0TWVtYmVy",
            "c2hpcFJlcXVlc3QaGi5nb29nbGUuY2hhdC52MS5NZW1iZXJzaGlwIizaQQRu",
            "YW1lgtPkkwIfEh0vdjEve25hbWU9c3BhY2VzLyovbWVtYmVycy8qfRJ3CgpH",
            "ZXRNZXNzYWdlEiEuZ29vZ2xlLmNoYXQudjEuR2V0TWVzc2FnZVJlcXVlc3Qa",
            "Fy5nb29nbGUuY2hhdC52MS5NZXNzYWdlIi3aQQRuYW1lgtPkkwIgEh4vdjEv",
            "e25hbWU9c3BhY2VzLyovbWVzc2FnZXMvKn0S0QEKDVVwZGF0ZU1lc3NhZ2US",
            "JC5nb29nbGUuY2hhdC52MS5VcGRhdGVNZXNzYWdlUmVxdWVzdBoXLmdvb2ds",
            "ZS5jaGF0LnYxLk1lc3NhZ2UigAHaQRNtZXNzYWdlLHVwZGF0ZV9tYXNrgtPk",
            "kwJkGiYvdjEve21lc3NhZ2UubmFtZT1zcGFjZXMvKi9tZXNzYWdlcy8qfToH",
            "bWVzc2FnZVoxMiYvdjEve21lc3NhZ2UubmFtZT1zcGFjZXMvKi9tZXNzYWdl",
            "cy8qfToHbWVzc2FnZRJ8Cg1EZWxldGVNZXNzYWdlEiQuZ29vZ2xlLmNoYXQu",
            "djEuRGVsZXRlTWVzc2FnZVJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1w",
            "dHkiLdpBBG5hbWWC0+STAiAqHi92MS97bmFtZT1zcGFjZXMvKi9tZXNzYWdl",
            "cy8qfRKOAQoNR2V0QXR0YWNobWVudBIkLmdvb2dsZS5jaGF0LnYxLkdldEF0",
            "dGFjaG1lbnRSZXF1ZXN0GhouZ29vZ2xlLmNoYXQudjEuQXR0YWNobWVudCI7",
            "2kEEbmFtZYLT5JMCLhIsL3YxL3tuYW1lPXNwYWNlcy8qL21lc3NhZ2VzLyov",
            "YXR0YWNobWVudHMvKn0SmgEKEFVwbG9hZEF0dGFjaG1lbnQSJy5nb29nbGUu",
            "Y2hhdC52MS5VcGxvYWRBdHRhY2htZW50UmVxdWVzdBooLmdvb2dsZS5jaGF0",
            "LnYxLlVwbG9hZEF0dGFjaG1lbnRSZXNwb25zZSIzgtPkkwItIigvdjEve3Bh",
            "cmVudD1zcGFjZXMvKn0vYXR0YWNobWVudHM6dXBsb2FkOgEqEmoKCkxpc3RT",
            "cGFjZXMSIS5nb29nbGUuY2hhdC52MS5MaXN0U3BhY2VzUmVxdWVzdBoiLmdv",
            "b2dsZS5jaGF0LnYxLkxpc3RTcGFjZXNSZXNwb25zZSIV2kEAgtPkkwIMEgov",
            "djEvc3BhY2VzEmYKCEdldFNwYWNlEh8uZ29vZ2xlLmNoYXQudjEuR2V0U3Bh",
            "Y2VSZXF1ZXN0GhUuZ29vZ2xlLmNoYXQudjEuU3BhY2UiItpBBG5hbWWC0+ST",
            "AhUSEy92MS97bmFtZT1zcGFjZXMvKn0SawoLQ3JlYXRlU3BhY2USIi5nb29n",
            "bGUuY2hhdC52MS5DcmVhdGVTcGFjZVJlcXVlc3QaFS5nb29nbGUuY2hhdC52",
            "MS5TcGFjZSIh2kEFc3BhY2WC0+STAhMiCi92MS9zcGFjZXM6BXNwYWNlEmMK",
            "ClNldFVwU3BhY2USIS5nb29nbGUuY2hhdC52MS5TZXRVcFNwYWNlUmVxdWVz",
            "dBoVLmdvb2dsZS5jaGF0LnYxLlNwYWNlIhuC0+STAhUiEC92MS9zcGFjZXM6",
            "c2V0dXA6ASoShgEKC1VwZGF0ZVNwYWNlEiIuZ29vZ2xlLmNoYXQudjEuVXBk",
            "YXRlU3BhY2VSZXF1ZXN0GhUuZ29vZ2xlLmNoYXQudjEuU3BhY2UiPNpBEXNw",
            "YWNlLHVwZGF0ZV9tYXNrgtPkkwIiMhkvdjEve3NwYWNlLm5hbWU9c3BhY2Vz",
            "Lyp9OgVzcGFjZRJtCgtEZWxldGVTcGFjZRIiLmdvb2dsZS5jaGF0LnYxLkRl",
            "bGV0ZVNwYWNlUmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSIi2kEE",
            "bmFtZYLT5JMCFSoTL3YxL3tuYW1lPXNwYWNlcy8qfRKdAQoTQ29tcGxldGVJ",
            "bXBvcnRTcGFjZRIqLmdvb2dsZS5jaGF0LnYxLkNvbXBsZXRlSW1wb3J0U3Bh",
            "Y2VSZXF1ZXN0GisuZ29vZ2xlLmNoYXQudjEuQ29tcGxldGVJbXBvcnRTcGFj",
            "ZVJlc3BvbnNlIi2C0+STAiciIi92MS97bmFtZT1zcGFjZXMvKn06Y29tcGxl",
            "dGVJbXBvcnQ6ASoSegoRRmluZERpcmVjdE1lc3NhZ2USKC5nb29nbGUuY2hh",
            "dC52MS5GaW5kRGlyZWN0TWVzc2FnZVJlcXVlc3QaFS5nb29nbGUuY2hhdC52",
            "MS5TcGFjZSIkgtPkkwIeEhwvdjEvc3BhY2VzOmZpbmREaXJlY3RNZXNzYWdl",
            "Ep4BChBDcmVhdGVNZW1iZXJzaGlwEicuZ29vZ2xlLmNoYXQudjEuQ3JlYXRl",
            "TWVtYmVyc2hpcFJlcXVlc3QaGi5nb29nbGUuY2hhdC52MS5NZW1iZXJzaGlw",
            "IkXaQRFwYXJlbnQsbWVtYmVyc2hpcILT5JMCKyIdL3YxL3twYXJlbnQ9c3Bh",
            "Y2VzLyp9L21lbWJlcnM6Cm1lbWJlcnNoaXASrgEKEFVwZGF0ZU1lbWJlcnNo",
            "aXASJy5nb29nbGUuY2hhdC52MS5VcGRhdGVNZW1iZXJzaGlwUmVxdWVzdBoa",
            "Lmdvb2dsZS5jaGF0LnYxLk1lbWJlcnNoaXAiVdpBFm1lbWJlcnNoaXAsdXBk",
            "YXRlX21hc2uC0+STAjYyKC92MS97bWVtYmVyc2hpcC5uYW1lPXNwYWNlcy8q",
            "L21lbWJlcnMvKn06Cm1lbWJlcnNoaXAShQEKEERlbGV0ZU1lbWJlcnNoaXAS",
            "Jy5nb29nbGUuY2hhdC52MS5EZWxldGVNZW1iZXJzaGlwUmVxdWVzdBoaLmdv",
            "b2dsZS5jaGF0LnYxLk1lbWJlcnNoaXAiLNpBBG5hbWWC0+STAh8qHS92MS97",
            "bmFtZT1zcGFjZXMvKi9tZW1iZXJzLyp9EqEBCg5DcmVhdGVSZWFjdGlvbhIl",
            "Lmdvb2dsZS5jaGF0LnYxLkNyZWF0ZVJlYWN0aW9uUmVxdWVzdBoYLmdvb2ds",
            "ZS5jaGF0LnYxLlJlYWN0aW9uIk7aQQ9wYXJlbnQscmVhY3Rpb26C0+STAjYi",
            "Ki92MS97cGFyZW50PXNwYWNlcy8qL21lc3NhZ2VzLyp9L3JlYWN0aW9uczoI",
            "cmVhY3Rpb24SmQEKDUxpc3RSZWFjdGlvbnMSJC5nb29nbGUuY2hhdC52MS5M",
            "aXN0UmVhY3Rpb25zUmVxdWVzdBolLmdvb2dsZS5jaGF0LnYxLkxpc3RSZWFj",
            "dGlvbnNSZXNwb25zZSI72kEGcGFyZW50gtPkkwIsEiovdjEve3BhcmVudD1z",
            "cGFjZXMvKi9tZXNzYWdlcy8qfS9yZWFjdGlvbnMSigEKDkRlbGV0ZVJlYWN0",
            "aW9uEiUuZ29vZ2xlLmNoYXQudjEuRGVsZXRlUmVhY3Rpb25SZXF1ZXN0GhYu",
            "Z29vZ2xlLnByb3RvYnVmLkVtcHR5IjnaQQRuYW1lgtPkkwIsKiovdjEve25h",
            "bWU9c3BhY2VzLyovbWVzc2FnZXMvKi9yZWFjdGlvbnMvKn0SmAEKEUdldFNw",
            "YWNlUmVhZFN0YXRlEiguZ29vZ2xlLmNoYXQudjEuR2V0U3BhY2VSZWFkU3Rh",
            "dGVSZXF1ZXN0Gh4uZ29vZ2xlLmNoYXQudjEuU3BhY2VSZWFkU3RhdGUiOdpB",
            "BG5hbWWC0+STAiwSKi92MS97bmFtZT11c2Vycy8qL3NwYWNlcy8qL3NwYWNl",
            "UmVhZFN0YXRlfRLZAQoUVXBkYXRlU3BhY2VSZWFkU3RhdGUSKy5nb29nbGUu",
            "Y2hhdC52MS5VcGRhdGVTcGFjZVJlYWRTdGF0ZVJlcXVlc3QaHi5nb29nbGUu",
            "Y2hhdC52MS5TcGFjZVJlYWRTdGF0ZSJ02kEcc3BhY2VfcmVhZF9zdGF0ZSx1",
            "cGRhdGVfbWFza4LT5JMCTzI7L3YxL3tzcGFjZV9yZWFkX3N0YXRlLm5hbWU9",
            "dXNlcnMvKi9zcGFjZXMvKi9zcGFjZVJlYWRTdGF0ZX06EHNwYWNlX3JlYWRf",
            "c3RhdGUSpgEKEkdldFRocmVhZFJlYWRTdGF0ZRIpLmdvb2dsZS5jaGF0LnYx",
            "LkdldFRocmVhZFJlYWRTdGF0ZVJlcXVlc3QaHy5nb29nbGUuY2hhdC52MS5U",
            "aHJlYWRSZWFkU3RhdGUiRNpBBG5hbWWC0+STAjcSNS92MS97bmFtZT11c2Vy",
            "cy8qL3NwYWNlcy8qL3RocmVhZHMvKi90aHJlYWRSZWFkU3RhdGV9EoMBCg1H",
            "ZXRTcGFjZUV2ZW50EiQuZ29vZ2xlLmNoYXQudjEuR2V0U3BhY2VFdmVudFJl",
            "cXVlc3QaGi5nb29nbGUuY2hhdC52MS5TcGFjZUV2ZW50IjDaQQRuYW1lgtPk",
            "kwIjEiEvdjEve25hbWU9c3BhY2VzLyovc3BhY2VFdmVudHMvKn0SnQEKD0xp",
            "c3RTcGFjZUV2ZW50cxImLmdvb2dsZS5jaGF0LnYxLkxpc3RTcGFjZUV2ZW50",
            "c1JlcXVlc3QaJy5nb29nbGUuY2hhdC52MS5MaXN0U3BhY2VFdmVudHNSZXNw",
            "b25zZSI52kENcGFyZW50LGZpbHRlcoLT5JMCIxIhL3YxL3twYXJlbnQ9c3Bh",
            "Y2VzLyp9L3NwYWNlRXZlbnRzGqkJykETY2hhdC5nb29nbGVhcGlzLmNvbdJB",
            "jwlodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2NoYXQuYWRtaW4u",
            "ZGVsZXRlLGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvY2hhdC5h",
            "ZG1pbi5tZW1iZXJzaGlwcyxodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9h",
            "dXRoL2NoYXQuYWRtaW4ubWVtYmVyc2hpcHMucmVhZG9ubHksaHR0cHM6Ly93",
            "d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9jaGF0LmFkbWluLnNwYWNlcyxodHRw",
            "czovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2NoYXQuYWRtaW4uc3BhY2Vz",
            "LnJlYWRvbmx5LGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvY2hh",
            "dC5ib3QsaHR0cHM6Ly93d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9jaGF0LmRl",
            "bGV0ZSxodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2NoYXQuaW1w",
            "b3J0LGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvY2hhdC5tZW1i",
            "ZXJzaGlwcyxodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2NoYXQu",
            "bWVtYmVyc2hpcHMuYXBwLGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1",
            "dGgvY2hhdC5tZW1iZXJzaGlwcy5yZWFkb25seSxodHRwczovL3d3dy5nb29n",
            "bGVhcGlzLmNvbS9hdXRoL2NoYXQubWVzc2FnZXMsaHR0cHM6Ly93d3cuZ29v",
            "Z2xlYXBpcy5jb20vYXV0aC9jaGF0Lm1lc3NhZ2VzLmNyZWF0ZSxodHRwczov",
            "L3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2NoYXQubWVzc2FnZXMucmVhY3Rp",
            "b25zLGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvY2hhdC5tZXNz",
            "YWdlcy5yZWFjdGlvbnMuY3JlYXRlLGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMu",
            "Y29tL2F1dGgvY2hhdC5tZXNzYWdlcy5yZWFjdGlvbnMucmVhZG9ubHksaHR0",
            "cHM6Ly93d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9jaGF0Lm1lc3NhZ2VzLnJl",
            "YWRvbmx5LGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvY2hhdC5z",
            "cGFjZXMsaHR0cHM6Ly93d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9jaGF0LnNw",
            "YWNlcy5jcmVhdGUsaHR0cHM6Ly93d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9j",
            "aGF0LnNwYWNlcy5yZWFkb25seSxodHRwczovL3d3dy5nb29nbGVhcGlzLmNv",
            "bS9hdXRoL2NoYXQudXNlcnMucmVhZHN0YXRlLGh0dHBzOi8vd3d3Lmdvb2ds",
            "ZWFwaXMuY29tL2F1dGgvY2hhdC51c2Vycy5yZWFkc3RhdGUucmVhZG9ubHlC",
            "qQEKEmNvbS5nb29nbGUuY2hhdC52MUIQQ2hhdFNlcnZpY2VQcm90b1ABWixj",
            "bG91ZC5nb29nbGUuY29tL2dvL2NoYXQvYXBpdjEvY2hhdHBiO2NoYXRwYqIC",
            "C0RZTkFQSVByb3RvqgITR29vZ2xlLkFwcHMuQ2hhdC5WMcoCE0dvb2dsZVxB",
            "cHBzXENoYXRcVjHqAhZHb29nbGU6OkFwcHM6OkNoYXQ6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Apps.Chat.V1.AttachmentReflection.Descriptor, global::Google.Apps.Chat.V1.MembershipReflection.Descriptor, global::Google.Apps.Chat.V1.MessageReflection.Descriptor, global::Google.Apps.Chat.V1.ReactionReflection.Descriptor, global::Google.Apps.Chat.V1.SpaceReflection.Descriptor, global::Google.Apps.Chat.V1.SpaceEventReflection.Descriptor, global::Google.Apps.Chat.V1.SpaceReadStateReflection.Descriptor, global::Google.Apps.Chat.V1.SpaceSetupReflection.Descriptor, global::Google.Apps.Chat.V1.ThreadReadStateReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
