// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/logging/type/http_request.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Logging.Type {

  /// <summary>Holder for reflection information generated from google/logging/type/http_request.proto</summary>
  public static partial class HttpRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for google/logging/type/http_request.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HttpRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvbG9nZ2luZy90eXBlL2h0dHBfcmVxdWVzdC5wcm90bxITZ29v",
            "Z2xlLmxvZ2dpbmcudHlwZRoeZ29vZ2xlL3Byb3RvYnVmL2R1cmF0aW9uLnBy",
            "b3RvIu8CCgtIdHRwUmVxdWVzdBIWCg5yZXF1ZXN0X21ldGhvZBgBIAEoCRIT",
            "CgtyZXF1ZXN0X3VybBgCIAEoCRIUCgxyZXF1ZXN0X3NpemUYAyABKAMSDgoG",
            "c3RhdHVzGAQgASgFEhUKDXJlc3BvbnNlX3NpemUYBSABKAMSEgoKdXNlcl9h",
            "Z2VudBgGIAEoCRIRCglyZW1vdGVfaXAYByABKAkSEQoJc2VydmVyX2lwGA0g",
            "ASgJEg8KB3JlZmVyZXIYCCABKAkSKgoHbGF0ZW5jeRgOIAEoCzIZLmdvb2ds",
            "ZS5wcm90b2J1Zi5EdXJhdGlvbhIUCgxjYWNoZV9sb29rdXAYCyABKAgSEQoJ",
            "Y2FjaGVfaGl0GAkgASgIEioKImNhY2hlX3ZhbGlkYXRlZF93aXRoX29yaWdp",
            "bl9zZXJ2ZXIYCiABKAgSGAoQY2FjaGVfZmlsbF9ieXRlcxgMIAEoAxIQCghw",
            "cm90b2NvbBgPIAEoCUK+AQoXY29tLmdvb2dsZS5sb2dnaW5nLnR5cGVCEEh0",
            "dHBSZXF1ZXN0UHJvdG9QAVo4Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9sb2dnaW5nL3R5cGU7bHR5cGWqAhlHb29nbGUuQ2xvdWQu",
            "TG9nZ2luZy5UeXBlygIZR29vZ2xlXENsb3VkXExvZ2dpbmdcVHlwZeoCHEdv",
            "b2dsZTo6Q2xvdWQ6OkxvZ2dpbmc6OlR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Logging.Type.HttpRequest), global::Google.Cloud.Logging.Type.HttpRequest.Parser, new[]{ "RequestMethod", "RequestUrl", "RequestSize", "Status", "ResponseSize", "UserAgent", "RemoteIp", "ServerIp", "Referer", "Latency", "CacheLookup", "CacheHit", "CacheValidatedWithOriginServer", "CacheFillBytes", "Protocol" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A common proto for logging HTTP requests. Only contains semantics
  /// defined by the HTTP specification. Product-specific logging
  /// information MUST be defined in a separate message.
  /// </summary>
  public sealed partial class HttpRequest : pb::IMessage<HttpRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HttpRequest> _parser = new pb::MessageParser<HttpRequest>(() => new HttpRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HttpRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Logging.Type.HttpRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HttpRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HttpRequest(HttpRequest other) : this() {
      requestMethod_ = other.requestMethod_;
      requestUrl_ = other.requestUrl_;
      requestSize_ = other.requestSize_;
      status_ = other.status_;
      responseSize_ = other.responseSize_;
      userAgent_ = other.userAgent_;
      remoteIp_ = other.remoteIp_;
      serverIp_ = other.serverIp_;
      referer_ = other.referer_;
      latency_ = other.latency_ != null ? other.latency_.Clone() : null;
      cacheLookup_ = other.cacheLookup_;
      cacheHit_ = other.cacheHit_;
      cacheValidatedWithOriginServer_ = other.cacheValidatedWithOriginServer_;
      cacheFillBytes_ = other.cacheFillBytes_;
      protocol_ = other.protocol_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HttpRequest Clone() {
      return new HttpRequest(this);
    }

    /// <summary>Field number for the "request_method" field.</summary>
    public const int RequestMethodFieldNumber = 1;
    private string requestMethod_ = "";
    /// <summary>
    /// The request method. Examples: `"GET"`, `"HEAD"`, `"PUT"`, `"POST"`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RequestMethod {
      get { return requestMethod_; }
      set {
        requestMethod_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "request_url" field.</summary>
    public const int RequestUrlFieldNumber = 2;
    private string requestUrl_ = "";
    /// <summary>
    /// The scheme (http, https), the host name, the path and the query
    /// portion of the URL that was requested.
    /// Example: `"http://example.com/some/info?color=red"`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RequestUrl {
      get { return requestUrl_; }
      set {
        requestUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "request_size" field.</summary>
    public const int RequestSizeFieldNumber = 3;
    private long requestSize_;
    /// <summary>
    /// The size of the HTTP request message in bytes, including the request
    /// headers and the request body.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long RequestSize {
      get { return requestSize_; }
      set {
        requestSize_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private int status_;
    /// <summary>
    /// The response code indicating the status of response.
    /// Examples: 200, 404.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "response_size" field.</summary>
    public const int ResponseSizeFieldNumber = 5;
    private long responseSize_;
    /// <summary>
    /// The size of the HTTP response message sent back to the client, in bytes,
    /// including the response headers and the response body.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ResponseSize {
      get { return responseSize_; }
      set {
        responseSize_ = value;
      }
    }

    /// <summary>Field number for the "user_agent" field.</summary>
    public const int UserAgentFieldNumber = 6;
    private string userAgent_ = "";
    /// <summary>
    /// The user agent sent by the client. Example:
    /// `"Mozilla/4.0 (compatible; MSIE 6.0; Windows 98; Q312461; .NET
    /// CLR 1.0.3705)"`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserAgent {
      get { return userAgent_; }
      set {
        userAgent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "remote_ip" field.</summary>
    public const int RemoteIpFieldNumber = 7;
    private string remoteIp_ = "";
    /// <summary>
    /// The IP address (IPv4 or IPv6) of the client that issued the HTTP
    /// request. This field can include port information. Examples:
    /// `"192.168.1.1"`, `"10.0.0.1:80"`, `"FE80::0202:B3FF:FE1E:8329"`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RemoteIp {
      get { return remoteIp_; }
      set {
        remoteIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "server_ip" field.</summary>
    public const int ServerIpFieldNumber = 13;
    private string serverIp_ = "";
    /// <summary>
    /// The IP address (IPv4 or IPv6) of the origin server that the request was
    /// sent to. This field can include port information. Examples:
    /// `"192.168.1.1"`, `"10.0.0.1:80"`, `"FE80::0202:B3FF:FE1E:8329"`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ServerIp {
      get { return serverIp_; }
      set {
        serverIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "referer" field.</summary>
    public const int RefererFieldNumber = 8;
    private string referer_ = "";
    /// <summary>
    /// The referer URL of the request, as defined in
    /// [HTTP/1.1 Header Field
    /// Definitions](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Referer {
      get { return referer_; }
      set {
        referer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "latency" field.</summary>
    public const int LatencyFieldNumber = 14;
    private global::Google.Protobuf.WellKnownTypes.Duration latency_;
    /// <summary>
    /// The request processing latency on the server, from the time the request was
    /// received until the response was sent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration Latency {
      get { return latency_; }
      set {
        latency_ = value;
      }
    }

    /// <summary>Field number for the "cache_lookup" field.</summary>
    public const int CacheLookupFieldNumber = 11;
    private bool cacheLookup_;
    /// <summary>
    /// Whether or not a cache lookup was attempted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CacheLookup {
      get { return cacheLookup_; }
      set {
        cacheLookup_ = value;
      }
    }

    /// <summary>Field number for the "cache_hit" field.</summary>
    public const int CacheHitFieldNumber = 9;
    private bool cacheHit_;
    /// <summary>
    /// Whether or not an entity was served from cache
    /// (with or without validation).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CacheHit {
      get { return cacheHit_; }
      set {
        cacheHit_ = value;
      }
    }

    /// <summary>Field number for the "cache_validated_with_origin_server" field.</summary>
    public const int CacheValidatedWithOriginServerFieldNumber = 10;
    private bool cacheValidatedWithOriginServer_;
    /// <summary>
    /// Whether or not the response was validated with the origin server before
    /// being served from cache. This field is only meaningful if `cache_hit` is
    /// True.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CacheValidatedWithOriginServer {
      get { return cacheValidatedWithOriginServer_; }
      set {
        cacheValidatedWithOriginServer_ = value;
      }
    }

    /// <summary>Field number for the "cache_fill_bytes" field.</summary>
    public const int CacheFillBytesFieldNumber = 12;
    private long cacheFillBytes_;
    /// <summary>
    /// The number of HTTP response bytes inserted into cache. Set only when a
    /// cache fill was attempted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CacheFillBytes {
      get { return cacheFillBytes_; }
      set {
        cacheFillBytes_ = value;
      }
    }

    /// <summary>Field number for the "protocol" field.</summary>
    public const int ProtocolFieldNumber = 15;
    private string protocol_ = "";
    /// <summary>
    /// Protocol used for the request. Examples: "HTTP/1.1", "HTTP/2", "websocket"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Protocol {
      get { return protocol_; }
      set {
        protocol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HttpRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HttpRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequestMethod != other.RequestMethod) return false;
      if (RequestUrl != other.RequestUrl) return false;
      if (RequestSize != other.RequestSize) return false;
      if (Status != other.Status) return false;
      if (ResponseSize != other.ResponseSize) return false;
      if (UserAgent != other.UserAgent) return false;
      if (RemoteIp != other.RemoteIp) return false;
      if (ServerIp != other.ServerIp) return false;
      if (Referer != other.Referer) return false;
      if (!object.Equals(Latency, other.Latency)) return false;
      if (CacheLookup != other.CacheLookup) return false;
      if (CacheHit != other.CacheHit) return false;
      if (CacheValidatedWithOriginServer != other.CacheValidatedWithOriginServer) return false;
      if (CacheFillBytes != other.CacheFillBytes) return false;
      if (Protocol != other.Protocol) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RequestMethod.Length != 0) hash ^= RequestMethod.GetHashCode();
      if (RequestUrl.Length != 0) hash ^= RequestUrl.GetHashCode();
      if (RequestSize != 0L) hash ^= RequestSize.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (ResponseSize != 0L) hash ^= ResponseSize.GetHashCode();
      if (UserAgent.Length != 0) hash ^= UserAgent.GetHashCode();
      if (RemoteIp.Length != 0) hash ^= RemoteIp.GetHashCode();
      if (ServerIp.Length != 0) hash ^= ServerIp.GetHashCode();
      if (Referer.Length != 0) hash ^= Referer.GetHashCode();
      if (latency_ != null) hash ^= Latency.GetHashCode();
      if (CacheLookup != false) hash ^= CacheLookup.GetHashCode();
      if (CacheHit != false) hash ^= CacheHit.GetHashCode();
      if (CacheValidatedWithOriginServer != false) hash ^= CacheValidatedWithOriginServer.GetHashCode();
      if (CacheFillBytes != 0L) hash ^= CacheFillBytes.GetHashCode();
      if (Protocol.Length != 0) hash ^= Protocol.GetHashCode();
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
      if (RequestMethod.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RequestMethod);
      }
      if (RequestUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RequestUrl);
      }
      if (RequestSize != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(RequestSize);
      }
      if (Status != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Status);
      }
      if (ResponseSize != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(ResponseSize);
      }
      if (UserAgent.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(UserAgent);
      }
      if (RemoteIp.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(RemoteIp);
      }
      if (Referer.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Referer);
      }
      if (CacheHit != false) {
        output.WriteRawTag(72);
        output.WriteBool(CacheHit);
      }
      if (CacheValidatedWithOriginServer != false) {
        output.WriteRawTag(80);
        output.WriteBool(CacheValidatedWithOriginServer);
      }
      if (CacheLookup != false) {
        output.WriteRawTag(88);
        output.WriteBool(CacheLookup);
      }
      if (CacheFillBytes != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(CacheFillBytes);
      }
      if (ServerIp.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(ServerIp);
      }
      if (latency_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Latency);
      }
      if (Protocol.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(Protocol);
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
      if (RequestMethod.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RequestMethod);
      }
      if (RequestUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RequestUrl);
      }
      if (RequestSize != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(RequestSize);
      }
      if (Status != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Status);
      }
      if (ResponseSize != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(ResponseSize);
      }
      if (UserAgent.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(UserAgent);
      }
      if (RemoteIp.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(RemoteIp);
      }
      if (Referer.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Referer);
      }
      if (CacheHit != false) {
        output.WriteRawTag(72);
        output.WriteBool(CacheHit);
      }
      if (CacheValidatedWithOriginServer != false) {
        output.WriteRawTag(80);
        output.WriteBool(CacheValidatedWithOriginServer);
      }
      if (CacheLookup != false) {
        output.WriteRawTag(88);
        output.WriteBool(CacheLookup);
      }
      if (CacheFillBytes != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(CacheFillBytes);
      }
      if (ServerIp.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(ServerIp);
      }
      if (latency_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Latency);
      }
      if (Protocol.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(Protocol);
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
      if (RequestMethod.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestMethod);
      }
      if (RequestUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestUrl);
      }
      if (RequestSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RequestSize);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Status);
      }
      if (ResponseSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ResponseSize);
      }
      if (UserAgent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserAgent);
      }
      if (RemoteIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemoteIp);
      }
      if (ServerIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerIp);
      }
      if (Referer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Referer);
      }
      if (latency_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Latency);
      }
      if (CacheLookup != false) {
        size += 1 + 1;
      }
      if (CacheHit != false) {
        size += 1 + 1;
      }
      if (CacheValidatedWithOriginServer != false) {
        size += 1 + 1;
      }
      if (CacheFillBytes != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CacheFillBytes);
      }
      if (Protocol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Protocol);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HttpRequest other) {
      if (other == null) {
        return;
      }
      if (other.RequestMethod.Length != 0) {
        RequestMethod = other.RequestMethod;
      }
      if (other.RequestUrl.Length != 0) {
        RequestUrl = other.RequestUrl;
      }
      if (other.RequestSize != 0L) {
        RequestSize = other.RequestSize;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.ResponseSize != 0L) {
        ResponseSize = other.ResponseSize;
      }
      if (other.UserAgent.Length != 0) {
        UserAgent = other.UserAgent;
      }
      if (other.RemoteIp.Length != 0) {
        RemoteIp = other.RemoteIp;
      }
      if (other.ServerIp.Length != 0) {
        ServerIp = other.ServerIp;
      }
      if (other.Referer.Length != 0) {
        Referer = other.Referer;
      }
      if (other.latency_ != null) {
        if (latency_ == null) {
          Latency = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Latency.MergeFrom(other.Latency);
      }
      if (other.CacheLookup != false) {
        CacheLookup = other.CacheLookup;
      }
      if (other.CacheHit != false) {
        CacheHit = other.CacheHit;
      }
      if (other.CacheValidatedWithOriginServer != false) {
        CacheValidatedWithOriginServer = other.CacheValidatedWithOriginServer;
      }
      if (other.CacheFillBytes != 0L) {
        CacheFillBytes = other.CacheFillBytes;
      }
      if (other.Protocol.Length != 0) {
        Protocol = other.Protocol;
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
            RequestMethod = input.ReadString();
            break;
          }
          case 18: {
            RequestUrl = input.ReadString();
            break;
          }
          case 24: {
            RequestSize = input.ReadInt64();
            break;
          }
          case 32: {
            Status = input.ReadInt32();
            break;
          }
          case 40: {
            ResponseSize = input.ReadInt64();
            break;
          }
          case 50: {
            UserAgent = input.ReadString();
            break;
          }
          case 58: {
            RemoteIp = input.ReadString();
            break;
          }
          case 66: {
            Referer = input.ReadString();
            break;
          }
          case 72: {
            CacheHit = input.ReadBool();
            break;
          }
          case 80: {
            CacheValidatedWithOriginServer = input.ReadBool();
            break;
          }
          case 88: {
            CacheLookup = input.ReadBool();
            break;
          }
          case 96: {
            CacheFillBytes = input.ReadInt64();
            break;
          }
          case 106: {
            ServerIp = input.ReadString();
            break;
          }
          case 114: {
            if (latency_ == null) {
              Latency = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Latency);
            break;
          }
          case 122: {
            Protocol = input.ReadString();
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
            RequestMethod = input.ReadString();
            break;
          }
          case 18: {
            RequestUrl = input.ReadString();
            break;
          }
          case 24: {
            RequestSize = input.ReadInt64();
            break;
          }
          case 32: {
            Status = input.ReadInt32();
            break;
          }
          case 40: {
            ResponseSize = input.ReadInt64();
            break;
          }
          case 50: {
            UserAgent = input.ReadString();
            break;
          }
          case 58: {
            RemoteIp = input.ReadString();
            break;
          }
          case 66: {
            Referer = input.ReadString();
            break;
          }
          case 72: {
            CacheHit = input.ReadBool();
            break;
          }
          case 80: {
            CacheValidatedWithOriginServer = input.ReadBool();
            break;
          }
          case 88: {
            CacheLookup = input.ReadBool();
            break;
          }
          case 96: {
            CacheFillBytes = input.ReadInt64();
            break;
          }
          case 106: {
            ServerIp = input.ReadString();
            break;
          }
          case 114: {
            if (latency_ == null) {
              Latency = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Latency);
            break;
          }
          case 122: {
            Protocol = input.ReadString();
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
