// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/video/stitcher/v1/events.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Video.Stitcher.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/video/stitcher/v1/events.proto</summary>
  public static partial class EventsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/video/stitcher/v1/events.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citnb29nbGUvY2xvdWQvdmlkZW8vc3RpdGNoZXIvdjEvZXZlbnRzLnByb3Rv",
            "Eh5nb29nbGUuY2xvdWQudmlkZW8uc3RpdGNoZXIudjEaHmdvb2dsZS9wcm90",
            "b2J1Zi9kdXJhdGlvbi5wcm90byKOBAoFRXZlbnQSPQoEdHlwZRgBIAEoDjIv",
            "Lmdvb2dsZS5jbG91ZC52aWRlby5zdGl0Y2hlci52MS5FdmVudC5FdmVudFR5",
            "cGUSCwoDdXJpGAIgASgJEgoKAmlkGAMgASgJEikKBm9mZnNldBgEIAEoCzIZ",
            "Lmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlvbiKBAwoJRXZlbnRUeXBlEhoKFkVW",
            "RU5UX1RZUEVfVU5TUEVDSUZJRUQQABIRCg1DUkVBVElWRV9WSUVXEAESCQoF",
            "U1RBUlQQAhIPCgtCUkVBS19TVEFSVBADEg0KCUJSRUFLX0VORBAEEg4KCklN",
            "UFJFU1NJT04QBRISCg5GSVJTVF9RVUFSVElMRRAGEgwKCE1JRFBPSU5UEAcS",
            "EgoOVEhJUkRfUVVBUlRJTEUQCBIMCghDT01QTEVURRAJEgwKCFBST0dSRVNT",
            "EAoSCAoETVVURRALEgoKBlVOTVVURRAMEgkKBVBBVVNFEA0SCQoFQ0xJQ0sQ",
            "DhIRCg1DTElDS19USFJPVUdIEA8SCgoGUkVXSU5EEBASCgoGUkVTVU1FEBES",
            "CQoFRVJST1IQEhIKCgZFWFBBTkQQFRIMCghDT0xMQVBTRRAWEgkKBUNMT1NF",
            "EBgSEAoMQ0xPU0VfTElORUFSEBkSCAoEU0tJUBAaEhUKEUFDQ0VQVF9JTlZJ",
            "VEFUSU9OEBsidgoNUHJvZ3Jlc3NFdmVudBIuCgt0aW1lX29mZnNldBgBIAEo",
            "CzIZLmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlvbhI1CgZldmVudHMYAiADKAsy",
            "JS5nb29nbGUuY2xvdWQudmlkZW8uc3RpdGNoZXIudjEuRXZlbnRCewoiY29t",
            "Lmdvb2dsZS5jbG91ZC52aWRlby5zdGl0Y2hlci52MUILRXZlbnRzUHJvdG9Q",
            "AVpGZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91",
            "ZC92aWRlby9zdGl0Y2hlci92MTtzdGl0Y2hlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Video.Stitcher.V1.Event), global::Google.Cloud.Video.Stitcher.V1.Event.Parser, new[]{ "Type", "Uri", "Id", "Offset" }, null, new[]{ typeof(global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Video.Stitcher.V1.ProgressEvent), global::Google.Cloud.Video.Stitcher.V1.ProgressEvent.Parser, new[]{ "TimeOffset", "Events" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes an event and a trigger URI.
  /// </summary>
  public sealed partial class Event : pb::IMessage<Event>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Event> _parser = new pb::MessageParser<Event>(() => new Event());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Event> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Video.Stitcher.V1.EventsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Event() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Event(Event other) : this() {
      type_ = other.type_;
      uri_ = other.uri_;
      id_ = other.id_;
      offset_ = other.offset_ != null ? other.offset_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Event Clone() {
      return new Event(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType type_ = global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType.Unspecified;
    /// <summary>
    /// Describes the event that occurred.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 2;
    private string uri_ = "";
    /// <summary>
    /// The URI to trigger for this event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Uri {
      get { return uri_; }
      set {
        uri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private string id_ = "";
    /// <summary>
    /// The ID of the event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Duration offset_;
    /// <summary>
    /// The offset in seconds if the event type is `PROGRESS`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration Offset {
      get { return offset_; }
      set {
        offset_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Event);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Event other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Uri != other.Uri) return false;
      if (Id != other.Id) return false;
      if (!object.Equals(Offset, other.Offset)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType.Unspecified) hash ^= Type.GetHashCode();
      if (Uri.Length != 0) hash ^= Uri.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (offset_ != null) hash ^= Offset.GetHashCode();
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
      if (Type != global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Uri.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uri);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Id);
      }
      if (offset_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Offset);
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
      if (Type != global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Uri.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uri);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Id);
      }
      if (offset_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Offset);
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
      if (Type != global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Uri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (offset_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Offset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Event other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType.Unspecified) {
        Type = other.Type;
      }
      if (other.Uri.Length != 0) {
        Uri = other.Uri;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.offset_ != null) {
        if (offset_ == null) {
          Offset = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Offset.MergeFrom(other.Offset);
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
            Type = (global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType) input.ReadEnum();
            break;
          }
          case 18: {
            Uri = input.ReadString();
            break;
          }
          case 26: {
            Id = input.ReadString();
            break;
          }
          case 34: {
            if (offset_ == null) {
              Offset = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Offset);
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
            Type = (global::Google.Cloud.Video.Stitcher.V1.Event.Types.EventType) input.ReadEnum();
            break;
          }
          case 18: {
            Uri = input.ReadString();
            break;
          }
          case 26: {
            Id = input.ReadString();
            break;
          }
          case 34: {
            if (offset_ == null) {
              Offset = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Offset);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Event message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Describes the event that occurred.
      /// </summary>
      public enum EventType {
        /// <summary>
        /// The event type is unspecified.
        /// </summary>
        [pbr::OriginalName("EVENT_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// First frame of creative ad viewed.
        /// </summary>
        [pbr::OriginalName("CREATIVE_VIEW")] CreativeView = 1,
        /// <summary>
        /// Creative ad started.
        /// </summary>
        [pbr::OriginalName("START")] Start = 2,
        /// <summary>
        /// Start of an ad break.
        /// </summary>
        [pbr::OriginalName("BREAK_START")] BreakStart = 3,
        /// <summary>
        /// End of an ad break.
        /// </summary>
        [pbr::OriginalName("BREAK_END")] BreakEnd = 4,
        /// <summary>
        /// Impression.
        /// </summary>
        [pbr::OriginalName("IMPRESSION")] Impression = 5,
        /// <summary>
        /// First quartile progress.
        /// </summary>
        [pbr::OriginalName("FIRST_QUARTILE")] FirstQuartile = 6,
        /// <summary>
        /// Midpoint progress.
        /// </summary>
        [pbr::OriginalName("MIDPOINT")] Midpoint = 7,
        /// <summary>
        /// Third quartile progress.
        /// </summary>
        [pbr::OriginalName("THIRD_QUARTILE")] ThirdQuartile = 8,
        /// <summary>
        /// Ad progress completed.
        /// </summary>
        [pbr::OriginalName("COMPLETE")] Complete = 9,
        /// <summary>
        /// Specific progress event with an offset.
        /// </summary>
        [pbr::OriginalName("PROGRESS")] Progress = 10,
        /// <summary>
        /// Player muted.
        /// </summary>
        [pbr::OriginalName("MUTE")] Mute = 11,
        /// <summary>
        /// Player unmuted.
        /// </summary>
        [pbr::OriginalName("UNMUTE")] Unmute = 12,
        /// <summary>
        /// Player paused.
        /// </summary>
        [pbr::OriginalName("PAUSE")] Pause = 13,
        /// <summary>
        /// Click event.
        /// </summary>
        [pbr::OriginalName("CLICK")] Click = 14,
        /// <summary>
        /// Click-through event.
        /// </summary>
        [pbr::OriginalName("CLICK_THROUGH")] ClickThrough = 15,
        /// <summary>
        /// Player rewinding.
        /// </summary>
        [pbr::OriginalName("REWIND")] Rewind = 16,
        /// <summary>
        /// Player resumed.
        /// </summary>
        [pbr::OriginalName("RESUME")] Resume = 17,
        /// <summary>
        /// Error event.
        /// </summary>
        [pbr::OriginalName("ERROR")] Error = 18,
        /// <summary>
        /// Ad expanded to a larger size.
        /// </summary>
        [pbr::OriginalName("EXPAND")] Expand = 21,
        /// <summary>
        /// Ad collapsed to a smaller size.
        /// </summary>
        [pbr::OriginalName("COLLAPSE")] Collapse = 22,
        /// <summary>
        /// Non-linear ad closed.
        /// </summary>
        [pbr::OriginalName("CLOSE")] Close = 24,
        /// <summary>
        /// Linear ad closed.
        /// </summary>
        [pbr::OriginalName("CLOSE_LINEAR")] CloseLinear = 25,
        /// <summary>
        /// Ad skipped.
        /// </summary>
        [pbr::OriginalName("SKIP")] Skip = 26,
        /// <summary>
        /// Accept invitation event.
        /// </summary>
        [pbr::OriginalName("ACCEPT_INVITATION")] AcceptInvitation = 27,
      }

    }
    #endregion

  }

  /// <summary>
  /// Indicates a time in which a list of events should be triggered
  /// during media playback.
  /// </summary>
  public sealed partial class ProgressEvent : pb::IMessage<ProgressEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProgressEvent> _parser = new pb::MessageParser<ProgressEvent>(() => new ProgressEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProgressEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Video.Stitcher.V1.EventsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProgressEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProgressEvent(ProgressEvent other) : this() {
      timeOffset_ = other.timeOffset_ != null ? other.timeOffset_.Clone() : null;
      events_ = other.events_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProgressEvent Clone() {
      return new ProgressEvent(this);
    }

    /// <summary>Field number for the "time_offset" field.</summary>
    public const int TimeOffsetFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Duration timeOffset_;
    /// <summary>
    /// The time when the following tracking events occurs. The time is in
    /// seconds relative to the start of the VOD asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration TimeOffset {
      get { return timeOffset_; }
      set {
        timeOffset_ = value;
      }
    }

    /// <summary>Field number for the "events" field.</summary>
    public const int EventsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Cloud.Video.Stitcher.V1.Event> _repeated_events_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Cloud.Video.Stitcher.V1.Event.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Video.Stitcher.V1.Event> events_ = new pbc::RepeatedField<global::Google.Cloud.Video.Stitcher.V1.Event>();
    /// <summary>
    /// The list of progress tracking events for the ad break. These can be of
    /// the following IAB types: `BREAK_START`, `BREAK_END`, `IMPRESSION`,
    /// `CREATIVE_VIEW`, `START`, `FIRST_QUARTILE`, `MIDPOINT`, `THIRD_QUARTILE`,
    /// `COMPLETE`, `PROGRESS`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.Video.Stitcher.V1.Event> Events {
      get { return events_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProgressEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProgressEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TimeOffset, other.TimeOffset)) return false;
      if(!events_.Equals(other.events_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (timeOffset_ != null) hash ^= TimeOffset.GetHashCode();
      hash ^= events_.GetHashCode();
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
      if (timeOffset_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TimeOffset);
      }
      events_.WriteTo(output, _repeated_events_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (timeOffset_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TimeOffset);
      }
      events_.WriteTo(ref output, _repeated_events_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (timeOffset_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeOffset);
      }
      size += events_.CalculateSize(_repeated_events_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProgressEvent other) {
      if (other == null) {
        return;
      }
      if (other.timeOffset_ != null) {
        if (timeOffset_ == null) {
          TimeOffset = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        TimeOffset.MergeFrom(other.TimeOffset);
      }
      events_.Add(other.events_);
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
            if (timeOffset_ == null) {
              TimeOffset = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(TimeOffset);
            break;
          }
          case 18: {
            events_.AddEntriesFrom(input, _repeated_events_codec);
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
            if (timeOffset_ == null) {
              TimeOffset = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(TimeOffset);
            break;
          }
          case 18: {
            events_.AddEntriesFrom(ref input, _repeated_events_codec);
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
