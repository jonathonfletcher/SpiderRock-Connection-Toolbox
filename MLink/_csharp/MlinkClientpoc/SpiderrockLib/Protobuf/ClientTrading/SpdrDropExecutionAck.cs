// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/ClientTrading/SpdrDropExecutionAck.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/ClientTrading/SpdrDropExecutionAck.proto</summary>
  public static partial class SpdrDropExecutionAckReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/ClientTrading/SpdrDropExecutionAck.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpdrDropExecutionAckReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFQcm90b2J1Zi9DbGllbnRUcmFkaW5nL1NwZHJEcm9wRXhlY3V0aW9uQWNr",
            "LnByb3RvEhNzcGlkZXJyb2NrLnByb3RvYnVmGhdzcGlkZXJyb2NrX2NvbW1v",
            "bi5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKrBAoU",
            "U3BkckRyb3BFeGVjdXRpb25BY2sSMwoFX21ldGEYASABKAsyJC5zcGlkZXJy",
            "b2NrLnByb3RvYnVmLk1lc3NhZ2VNZXRhZGF0YRI8CgRwa2V5GAIgASgLMi4u",
            "c3BpZGVycm9jay5wcm90b2J1Zi5TcGRyRHJvcEV4ZWN1dGlvbkFjay5QS2V5",
            "EhQKDHJvdXRpbmdfY29kZRhkIAEoCRIvCgdzZWNfa2V5GGcgASgLMh4uc3Bp",
            "ZGVycm9jay5wcm90b2J1Zi5PcHRpb25LZXkSMgoIc2VjX3R5cGUYaiABKA4y",
            "IC5zcGlkZXJyb2NrLnByb3RvYnVmLlNwZHJLZXlUeXBlEhMKC2NsaWVudF9m",
            "aXJtGG0gASgJEhQKDGZpbGxfdmVyc2lvbhhwIAEoBRI9ChBkcm9wX2V4ZWNf",
            "c3RhdHVzGHMgASgOMiMuc3BpZGVycm9jay5wcm90b2J1Zi5Ecm9wRXhlY1N0",
            "YXR1cxIUCgxvdGhlcl9kZXRhaWwYdiABKAkSFAoMZXJyb3JfZGV0YWlsGHkg",
            "ASgJEhMKC2ZpbGxfbnVtYmVyGHwgASgDEi0KCWZpbGxfZHR0bRh/IAEoCzIa",
            "Lmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASLgoJdGltZXN0YW1wGIIBIAEo",
            "CzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAaGwoEUEtleRITCgtkcm9w",
            "X251bWJlchgKIAEoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.SpdrDropExecutionAck), global::Spiderrock.Protobuf.SpdrDropExecutionAck.Parser, new[]{ "Meta", "Pkey", "RoutingCode", "SecKey", "SecType", "ClientFirm", "FillVersion", "DropExecStatus", "OtherDetail", "ErrorDetail", "FillNumber", "FillDttm", "Timestamp" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.SpdrDropExecutionAck.Types.PKey), global::Spiderrock.Protobuf.SpdrDropExecutionAck.Types.PKey.Parser, new[]{ "DropNumber" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SpdrDropExecutionAck : pb::IMessage<SpdrDropExecutionAck>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpdrDropExecutionAck> _parser = new pb::MessageParser<SpdrDropExecutionAck>(() => new SpdrDropExecutionAck());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpdrDropExecutionAck> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.SpdrDropExecutionAckReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpdrDropExecutionAck() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpdrDropExecutionAck(SpdrDropExecutionAck other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      routingCode_ = other.routingCode_;
      secKey_ = other.secKey_ != null ? other.secKey_.Clone() : null;
      secType_ = other.secType_;
      clientFirm_ = other.clientFirm_;
      fillVersion_ = other.fillVersion_;
      dropExecStatus_ = other.dropExecStatus_;
      otherDetail_ = other.otherDetail_;
      errorDetail_ = other.errorDetail_;
      fillNumber_ = other.fillNumber_;
      fillDttm_ = other.fillDttm_ != null ? other.fillDttm_.Clone() : null;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpdrDropExecutionAck Clone() {
      return new SpdrDropExecutionAck(this);
    }

    /// <summary>Field number for the "_meta" field.</summary>
    public const int MetaFieldNumber = 1;
    private global::Spiderrock.Protobuf.MessageMetadata Meta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.MessageMetadata Meta {
      get { return Meta_; }
      set {
        Meta_ = value;
      }
    }

    /// <summary>Field number for the "pkey" field.</summary>
    public const int PkeyFieldNumber = 2;
    private global::Spiderrock.Protobuf.SpdrDropExecutionAck.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.SpdrDropExecutionAck.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "routing_code" field.</summary>
    public const int RoutingCodeFieldNumber = 100;
    private string routingCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RoutingCode {
      get { return routingCode_; }
      set {
        routingCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sec_key" field.</summary>
    public const int SecKeyFieldNumber = 103;
    private global::Spiderrock.Protobuf.OptionKey secKey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.OptionKey SecKey {
      get { return secKey_; }
      set {
        secKey_ = value;
      }
    }

    /// <summary>Field number for the "sec_type" field.</summary>
    public const int SecTypeFieldNumber = 106;
    private global::Spiderrock.Protobuf.SpdrKeyType secType_ = global::Spiderrock.Protobuf.SpdrKeyType.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.SpdrKeyType SecType {
      get { return secType_; }
      set {
        secType_ = value;
      }
    }

    /// <summary>Field number for the "client_firm" field.</summary>
    public const int ClientFirmFieldNumber = 109;
    private string clientFirm_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientFirm {
      get { return clientFirm_; }
      set {
        clientFirm_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fill_version" field.</summary>
    public const int FillVersionFieldNumber = 112;
    private int fillVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int FillVersion {
      get { return fillVersion_; }
      set {
        fillVersion_ = value;
      }
    }

    /// <summary>Field number for the "drop_exec_status" field.</summary>
    public const int DropExecStatusFieldNumber = 115;
    private global::Spiderrock.Protobuf.DropExecStatus dropExecStatus_ = global::Spiderrock.Protobuf.DropExecStatus.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.DropExecStatus DropExecStatus {
      get { return dropExecStatus_; }
      set {
        dropExecStatus_ = value;
      }
    }

    /// <summary>Field number for the "other_detail" field.</summary>
    public const int OtherDetailFieldNumber = 118;
    private string otherDetail_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OtherDetail {
      get { return otherDetail_; }
      set {
        otherDetail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "error_detail" field.</summary>
    public const int ErrorDetailFieldNumber = 121;
    private string errorDetail_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ErrorDetail {
      get { return errorDetail_; }
      set {
        errorDetail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fill_number" field.</summary>
    public const int FillNumberFieldNumber = 124;
    private long fillNumber_;
    /// <summary>
    /// SR Fill Number (if Accepted)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long FillNumber {
      get { return fillNumber_; }
      set {
        fillNumber_ = value;
      }
    }

    /// <summary>Field number for the "fill_dttm" field.</summary>
    public const int FillDttmFieldNumber = 127;
    private global::Google.Protobuf.WellKnownTypes.Timestamp fillDttm_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp FillDttm {
      get { return fillDttm_; }
      set {
        fillDttm_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 130;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpdrDropExecutionAck);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpdrDropExecutionAck other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (RoutingCode != other.RoutingCode) return false;
      if (!object.Equals(SecKey, other.SecKey)) return false;
      if (SecType != other.SecType) return false;
      if (ClientFirm != other.ClientFirm) return false;
      if (FillVersion != other.FillVersion) return false;
      if (DropExecStatus != other.DropExecStatus) return false;
      if (OtherDetail != other.OtherDetail) return false;
      if (ErrorDetail != other.ErrorDetail) return false;
      if (FillNumber != other.FillNumber) return false;
      if (!object.Equals(FillDttm, other.FillDttm)) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (RoutingCode.Length != 0) hash ^= RoutingCode.GetHashCode();
      if (secKey_ != null) hash ^= SecKey.GetHashCode();
      if (SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) hash ^= SecType.GetHashCode();
      if (ClientFirm.Length != 0) hash ^= ClientFirm.GetHashCode();
      if (FillVersion != 0) hash ^= FillVersion.GetHashCode();
      if (DropExecStatus != global::Spiderrock.Protobuf.DropExecStatus.Unspecified) hash ^= DropExecStatus.GetHashCode();
      if (OtherDetail.Length != 0) hash ^= OtherDetail.GetHashCode();
      if (ErrorDetail.Length != 0) hash ^= ErrorDetail.GetHashCode();
      if (FillNumber != 0L) hash ^= FillNumber.GetHashCode();
      if (fillDttm_ != null) hash ^= FillDttm.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
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
      if (Meta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Meta);
      }
      if (pkey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pkey);
      }
      if (RoutingCode.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(RoutingCode);
      }
      if (secKey_ != null) {
        output.WriteRawTag(186, 6);
        output.WriteMessage(SecKey);
      }
      if (SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
        output.WriteRawTag(208, 6);
        output.WriteEnum((int) SecType);
      }
      if (ClientFirm.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(ClientFirm);
      }
      if (FillVersion != 0) {
        output.WriteRawTag(128, 7);
        output.WriteInt32(FillVersion);
      }
      if (DropExecStatus != global::Spiderrock.Protobuf.DropExecStatus.Unspecified) {
        output.WriteRawTag(152, 7);
        output.WriteEnum((int) DropExecStatus);
      }
      if (OtherDetail.Length != 0) {
        output.WriteRawTag(178, 7);
        output.WriteString(OtherDetail);
      }
      if (ErrorDetail.Length != 0) {
        output.WriteRawTag(202, 7);
        output.WriteString(ErrorDetail);
      }
      if (FillNumber != 0L) {
        output.WriteRawTag(224, 7);
        output.WriteInt64(FillNumber);
      }
      if (fillDttm_ != null) {
        output.WriteRawTag(250, 7);
        output.WriteMessage(FillDttm);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(146, 8);
        output.WriteMessage(Timestamp);
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
      if (Meta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Meta);
      }
      if (pkey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pkey);
      }
      if (RoutingCode.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(RoutingCode);
      }
      if (secKey_ != null) {
        output.WriteRawTag(186, 6);
        output.WriteMessage(SecKey);
      }
      if (SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
        output.WriteRawTag(208, 6);
        output.WriteEnum((int) SecType);
      }
      if (ClientFirm.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(ClientFirm);
      }
      if (FillVersion != 0) {
        output.WriteRawTag(128, 7);
        output.WriteInt32(FillVersion);
      }
      if (DropExecStatus != global::Spiderrock.Protobuf.DropExecStatus.Unspecified) {
        output.WriteRawTag(152, 7);
        output.WriteEnum((int) DropExecStatus);
      }
      if (OtherDetail.Length != 0) {
        output.WriteRawTag(178, 7);
        output.WriteString(OtherDetail);
      }
      if (ErrorDetail.Length != 0) {
        output.WriteRawTag(202, 7);
        output.WriteString(ErrorDetail);
      }
      if (FillNumber != 0L) {
        output.WriteRawTag(224, 7);
        output.WriteInt64(FillNumber);
      }
      if (fillDttm_ != null) {
        output.WriteRawTag(250, 7);
        output.WriteMessage(FillDttm);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(146, 8);
        output.WriteMessage(Timestamp);
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
      if (Meta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Meta);
      }
      if (pkey_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pkey);
      }
      if (RoutingCode.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(RoutingCode);
      }
      if (secKey_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SecKey);
      }
      if (SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) SecType);
      }
      if (ClientFirm.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ClientFirm);
      }
      if (FillVersion != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(FillVersion);
      }
      if (DropExecStatus != global::Spiderrock.Protobuf.DropExecStatus.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) DropExecStatus);
      }
      if (OtherDetail.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(OtherDetail);
      }
      if (ErrorDetail.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ErrorDetail);
      }
      if (FillNumber != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(FillNumber);
      }
      if (fillDttm_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(FillDttm);
      }
      if (timestamp_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpdrDropExecutionAck other) {
      if (other == null) {
        return;
      }
      if (other.Meta_ != null) {
        if (Meta_ == null) {
          Meta = new global::Spiderrock.Protobuf.MessageMetadata();
        }
        Meta.MergeFrom(other.Meta);
      }
      if (other.pkey_ != null) {
        if (pkey_ == null) {
          Pkey = new global::Spiderrock.Protobuf.SpdrDropExecutionAck.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.RoutingCode.Length != 0) {
        RoutingCode = other.RoutingCode;
      }
      if (other.secKey_ != null) {
        if (secKey_ == null) {
          SecKey = new global::Spiderrock.Protobuf.OptionKey();
        }
        SecKey.MergeFrom(other.SecKey);
      }
      if (other.SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
        SecType = other.SecType;
      }
      if (other.ClientFirm.Length != 0) {
        ClientFirm = other.ClientFirm;
      }
      if (other.FillVersion != 0) {
        FillVersion = other.FillVersion;
      }
      if (other.DropExecStatus != global::Spiderrock.Protobuf.DropExecStatus.Unspecified) {
        DropExecStatus = other.DropExecStatus;
      }
      if (other.OtherDetail.Length != 0) {
        OtherDetail = other.OtherDetail;
      }
      if (other.ErrorDetail.Length != 0) {
        ErrorDetail = other.ErrorDetail;
      }
      if (other.FillNumber != 0L) {
        FillNumber = other.FillNumber;
      }
      if (other.fillDttm_ != null) {
        if (fillDttm_ == null) {
          FillDttm = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        FillDttm.MergeFrom(other.FillDttm);
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
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
            if (Meta_ == null) {
              Meta = new global::Spiderrock.Protobuf.MessageMetadata();
            }
            input.ReadMessage(Meta);
            break;
          }
          case 18: {
            if (pkey_ == null) {
              Pkey = new global::Spiderrock.Protobuf.SpdrDropExecutionAck.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            RoutingCode = input.ReadString();
            break;
          }
          case 826: {
            if (secKey_ == null) {
              SecKey = new global::Spiderrock.Protobuf.OptionKey();
            }
            input.ReadMessage(SecKey);
            break;
          }
          case 848: {
            SecType = (global::Spiderrock.Protobuf.SpdrKeyType) input.ReadEnum();
            break;
          }
          case 874: {
            ClientFirm = input.ReadString();
            break;
          }
          case 896: {
            FillVersion = input.ReadInt32();
            break;
          }
          case 920: {
            DropExecStatus = (global::Spiderrock.Protobuf.DropExecStatus) input.ReadEnum();
            break;
          }
          case 946: {
            OtherDetail = input.ReadString();
            break;
          }
          case 970: {
            ErrorDetail = input.ReadString();
            break;
          }
          case 992: {
            FillNumber = input.ReadInt64();
            break;
          }
          case 1018: {
            if (fillDttm_ == null) {
              FillDttm = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(FillDttm);
            break;
          }
          case 1042: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
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
            if (Meta_ == null) {
              Meta = new global::Spiderrock.Protobuf.MessageMetadata();
            }
            input.ReadMessage(Meta);
            break;
          }
          case 18: {
            if (pkey_ == null) {
              Pkey = new global::Spiderrock.Protobuf.SpdrDropExecutionAck.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            RoutingCode = input.ReadString();
            break;
          }
          case 826: {
            if (secKey_ == null) {
              SecKey = new global::Spiderrock.Protobuf.OptionKey();
            }
            input.ReadMessage(SecKey);
            break;
          }
          case 848: {
            SecType = (global::Spiderrock.Protobuf.SpdrKeyType) input.ReadEnum();
            break;
          }
          case 874: {
            ClientFirm = input.ReadString();
            break;
          }
          case 896: {
            FillVersion = input.ReadInt32();
            break;
          }
          case 920: {
            DropExecStatus = (global::Spiderrock.Protobuf.DropExecStatus) input.ReadEnum();
            break;
          }
          case 946: {
            OtherDetail = input.ReadString();
            break;
          }
          case 970: {
            ErrorDetail = input.ReadString();
            break;
          }
          case 992: {
            FillNumber = input.ReadInt64();
            break;
          }
          case 1018: {
            if (fillDttm_ == null) {
              FillDttm = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(FillDttm);
            break;
          }
          case 1042: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SpdrDropExecutionAck message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class PKey : pb::IMessage<PKey>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<PKey> _parser = new pb::MessageParser<PKey>(() => new PKey());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<PKey> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Spiderrock.Protobuf.SpdrDropExecutionAck.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey(PKey other) : this() {
          dropNumber_ = other.dropNumber_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey Clone() {
          return new PKey(this);
        }

        /// <summary>Field number for the "drop_number" field.</summary>
        public const int DropNumberFieldNumber = 10;
        private long dropNumber_;
        /// <summary>
        /// SR drop record number
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long DropNumber {
          get { return dropNumber_; }
          set {
            dropNumber_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as PKey);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(PKey other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (DropNumber != other.DropNumber) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (DropNumber != 0L) hash ^= DropNumber.GetHashCode();
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
          if (DropNumber != 0L) {
            output.WriteRawTag(80);
            output.WriteInt64(DropNumber);
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
          if (DropNumber != 0L) {
            output.WriteRawTag(80);
            output.WriteInt64(DropNumber);
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
          if (DropNumber != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(DropNumber);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(PKey other) {
          if (other == null) {
            return;
          }
          if (other.DropNumber != 0L) {
            DropNumber = other.DropNumber;
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
              case 80: {
                DropNumber = input.ReadInt64();
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
              case 80: {
                DropNumber = input.ReadInt64();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code