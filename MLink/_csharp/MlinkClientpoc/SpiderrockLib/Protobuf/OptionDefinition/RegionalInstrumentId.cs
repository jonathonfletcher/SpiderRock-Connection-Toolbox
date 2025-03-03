// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/OptionDefinition/RegionalInstrumentId.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/OptionDefinition/RegionalInstrumentId.proto</summary>
  public static partial class RegionalInstrumentIdReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/OptionDefinition/RegionalInstrumentId.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RegionalInstrumentIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRQcm90b2J1Zi9PcHRpb25EZWZpbml0aW9uL1JlZ2lvbmFsSW5zdHJ1bWVu",
            "dElkLnByb3RvEhNzcGlkZXJyb2NrLnByb3RvYnVmGhdzcGlkZXJyb2NrX2Nv",
            "bW1vbi5wcm90byKVAwoUUmVnaW9uYWxJbnN0cnVtZW50SWQSMwoFX21ldGEY",
            "ASABKAsyJC5zcGlkZXJyb2NrLnByb3RvYnVmLk1lc3NhZ2VNZXRhZGF0YRI8",
            "CgRwa2V5GAIgASgLMi4uc3BpZGVycm9jay5wcm90b2J1Zi5SZWdpb25hbElu",
            "c3RydW1lbnRJZC5QS2V5EhkKEW1hcmtldF9zZWdtZW50X2lkGGQgASgJEhUK",
            "DWluc3RydW1lbnRfaWQYZSABKAkSFwoPcHJvZHVjdF9jb21wbGV4GGYgASgJ",
            "EgsKA3JpYxhnIAEoCRILCgNiYmcYaCABKAkSDAoEaXNpbhhpIAEoCRINCgVz",
            "ZWRvbBhqIAEoCRINCgVjdXNpcBhrIAEoCRIMCgRmaWdpGGwgASgJGmsKBFBL",
            "ZXkSLwoHc2VjX2tleRgKIAEoCzIeLnNwaWRlcnJvY2sucHJvdG9idWYuT3B0",
            "aW9uS2V5EjIKCHNlY190eXBlGAsgASgOMiAuc3BpZGVycm9jay5wcm90b2J1",
            "Zi5TcGRyS2V5VHlwZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.RegionalInstrumentId), global::Spiderrock.Protobuf.RegionalInstrumentId.Parser, new[]{ "Meta", "Pkey", "MarketSegmentId", "InstrumentId", "ProductComplex", "Ric", "Bbg", "Isin", "Sedol", "Cusip", "Figi" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.RegionalInstrumentId.Types.PKey), global::Spiderrock.Protobuf.RegionalInstrumentId.Types.PKey.Parser, new[]{ "SecKey", "SecType" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  ///RegionalInstrumentId (internal only) records exist per security and provide symbology mapping. Eg for an option contract on Eurex the instid and marketsegid would be provided
  /// </summary>
  public sealed partial class RegionalInstrumentId : pb::IMessage<RegionalInstrumentId>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RegionalInstrumentId> _parser = new pb::MessageParser<RegionalInstrumentId>(() => new RegionalInstrumentId());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RegionalInstrumentId> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.RegionalInstrumentIdReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegionalInstrumentId() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegionalInstrumentId(RegionalInstrumentId other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      marketSegmentId_ = other.marketSegmentId_;
      instrumentId_ = other.instrumentId_;
      productComplex_ = other.productComplex_;
      ric_ = other.ric_;
      bbg_ = other.bbg_;
      isin_ = other.isin_;
      sedol_ = other.sedol_;
      cusip_ = other.cusip_;
      figi_ = other.figi_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegionalInstrumentId Clone() {
      return new RegionalInstrumentId(this);
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
    private global::Spiderrock.Protobuf.RegionalInstrumentId.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.RegionalInstrumentId.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "market_segment_id" field.</summary>
    public const int MarketSegmentIdFieldNumber = 100;
    private string marketSegmentId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MarketSegmentId {
      get { return marketSegmentId_; }
      set {
        marketSegmentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "instrument_id" field.</summary>
    public const int InstrumentIdFieldNumber = 101;
    private string instrumentId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string InstrumentId {
      get { return instrumentId_; }
      set {
        instrumentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "product_complex" field.</summary>
    public const int ProductComplexFieldNumber = 102;
    private string productComplex_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductComplex {
      get { return productComplex_; }
      set {
        productComplex_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ric" field.</summary>
    public const int RicFieldNumber = 103;
    private string ric_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Ric {
      get { return ric_; }
      set {
        ric_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bbg" field.</summary>
    public const int BbgFieldNumber = 104;
    private string bbg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Bbg {
      get { return bbg_; }
      set {
        bbg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "isin" field.</summary>
    public const int IsinFieldNumber = 105;
    private string isin_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Isin {
      get { return isin_; }
      set {
        isin_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sedol" field.</summary>
    public const int SedolFieldNumber = 106;
    private string sedol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Sedol {
      get { return sedol_; }
      set {
        sedol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cusip" field.</summary>
    public const int CusipFieldNumber = 107;
    private string cusip_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Cusip {
      get { return cusip_; }
      set {
        cusip_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "figi" field.</summary>
    public const int FigiFieldNumber = 108;
    private string figi_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Figi {
      get { return figi_; }
      set {
        figi_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RegionalInstrumentId);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RegionalInstrumentId other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (MarketSegmentId != other.MarketSegmentId) return false;
      if (InstrumentId != other.InstrumentId) return false;
      if (ProductComplex != other.ProductComplex) return false;
      if (Ric != other.Ric) return false;
      if (Bbg != other.Bbg) return false;
      if (Isin != other.Isin) return false;
      if (Sedol != other.Sedol) return false;
      if (Cusip != other.Cusip) return false;
      if (Figi != other.Figi) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (MarketSegmentId.Length != 0) hash ^= MarketSegmentId.GetHashCode();
      if (InstrumentId.Length != 0) hash ^= InstrumentId.GetHashCode();
      if (ProductComplex.Length != 0) hash ^= ProductComplex.GetHashCode();
      if (Ric.Length != 0) hash ^= Ric.GetHashCode();
      if (Bbg.Length != 0) hash ^= Bbg.GetHashCode();
      if (Isin.Length != 0) hash ^= Isin.GetHashCode();
      if (Sedol.Length != 0) hash ^= Sedol.GetHashCode();
      if (Cusip.Length != 0) hash ^= Cusip.GetHashCode();
      if (Figi.Length != 0) hash ^= Figi.GetHashCode();
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
      if (MarketSegmentId.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(MarketSegmentId);
      }
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(170, 6);
        output.WriteString(InstrumentId);
      }
      if (ProductComplex.Length != 0) {
        output.WriteRawTag(178, 6);
        output.WriteString(ProductComplex);
      }
      if (Ric.Length != 0) {
        output.WriteRawTag(186, 6);
        output.WriteString(Ric);
      }
      if (Bbg.Length != 0) {
        output.WriteRawTag(194, 6);
        output.WriteString(Bbg);
      }
      if (Isin.Length != 0) {
        output.WriteRawTag(202, 6);
        output.WriteString(Isin);
      }
      if (Sedol.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(Sedol);
      }
      if (Cusip.Length != 0) {
        output.WriteRawTag(218, 6);
        output.WriteString(Cusip);
      }
      if (Figi.Length != 0) {
        output.WriteRawTag(226, 6);
        output.WriteString(Figi);
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
      if (MarketSegmentId.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(MarketSegmentId);
      }
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(170, 6);
        output.WriteString(InstrumentId);
      }
      if (ProductComplex.Length != 0) {
        output.WriteRawTag(178, 6);
        output.WriteString(ProductComplex);
      }
      if (Ric.Length != 0) {
        output.WriteRawTag(186, 6);
        output.WriteString(Ric);
      }
      if (Bbg.Length != 0) {
        output.WriteRawTag(194, 6);
        output.WriteString(Bbg);
      }
      if (Isin.Length != 0) {
        output.WriteRawTag(202, 6);
        output.WriteString(Isin);
      }
      if (Sedol.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(Sedol);
      }
      if (Cusip.Length != 0) {
        output.WriteRawTag(218, 6);
        output.WriteString(Cusip);
      }
      if (Figi.Length != 0) {
        output.WriteRawTag(226, 6);
        output.WriteString(Figi);
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
      if (MarketSegmentId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(MarketSegmentId);
      }
      if (InstrumentId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(InstrumentId);
      }
      if (ProductComplex.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ProductComplex);
      }
      if (Ric.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Ric);
      }
      if (Bbg.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Bbg);
      }
      if (Isin.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Isin);
      }
      if (Sedol.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Sedol);
      }
      if (Cusip.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Cusip);
      }
      if (Figi.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Figi);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RegionalInstrumentId other) {
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
          Pkey = new global::Spiderrock.Protobuf.RegionalInstrumentId.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.MarketSegmentId.Length != 0) {
        MarketSegmentId = other.MarketSegmentId;
      }
      if (other.InstrumentId.Length != 0) {
        InstrumentId = other.InstrumentId;
      }
      if (other.ProductComplex.Length != 0) {
        ProductComplex = other.ProductComplex;
      }
      if (other.Ric.Length != 0) {
        Ric = other.Ric;
      }
      if (other.Bbg.Length != 0) {
        Bbg = other.Bbg;
      }
      if (other.Isin.Length != 0) {
        Isin = other.Isin;
      }
      if (other.Sedol.Length != 0) {
        Sedol = other.Sedol;
      }
      if (other.Cusip.Length != 0) {
        Cusip = other.Cusip;
      }
      if (other.Figi.Length != 0) {
        Figi = other.Figi;
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
              Pkey = new global::Spiderrock.Protobuf.RegionalInstrumentId.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            MarketSegmentId = input.ReadString();
            break;
          }
          case 810: {
            InstrumentId = input.ReadString();
            break;
          }
          case 818: {
            ProductComplex = input.ReadString();
            break;
          }
          case 826: {
            Ric = input.ReadString();
            break;
          }
          case 834: {
            Bbg = input.ReadString();
            break;
          }
          case 842: {
            Isin = input.ReadString();
            break;
          }
          case 850: {
            Sedol = input.ReadString();
            break;
          }
          case 858: {
            Cusip = input.ReadString();
            break;
          }
          case 866: {
            Figi = input.ReadString();
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
              Pkey = new global::Spiderrock.Protobuf.RegionalInstrumentId.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            MarketSegmentId = input.ReadString();
            break;
          }
          case 810: {
            InstrumentId = input.ReadString();
            break;
          }
          case 818: {
            ProductComplex = input.ReadString();
            break;
          }
          case 826: {
            Ric = input.ReadString();
            break;
          }
          case 834: {
            Bbg = input.ReadString();
            break;
          }
          case 842: {
            Isin = input.ReadString();
            break;
          }
          case 850: {
            Sedol = input.ReadString();
            break;
          }
          case 858: {
            Cusip = input.ReadString();
            break;
          }
          case 866: {
            Figi = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the RegionalInstrumentId message type.</summary>
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
          get { return global::Spiderrock.Protobuf.RegionalInstrumentId.Descriptor.NestedTypes[0]; }
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
        /// <summary>
        /// -- Can be Option, Stock, Future
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.SpdrKeyType SecType {
          get { return secType_; }
          set {
            secType_ = value;
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
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (secKey_ != null) hash ^= SecKey.GetHashCode();
          if (SecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) hash ^= SecType.GetHashCode();
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
