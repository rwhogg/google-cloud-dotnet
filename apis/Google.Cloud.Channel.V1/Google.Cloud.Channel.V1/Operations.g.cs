// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/channel/v1/operations.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Channel.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/channel/v1/operations.proto</summary>
  public static partial class OperationsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/channel/v1/operations.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperationsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvY2hhbm5lbC92MS9vcGVyYXRpb25zLnByb3RvEhdn",
            "b29nbGUuY2xvdWQuY2hhbm5lbC52MSK2AwoRT3BlcmF0aW9uTWV0YWRhdGES",
            "UAoOb3BlcmF0aW9uX3R5cGUYASABKA4yOC5nb29nbGUuY2xvdWQuY2hhbm5l",
            "bC52MS5PcGVyYXRpb25NZXRhZGF0YS5PcGVyYXRpb25UeXBlIs4CCg1PcGVy",
            "YXRpb25UeXBlEh4KGk9QRVJBVElPTl9UWVBFX1VOU1BFQ0lGSUVEEAASFgoS",
            "Q1JFQVRFX0VOVElUTEVNRU5UEAESGwoXQ0hBTkdFX1JFTkVXQUxfU0VUVElO",
            "R1MQAxIWChJTVEFSVF9QQUlEX1NFUlZJQ0UQBRIYChRBQ1RJVkFURV9FTlRJ",
            "VExFTUVOVBAHEhcKE1NVU1BFTkRfRU5USVRMRU1FTlQQCBIWChJDQU5DRUxf",
            "RU5USVRMRU1FTlQQCRIZChVUUkFOU0ZFUl9FTlRJVExFTUVOVFMQChIjCh9U",
            "UkFOU0ZFUl9FTlRJVExFTUVOVFNfVE9fR09PR0xFEAsSEAoMQ0hBTkdFX09G",
            "RkVSEA4SFQoRQ0hBTkdFX1BBUkFNRVRFUlMQDxIcChhQUk9WSVNJT05fQ0xP",
            "VURfSURFTlRJVFkQEEJwChtjb20uZ29vZ2xlLmNsb3VkLmNoYW5uZWwudjFC",
            "D09wZXJhdGlvbnNQcm90b1ABWj5nb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Nsb3VkL2NoYW5uZWwvdjE7Y2hhbm5lbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Channel.V1.OperationMetadata), global::Google.Cloud.Channel.V1.OperationMetadata.Parser, new[]{ "OperationType" }, null, new[]{ typeof(global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Provides contextual information about a [google.longrunning.Operation][google.longrunning.Operation].
  /// </summary>
  public sealed partial class OperationMetadata : pb::IMessage<OperationMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OperationMetadata> _parser = new pb::MessageParser<OperationMetadata>(() => new OperationMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OperationMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Channel.V1.OperationsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata(OperationMetadata other) : this() {
      operationType_ = other.operationType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata Clone() {
      return new OperationMetadata(this);
    }

    /// <summary>Field number for the "operation_type" field.</summary>
    public const int OperationTypeFieldNumber = 1;
    private global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType operationType_ = global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType.Unspecified;
    /// <summary>
    /// The RPC that initiated this Long Running Operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType OperationType {
      get { return operationType_; }
      set {
        operationType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OperationMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OperationMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OperationType != other.OperationType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OperationType != global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType.Unspecified) hash ^= OperationType.GetHashCode();
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
      if (OperationType != global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OperationType);
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
      if (OperationType != global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OperationType);
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
      if (OperationType != global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OperationType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OperationMetadata other) {
      if (other == null) {
        return;
      }
      if (other.OperationType != global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType.Unspecified) {
        OperationType = other.OperationType;
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
          case 8: {
            OperationType = (global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType) input.ReadEnum();
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
          case 8: {
            OperationType = (global::Google.Cloud.Channel.V1.OperationMetadata.Types.OperationType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the OperationMetadata message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// RPCs that return a Long Running Operation.
      /// </summary>
      public enum OperationType {
        /// <summary>
        /// Not used.
        /// </summary>
        [pbr::OriginalName("OPERATION_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Long Running Operation was triggered by CreateEntitlement.
        /// </summary>
        [pbr::OriginalName("CREATE_ENTITLEMENT")] CreateEntitlement = 1,
        /// <summary>
        /// Long Running Operation was triggered by ChangeRenewalSettings.
        /// </summary>
        [pbr::OriginalName("CHANGE_RENEWAL_SETTINGS")] ChangeRenewalSettings = 3,
        /// <summary>
        /// Long Running Operation was triggered by StartPaidService.
        /// </summary>
        [pbr::OriginalName("START_PAID_SERVICE")] StartPaidService = 5,
        /// <summary>
        /// Long Running Operation was triggered by ActivateEntitlement.
        /// </summary>
        [pbr::OriginalName("ACTIVATE_ENTITLEMENT")] ActivateEntitlement = 7,
        /// <summary>
        /// Long Running Operation was triggered by SuspendEntitlement.
        /// </summary>
        [pbr::OriginalName("SUSPEND_ENTITLEMENT")] SuspendEntitlement = 8,
        /// <summary>
        /// Long Running Operation was triggered by CancelEntitlement.
        /// </summary>
        [pbr::OriginalName("CANCEL_ENTITLEMENT")] CancelEntitlement = 9,
        /// <summary>
        /// Long Running Operation was triggered by TransferEntitlements.
        /// </summary>
        [pbr::OriginalName("TRANSFER_ENTITLEMENTS")] TransferEntitlements = 10,
        /// <summary>
        /// Long Running Operation was triggered by TransferEntitlementsToGoogle.
        /// </summary>
        [pbr::OriginalName("TRANSFER_ENTITLEMENTS_TO_GOOGLE")] TransferEntitlementsToGoogle = 11,
        /// <summary>
        /// Long Running Operation was triggered by ChangeOffer.
        /// </summary>
        [pbr::OriginalName("CHANGE_OFFER")] ChangeOffer = 14,
        /// <summary>
        /// Long Running Operation was triggered by ChangeParameters.
        /// </summary>
        [pbr::OriginalName("CHANGE_PARAMETERS")] ChangeParameters = 15,
        /// <summary>
        /// Long Running Operation was triggered by ProvisionCloudIdentity.
        /// </summary>
        [pbr::OriginalName("PROVISION_CLOUD_IDENTITY")] ProvisionCloudIdentity = 16,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
