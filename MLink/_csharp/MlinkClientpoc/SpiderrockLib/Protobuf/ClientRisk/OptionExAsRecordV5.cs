// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/ClientRisk/OptionExAsRecordV5.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/ClientRisk/OptionExAsRecordV5.proto</summary>
  public static partial class OptionExAsRecordV5Reflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/ClientRisk/OptionExAsRecordV5.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OptionExAsRecordV5Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixQcm90b2J1Zi9DbGllbnRSaXNrL09wdGlvbkV4QXNSZWNvcmRWNS5wcm90",
            "bxITc3BpZGVycm9jay5wcm90b2J1ZhoXc3BpZGVycm9ja19jb21tb24ucHJv",
            "dG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8i8gIKEk9wdGlv",
            "bkV4QXNSZWNvcmRWNRIzCgVfbWV0YRgBIAEoCzIkLnNwaWRlcnJvY2sucHJv",
            "dG9idWYuTWVzc2FnZU1ldGFkYXRhEjoKBHBrZXkYAiABKAsyLC5zcGlkZXJy",
            "b2NrLnByb3RvYnVmLk9wdGlvbkV4QXNSZWNvcmRWNS5QS2V5EhYKDmV4X2Fz",
            "X3RyYW5zX2lkGGQgASgJEhcKD2V4X2FzX2NvbnRyYWN0cxhnIAEoBRItCgl0",
            "aW1lc3RhbXAYaiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wGooB",
            "CgRQS2V5EiwKBG9rZXkYCiABKAsyHi5zcGlkZXJyb2NrLnByb3RvYnVmLk9w",
            "dGlvbktleRINCgVhY2NudBgLIAEoCRIwCgp0cmFkZV9kYXRlGAwgASgLMhwu",
            "c3BpZGVycm9jay5wcm90b2J1Zi5EYXRlS2V5EhMKC2NsaWVudF9maXJtGA0g",
            "ASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.OptionExAsRecordV5), global::Spiderrock.Protobuf.OptionExAsRecordV5.Parser, new[]{ "Meta", "Pkey", "ExAsTransId", "ExAsContracts", "Timestamp" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.OptionExAsRecordV5.Types.PKey), global::Spiderrock.Protobuf.OptionExAsRecordV5.Types.PKey.Parser, new[]{ "Okey", "Accnt", "TradeDate", "ClientFirm" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  ///Option exercise/assigment records (either from SR clearing loaders or uploaded directly by client)
  /// </summary>
  public sealed partial class OptionExAsRecordV5 : pb::IMessage<OptionExAsRecordV5>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OptionExAsRecordV5> _parser = new pb::MessageParser<OptionExAsRecordV5>(() => new OptionExAsRecordV5());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OptionExAsRecordV5> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.OptionExAsRecordV5Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptionExAsRecordV5() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptionExAsRecordV5(OptionExAsRecordV5 other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      exAsTransId_ = other.exAsTransId_;
      exAsContracts_ = other.exAsContracts_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptionExAsRecordV5 Clone() {
      return new OptionExAsRecordV5(this);
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
    private global::Spiderrock.Protobuf.OptionExAsRecordV5.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.OptionExAsRecordV5.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "ex_as_trans_id" field.</summary>
    public const int ExAsTransIdFieldNumber = 100;
    private string exAsTransId_ = "";
    /// <summary>
    /// exercise/assigment transaction Id [optiona] (used to reference away sytem records)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ExAsTransId {
      get { return exAsTransId_; }
      set {
        exAsTransId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ex_as_contracts" field.</summary>
    public const int ExAsContractsFieldNumber = 103;
    private int exAsContracts_;
    /// <summary>
    /// note: override the normal automatic ex/as rules for up to this number of contracts. The balance (if any) will be presumed to ex/as according to default rules
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ExAsContracts {
      get { return exAsContracts_; }
      set {
        exAsContracts_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 106;
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
      return Equals(other as OptionExAsRecordV5);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OptionExAsRecordV5 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (ExAsTransId != other.ExAsTransId) return false;
      if (ExAsContracts != other.ExAsContracts) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (ExAsTransId.Length != 0) hash ^= ExAsTransId.GetHashCode();
      if (ExAsContracts != 0) hash ^= ExAsContracts.GetHashCode();
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
      if (ExAsTransId.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(ExAsTransId);
      }
      if (ExAsContracts != 0) {
        output.WriteRawTag(184, 6);
        output.WriteInt32(ExAsContracts);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(210, 6);
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
      if (ExAsTransId.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(ExAsTransId);
      }
      if (ExAsContracts != 0) {
        output.WriteRawTag(184, 6);
        output.WriteInt32(ExAsContracts);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(210, 6);
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
      if (ExAsTransId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ExAsTransId);
      }
      if (ExAsContracts != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(ExAsContracts);
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
    public void MergeFrom(OptionExAsRecordV5 other) {
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
          Pkey = new global::Spiderrock.Protobuf.OptionExAsRecordV5.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.ExAsTransId.Length != 0) {
        ExAsTransId = other.ExAsTransId;
      }
      if (other.ExAsContracts != 0) {
        ExAsContracts = other.ExAsContracts;
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
              Pkey = new global::Spiderrock.Protobuf.OptionExAsRecordV5.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            ExAsTransId = input.ReadString();
            break;
          }
          case 824: {
            ExAsContracts = input.ReadInt32();
            break;
          }
          case 850: {
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
              Pkey = new global::Spiderrock.Protobuf.OptionExAsRecordV5.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            ExAsTransId = input.ReadString();
            break;
          }
          case 824: {
            ExAsContracts = input.ReadInt32();
            break;
          }
          case 850: {
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
    /// <summary>Container for nested types declared in the OptionExAsRecordV5 message type.</summary>
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
          get { return global::Spiderrock.Protobuf.OptionExAsRecordV5.Descriptor.NestedTypes[0]; }
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
          okey_ = other.okey_ != null ? other.okey_.Clone() : null;
          accnt_ = other.accnt_;
          tradeDate_ = other.tradeDate_ != null ? other.tradeDate_.Clone() : null;
          clientFirm_ = other.clientFirm_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey Clone() {
          return new PKey(this);
        }

        /// <summary>Field number for the "okey" field.</summary>
        public const int OkeyFieldNumber = 10;
        private global::Spiderrock.Protobuf.OptionKey okey_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.OptionKey Okey {
          get { return okey_; }
          set {
            okey_ = value;
          }
        }

        /// <summary>Field number for the "accnt" field.</summary>
        public const int AccntFieldNumber = 11;
        private string accnt_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Accnt {
          get { return accnt_; }
          set {
            accnt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "trade_date" field.</summary>
        public const int TradeDateFieldNumber = 12;
        private global::Spiderrock.Protobuf.DateKey tradeDate_;
        /// <summary>
        /// trading date immediately prior to ex-date of the action
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.DateKey TradeDate {
          get { return tradeDate_; }
          set {
            tradeDate_ = value;
          }
        }

        /// <summary>Field number for the "client_firm" field.</summary>
        public const int ClientFirmFieldNumber = 13;
        private string clientFirm_ = "";
        /// <summary>
        /// SR assigned client firm
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string ClientFirm {
          get { return clientFirm_; }
          set {
            clientFirm_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
          if (!object.Equals(Okey, other.Okey)) return false;
          if (Accnt != other.Accnt) return false;
          if (!object.Equals(TradeDate, other.TradeDate)) return false;
          if (ClientFirm != other.ClientFirm) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (okey_ != null) hash ^= Okey.GetHashCode();
          if (Accnt.Length != 0) hash ^= Accnt.GetHashCode();
          if (tradeDate_ != null) hash ^= TradeDate.GetHashCode();
          if (ClientFirm.Length != 0) hash ^= ClientFirm.GetHashCode();
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
          if (okey_ != null) {
            output.WriteRawTag(82);
            output.WriteMessage(Okey);
          }
          if (Accnt.Length != 0) {
            output.WriteRawTag(90);
            output.WriteString(Accnt);
          }
          if (tradeDate_ != null) {
            output.WriteRawTag(98);
            output.WriteMessage(TradeDate);
          }
          if (ClientFirm.Length != 0) {
            output.WriteRawTag(106);
            output.WriteString(ClientFirm);
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
          if (okey_ != null) {
            output.WriteRawTag(82);
            output.WriteMessage(Okey);
          }
          if (Accnt.Length != 0) {
            output.WriteRawTag(90);
            output.WriteString(Accnt);
          }
          if (tradeDate_ != null) {
            output.WriteRawTag(98);
            output.WriteMessage(TradeDate);
          }
          if (ClientFirm.Length != 0) {
            output.WriteRawTag(106);
            output.WriteString(ClientFirm);
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
          if (okey_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Okey);
          }
          if (Accnt.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Accnt);
          }
          if (tradeDate_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(TradeDate);
          }
          if (ClientFirm.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientFirm);
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
          if (other.okey_ != null) {
            if (okey_ == null) {
              Okey = new global::Spiderrock.Protobuf.OptionKey();
            }
            Okey.MergeFrom(other.Okey);
          }
          if (other.Accnt.Length != 0) {
            Accnt = other.Accnt;
          }
          if (other.tradeDate_ != null) {
            if (tradeDate_ == null) {
              TradeDate = new global::Spiderrock.Protobuf.DateKey();
            }
            TradeDate.MergeFrom(other.TradeDate);
          }
          if (other.ClientFirm.Length != 0) {
            ClientFirm = other.ClientFirm;
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
              case 82: {
                if (okey_ == null) {
                  Okey = new global::Spiderrock.Protobuf.OptionKey();
                }
                input.ReadMessage(Okey);
                break;
              }
              case 90: {
                Accnt = input.ReadString();
                break;
              }
              case 98: {
                if (tradeDate_ == null) {
                  TradeDate = new global::Spiderrock.Protobuf.DateKey();
                }
                input.ReadMessage(TradeDate);
                break;
              }
              case 106: {
                ClientFirm = input.ReadString();
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
              case 82: {
                if (okey_ == null) {
                  Okey = new global::Spiderrock.Protobuf.OptionKey();
                }
                input.ReadMessage(Okey);
                break;
              }
              case 90: {
                Accnt = input.ReadString();
                break;
              }
              case 98: {
                if (tradeDate_ == null) {
                  TradeDate = new global::Spiderrock.Protobuf.DateKey();
                }
                input.ReadMessage(TradeDate);
                break;
              }
              case 106: {
                ClientFirm = input.ReadString();
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