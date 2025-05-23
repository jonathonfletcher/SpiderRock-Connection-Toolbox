// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/ClientLive/ProductTradingStatusV2.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/ClientLive/ProductTradingStatusV2.proto</summary>
  public static partial class ProductTradingStatusV2Reflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/ClientLive/ProductTradingStatusV2.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductTradingStatusV2Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBQcm90b2J1Zi9DbGllbnRMaXZlL1Byb2R1Y3RUcmFkaW5nU3RhdHVzVjIu",
            "cHJvdG8SE3NwaWRlcnJvY2sucHJvdG9idWYaF3NwaWRlcnJvY2tfY29tbW9u",
            "LnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvItsDChZQ",
            "cm9kdWN0VHJhZGluZ1N0YXR1c1YyEjMKBV9tZXRhGAEgASgLMiQuc3BpZGVy",
            "cm9jay5wcm90b2J1Zi5NZXNzYWdlTWV0YWRhdGESPgoEcGtleRgCIAEoCzIw",
            "LnNwaWRlcnJvY2sucHJvdG9idWYuUHJvZHVjdFRyYWRpbmdTdGF0dXNWMi5Q",
            "S2V5EjAKCnRyYWRlX2RhdGUYZCABKAsyHC5zcGlkZXJyb2NrLnByb3RvYnVm",
            "LkRhdGVLZXkSOAoNbWFya2V0X3N0YXR1cxhnIAEoDjIhLnNwaWRlcnJvY2su",
            "cHJvdG9idWYuTWFya2V0U3RhdHVzEi0KCXRpbWVzdGFtcBhqIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAasAEKBFBLZXkSLwoHc2VjX2tleRgK",
            "IAEoCzIeLnNwaWRlcnJvY2sucHJvdG9idWYuT3B0aW9uS2V5EjIKCHNlY190",
            "eXBlGAsgASgOMiAuc3BpZGVycm9jay5wcm90b2J1Zi5TcGRyS2V5VHlwZRJD",
            "ChN0cmFkaW5nX3N0YXR1c190eXBlGAwgASgOMiYuc3BpZGVycm9jay5wcm90",
            "b2J1Zi5UcmFkaW5nU3RhdHVzVHlwZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.ProductTradingStatusV2), global::Spiderrock.Protobuf.ProductTradingStatusV2.Parser, new[]{ "Meta", "Pkey", "TradeDate", "MarketStatus", "Timestamp" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.ProductTradingStatusV2.Types.PKey), global::Spiderrock.Protobuf.ProductTradingStatusV2.Types.PKey.Parser, new[]{ "SecKey", "SecType", "TradingStatusType" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  ///This table contains live trading status records for entire product groups (futures and options) and asset groups and individual instruments
  /// </summary>
  public sealed partial class ProductTradingStatusV2 : pb::IMessage<ProductTradingStatusV2>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProductTradingStatusV2> _parser = new pb::MessageParser<ProductTradingStatusV2>(() => new ProductTradingStatusV2());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProductTradingStatusV2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.ProductTradingStatusV2Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductTradingStatusV2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductTradingStatusV2(ProductTradingStatusV2 other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      tradeDate_ = other.tradeDate_ != null ? other.tradeDate_.Clone() : null;
      marketStatus_ = other.marketStatus_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductTradingStatusV2 Clone() {
      return new ProductTradingStatusV2(this);
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
    private global::Spiderrock.Protobuf.ProductTradingStatusV2.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.ProductTradingStatusV2.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "trade_date" field.</summary>
    public const int TradeDateFieldNumber = 100;
    private global::Spiderrock.Protobuf.DateKey tradeDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.DateKey TradeDate {
      get { return tradeDate_; }
      set {
        tradeDate_ = value;
      }
    }

    /// <summary>Field number for the "market_status" field.</summary>
    public const int MarketStatusFieldNumber = 103;
    private global::Spiderrock.Protobuf.MarketStatus marketStatus_ = global::Spiderrock.Protobuf.MarketStatus.Unspecified;
    /// <summary>
    /// market status (open, halted, etc)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.MarketStatus MarketStatus {
      get { return marketStatus_; }
      set {
        marketStatus_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 106;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    /// <summary>
    /// time of last state update (CST)
    /// </summary>
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
      return Equals(other as ProductTradingStatusV2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProductTradingStatusV2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (!object.Equals(TradeDate, other.TradeDate)) return false;
      if (MarketStatus != other.MarketStatus) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (tradeDate_ != null) hash ^= TradeDate.GetHashCode();
      if (MarketStatus != global::Spiderrock.Protobuf.MarketStatus.Unspecified) hash ^= MarketStatus.GetHashCode();
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
      if (tradeDate_ != null) {
        output.WriteRawTag(162, 6);
        output.WriteMessage(TradeDate);
      }
      if (MarketStatus != global::Spiderrock.Protobuf.MarketStatus.Unspecified) {
        output.WriteRawTag(184, 6);
        output.WriteEnum((int) MarketStatus);
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
      if (tradeDate_ != null) {
        output.WriteRawTag(162, 6);
        output.WriteMessage(TradeDate);
      }
      if (MarketStatus != global::Spiderrock.Protobuf.MarketStatus.Unspecified) {
        output.WriteRawTag(184, 6);
        output.WriteEnum((int) MarketStatus);
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
      if (tradeDate_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TradeDate);
      }
      if (MarketStatus != global::Spiderrock.Protobuf.MarketStatus.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) MarketStatus);
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
    public void MergeFrom(ProductTradingStatusV2 other) {
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
          Pkey = new global::Spiderrock.Protobuf.ProductTradingStatusV2.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.tradeDate_ != null) {
        if (tradeDate_ == null) {
          TradeDate = new global::Spiderrock.Protobuf.DateKey();
        }
        TradeDate.MergeFrom(other.TradeDate);
      }
      if (other.MarketStatus != global::Spiderrock.Protobuf.MarketStatus.Unspecified) {
        MarketStatus = other.MarketStatus;
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
              Pkey = new global::Spiderrock.Protobuf.ProductTradingStatusV2.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            if (tradeDate_ == null) {
              TradeDate = new global::Spiderrock.Protobuf.DateKey();
            }
            input.ReadMessage(TradeDate);
            break;
          }
          case 824: {
            MarketStatus = (global::Spiderrock.Protobuf.MarketStatus) input.ReadEnum();
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
              Pkey = new global::Spiderrock.Protobuf.ProductTradingStatusV2.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            if (tradeDate_ == null) {
              TradeDate = new global::Spiderrock.Protobuf.DateKey();
            }
            input.ReadMessage(TradeDate);
            break;
          }
          case 824: {
            MarketStatus = (global::Spiderrock.Protobuf.MarketStatus) input.ReadEnum();
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
    /// <summary>Container for nested types declared in the ProductTradingStatusV2 message type.</summary>
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
          get { return global::Spiderrock.Protobuf.ProductTradingStatusV2.Descriptor.NestedTypes[0]; }
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
          secKey_ = other.secKey_ != null ? other.secKey_.Clone() : null;
          secType_ = other.secType_;
          tradingStatusType_ = other.tradingStatusType_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey Clone() {
          return new PKey(this);
        }

        /// <summary>Field number for the "sec_key" field.</summary>
        public const int SecKeyFieldNumber = 10;
        private global::Spiderrock.Protobuf.OptionKey secKey_;
        /// <summary>
        /// trading status product key. Interpretation depends on the status type
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.OptionKey SecKey {
          get { return secKey_; }
          set {
            secKey_ = value;
          }
        }

        /// <summary>Field number for the "sec_type" field.</summary>
        public const int SecTypeFieldNumber = 11;
        private global::Spiderrock.Protobuf.SpdrKeyType secType_ = global::Spiderrock.Protobuf.SpdrKeyType.Unspecified;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.SpdrKeyType SecType {
          get { return secType_; }
          set {
            secType_ = value;
          }
        }

        /// <summary>Field number for the "trading_status_type" field.</summary>
        public const int TradingStatusTypeFieldNumber = 12;
        private global::Spiderrock.Protobuf.TradingStatusType tradingStatusType_ = global::Spiderrock.Protobuf.TradingStatusType.Unspecified;
        /// <summary>
        /// Processing level for the product trading status: 1 = statusKey is the product group key, 2 = statusKey is the security group key, statusKey is for an individual instrument
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.TradingStatusType TradingStatusType {
          get { return tradingStatusType_; }
          set {
            tradingStatusType_ = value;
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
          if (!object.Equals(SecKey, other.SecKey)) return false;
          if (SecType != other.SecType) return false;
          if (TradingStatusType != other.TradingStatusType) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (secKey_ != null) hash ^= SecKey.GetHashCode();
          if (SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) hash ^= SecType.GetHashCode();
          if (TradingStatusType != global::Spiderrock.Protobuf.TradingStatusType.Unspecified) hash ^= TradingStatusType.GetHashCode();
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
          if (secKey_ != null) {
            output.WriteRawTag(82);
            output.WriteMessage(SecKey);
          }
          if (SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
            output.WriteRawTag(88);
            output.WriteEnum((int) SecType);
          }
          if (TradingStatusType != global::Spiderrock.Protobuf.TradingStatusType.Unspecified) {
            output.WriteRawTag(96);
            output.WriteEnum((int) TradingStatusType);
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
          if (secKey_ != null) {
            output.WriteRawTag(82);
            output.WriteMessage(SecKey);
          }
          if (SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
            output.WriteRawTag(88);
            output.WriteEnum((int) SecType);
          }
          if (TradingStatusType != global::Spiderrock.Protobuf.TradingStatusType.Unspecified) {
            output.WriteRawTag(96);
            output.WriteEnum((int) TradingStatusType);
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
          if (secKey_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(SecKey);
          }
          if (SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SecType);
          }
          if (TradingStatusType != global::Spiderrock.Protobuf.TradingStatusType.Unspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TradingStatusType);
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
          if (other.secKey_ != null) {
            if (secKey_ == null) {
              SecKey = new global::Spiderrock.Protobuf.OptionKey();
            }
            SecKey.MergeFrom(other.SecKey);
          }
          if (other.SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
            SecType = other.SecType;
          }
          if (other.TradingStatusType != global::Spiderrock.Protobuf.TradingStatusType.Unspecified) {
            TradingStatusType = other.TradingStatusType;
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
                if (secKey_ == null) {
                  SecKey = new global::Spiderrock.Protobuf.OptionKey();
                }
                input.ReadMessage(SecKey);
                break;
              }
              case 88: {
                SecType = (global::Spiderrock.Protobuf.SpdrKeyType) input.ReadEnum();
                break;
              }
              case 96: {
                TradingStatusType = (global::Spiderrock.Protobuf.TradingStatusType) input.ReadEnum();
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
                if (secKey_ == null) {
                  SecKey = new global::Spiderrock.Protobuf.OptionKey();
                }
                input.ReadMessage(SecKey);
                break;
              }
              case 88: {
                SecType = (global::Spiderrock.Protobuf.SpdrKeyType) input.ReadEnum();
                break;
              }
              case 96: {
                TradingStatusType = (global::Spiderrock.Protobuf.TradingStatusType) input.ReadEnum();
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
