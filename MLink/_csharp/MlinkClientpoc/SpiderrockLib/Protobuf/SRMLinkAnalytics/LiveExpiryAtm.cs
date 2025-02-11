// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/SRMLinkAnalytics/LiveExpiryAtm.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/SRMLinkAnalytics/LiveExpiryAtm.proto</summary>
  public static partial class LiveExpiryAtmReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/SRMLinkAnalytics/LiveExpiryAtm.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LiveExpiryAtmReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1Qcm90b2J1Zi9TUk1MaW5rQW5hbHl0aWNzL0xpdmVFeHBpcnlBdG0ucHJv",
            "dG8SE3NwaWRlcnJvY2sucHJvdG9idWYaF3NwaWRlcnJvY2tfY29tbW9uLnBy",
            "b3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIqIDCg1MaXZl",
            "RXhwaXJ5QXRtEjMKBV9tZXRhGAEgASgLMiQuc3BpZGVycm9jay5wcm90b2J1",
            "Zi5NZXNzYWdlTWV0YWRhdGESNQoEcGtleRgCIAEoCzInLnNwaWRlcnJvY2su",
            "cHJvdG9idWYuTGl2ZUV4cGlyeUF0bS5QS2V5Eg0KBXVfcHJjGGQgASgBEhQK",
            "DHVfcHJjX2RyaXZlchhlIAEoARIPCgdhdG1fdm9sGGYgASgCEhEKCWF0bV9z",
            "bG9wZRhnIAEoAhISCgpheGlzX2ZVUHJjGGggASgCEg4KBnhfbXVsdBhpIAEo",
            "AhIPCgd4X3NoaWZ0GGogASgCEhEKCXNrZXdfbXVsdBhrIAEoAhIvCgtzX3Rp",
            "bWVzdGFtcBhsIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASLQoJ",
            "dGltZXN0YW1wGG0gASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBo0",
            "CgRQS2V5EiwKBGVrZXkYCiABKAsyHi5zcGlkZXJyb2NrLnByb3RvYnVmLkV4",
            "cGlyeUtleWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.LiveExpiryAtm), global::Spiderrock.Protobuf.LiveExpiryAtm.Parser, new[]{ "Meta", "Pkey", "UPrc", "UPrcDriver", "AtmVol", "AtmSlope", "AxisFUPrc", "XMult", "XShift", "SkewMult", "STimestamp", "Timestamp" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.LiveExpiryAtm.Types.PKey), global::Spiderrock.Protobuf.LiveExpiryAtm.Types.PKey.Parser, new[]{ "Ekey" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  ///LiveExpiryAtm (surfaceType = 'Live') records are computed and publish continuously during trading hours and represent a current best implied volatility market fit.
  ///SurfaceType = 'PriorDay' records contain the `closing surface record from the prior trading period (usually from just before the last main session close).
  /// </summary>
  public sealed partial class LiveExpiryAtm : pb::IMessage<LiveExpiryAtm>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LiveExpiryAtm> _parser = new pb::MessageParser<LiveExpiryAtm>(() => new LiveExpiryAtm());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LiveExpiryAtm> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.LiveExpiryAtmReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LiveExpiryAtm() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LiveExpiryAtm(LiveExpiryAtm other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      uPrc_ = other.uPrc_;
      uPrcDriver_ = other.uPrcDriver_;
      atmVol_ = other.atmVol_;
      atmSlope_ = other.atmSlope_;
      axisFUPrc_ = other.axisFUPrc_;
      xMult_ = other.xMult_;
      xShift_ = other.xShift_;
      skewMult_ = other.skewMult_;
      sTimestamp_ = other.sTimestamp_ != null ? other.sTimestamp_.Clone() : null;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LiveExpiryAtm Clone() {
      return new LiveExpiryAtm(this);
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
    private global::Spiderrock.Protobuf.LiveExpiryAtm.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.LiveExpiryAtm.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "u_prc" field.</summary>
    public const int UPrcFieldNumber = 100;
    private double uPrc_;
    /// <summary>
    /// effective uPrc used for surface fitting
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double UPrc {
      get { return uPrc_; }
      set {
        uPrc_ = value;
      }
    }

    /// <summary>Field number for the "u_prc_driver" field.</summary>
    public const int UPrcDriverFieldNumber = 101;
    private double uPrcDriver_;
    /// <summary>
    /// underlier driver (mid-market)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double UPrcDriver {
      get { return uPrcDriver_; }
      set {
        uPrcDriver_ = value;
      }
    }

    /// <summary>Field number for the "atm_vol" field.</summary>
    public const int AtmVolFieldNumber = 102;
    private float atmVol_;
    /// <summary>
    /// atm surface volatility (xAxis = 0)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float AtmVol {
      get { return atmVol_; }
      set {
        atmVol_ = value;
      }
    }

    /// <summary>Field number for the "atm_slope" field.</summary>
    public const int AtmSlopeFieldNumber = 103;
    private float atmSlope_;
    /// <summary>
    /// volatility surface slope (dVol / dXAxis) @ ATM (xAxis=0)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float AtmSlope {
      get { return atmSlope_; }
      set {
        atmSlope_ = value;
      }
    }

    /// <summary>Field number for the "axis_fUPrc" field.</summary>
    public const int AxisFUPrcFieldNumber = 104;
    private float axisFUPrc_;
    /// <summary>
    /// axis fwdUPrc (used to compute xAxis)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float AxisFUPrc {
      get { return axisFUPrc_; }
      set {
        axisFUPrc_ = value;
      }
    }

    /// <summary>Field number for the "x_mult" field.</summary>
    public const int XMultFieldNumber = 105;
    private float xMult_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float XMult {
      get { return xMult_; }
      set {
        xMult_ = value;
      }
    }

    /// <summary>Field number for the "x_shift" field.</summary>
    public const int XShiftFieldNumber = 106;
    private float xShift_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float XShift {
      get { return xShift_; }
      set {
        xShift_ = value;
      }
    }

    /// <summary>Field number for the "skew_mult" field.</summary>
    public const int SkewMultFieldNumber = 107;
    private float skewMult_;
    /// <summary>
    /// sVol = skewMult * BasisSkewFn(xMult * (xAxis - xShift))
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float SkewMult {
      get { return skewMult_; }
      set {
        skewMult_ = value;
      }
    }

    /// <summary>Field number for the "s_timestamp" field.</summary>
    public const int STimestampFieldNumber = 108;
    private global::Google.Protobuf.WellKnownTypes.Timestamp sTimestamp_;
    /// <summary>
    /// timestamp of the corresponding LiveExpirySurface record
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp STimestamp {
      get { return sTimestamp_; }
      set {
        sTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 109;
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
      return Equals(other as LiveExpiryAtm);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LiveExpiryAtm other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(UPrc, other.UPrc)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(UPrcDriver, other.UPrcDriver)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AtmVol, other.AtmVol)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AtmSlope, other.AtmSlope)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AxisFUPrc, other.AxisFUPrc)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(XMult, other.XMult)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(XShift, other.XShift)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SkewMult, other.SkewMult)) return false;
      if (!object.Equals(STimestamp, other.STimestamp)) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (UPrc != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(UPrc);
      if (UPrcDriver != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(UPrcDriver);
      if (AtmVol != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AtmVol);
      if (AtmSlope != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AtmSlope);
      if (AxisFUPrc != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AxisFUPrc);
      if (XMult != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(XMult);
      if (XShift != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(XShift);
      if (SkewMult != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SkewMult);
      if (sTimestamp_ != null) hash ^= STimestamp.GetHashCode();
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
      if (UPrc != 0D) {
        output.WriteRawTag(161, 6);
        output.WriteDouble(UPrc);
      }
      if (UPrcDriver != 0D) {
        output.WriteRawTag(169, 6);
        output.WriteDouble(UPrcDriver);
      }
      if (AtmVol != 0F) {
        output.WriteRawTag(181, 6);
        output.WriteFloat(AtmVol);
      }
      if (AtmSlope != 0F) {
        output.WriteRawTag(189, 6);
        output.WriteFloat(AtmSlope);
      }
      if (AxisFUPrc != 0F) {
        output.WriteRawTag(197, 6);
        output.WriteFloat(AxisFUPrc);
      }
      if (XMult != 0F) {
        output.WriteRawTag(205, 6);
        output.WriteFloat(XMult);
      }
      if (XShift != 0F) {
        output.WriteRawTag(213, 6);
        output.WriteFloat(XShift);
      }
      if (SkewMult != 0F) {
        output.WriteRawTag(221, 6);
        output.WriteFloat(SkewMult);
      }
      if (sTimestamp_ != null) {
        output.WriteRawTag(226, 6);
        output.WriteMessage(STimestamp);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(234, 6);
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
      if (UPrc != 0D) {
        output.WriteRawTag(161, 6);
        output.WriteDouble(UPrc);
      }
      if (UPrcDriver != 0D) {
        output.WriteRawTag(169, 6);
        output.WriteDouble(UPrcDriver);
      }
      if (AtmVol != 0F) {
        output.WriteRawTag(181, 6);
        output.WriteFloat(AtmVol);
      }
      if (AtmSlope != 0F) {
        output.WriteRawTag(189, 6);
        output.WriteFloat(AtmSlope);
      }
      if (AxisFUPrc != 0F) {
        output.WriteRawTag(197, 6);
        output.WriteFloat(AxisFUPrc);
      }
      if (XMult != 0F) {
        output.WriteRawTag(205, 6);
        output.WriteFloat(XMult);
      }
      if (XShift != 0F) {
        output.WriteRawTag(213, 6);
        output.WriteFloat(XShift);
      }
      if (SkewMult != 0F) {
        output.WriteRawTag(221, 6);
        output.WriteFloat(SkewMult);
      }
      if (sTimestamp_ != null) {
        output.WriteRawTag(226, 6);
        output.WriteMessage(STimestamp);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(234, 6);
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
      if (UPrc != 0D) {
        size += 2 + 8;
      }
      if (UPrcDriver != 0D) {
        size += 2 + 8;
      }
      if (AtmVol != 0F) {
        size += 2 + 4;
      }
      if (AtmSlope != 0F) {
        size += 2 + 4;
      }
      if (AxisFUPrc != 0F) {
        size += 2 + 4;
      }
      if (XMult != 0F) {
        size += 2 + 4;
      }
      if (XShift != 0F) {
        size += 2 + 4;
      }
      if (SkewMult != 0F) {
        size += 2 + 4;
      }
      if (sTimestamp_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(STimestamp);
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
    public void MergeFrom(LiveExpiryAtm other) {
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
          Pkey = new global::Spiderrock.Protobuf.LiveExpiryAtm.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.UPrc != 0D) {
        UPrc = other.UPrc;
      }
      if (other.UPrcDriver != 0D) {
        UPrcDriver = other.UPrcDriver;
      }
      if (other.AtmVol != 0F) {
        AtmVol = other.AtmVol;
      }
      if (other.AtmSlope != 0F) {
        AtmSlope = other.AtmSlope;
      }
      if (other.AxisFUPrc != 0F) {
        AxisFUPrc = other.AxisFUPrc;
      }
      if (other.XMult != 0F) {
        XMult = other.XMult;
      }
      if (other.XShift != 0F) {
        XShift = other.XShift;
      }
      if (other.SkewMult != 0F) {
        SkewMult = other.SkewMult;
      }
      if (other.sTimestamp_ != null) {
        if (sTimestamp_ == null) {
          STimestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        STimestamp.MergeFrom(other.STimestamp);
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
              Pkey = new global::Spiderrock.Protobuf.LiveExpiryAtm.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 801: {
            UPrc = input.ReadDouble();
            break;
          }
          case 809: {
            UPrcDriver = input.ReadDouble();
            break;
          }
          case 821: {
            AtmVol = input.ReadFloat();
            break;
          }
          case 829: {
            AtmSlope = input.ReadFloat();
            break;
          }
          case 837: {
            AxisFUPrc = input.ReadFloat();
            break;
          }
          case 845: {
            XMult = input.ReadFloat();
            break;
          }
          case 853: {
            XShift = input.ReadFloat();
            break;
          }
          case 861: {
            SkewMult = input.ReadFloat();
            break;
          }
          case 866: {
            if (sTimestamp_ == null) {
              STimestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(STimestamp);
            break;
          }
          case 874: {
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
              Pkey = new global::Spiderrock.Protobuf.LiveExpiryAtm.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 801: {
            UPrc = input.ReadDouble();
            break;
          }
          case 809: {
            UPrcDriver = input.ReadDouble();
            break;
          }
          case 821: {
            AtmVol = input.ReadFloat();
            break;
          }
          case 829: {
            AtmSlope = input.ReadFloat();
            break;
          }
          case 837: {
            AxisFUPrc = input.ReadFloat();
            break;
          }
          case 845: {
            XMult = input.ReadFloat();
            break;
          }
          case 853: {
            XShift = input.ReadFloat();
            break;
          }
          case 861: {
            SkewMult = input.ReadFloat();
            break;
          }
          case 866: {
            if (sTimestamp_ == null) {
              STimestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(STimestamp);
            break;
          }
          case 874: {
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
    /// <summary>Container for nested types declared in the LiveExpiryAtm message type.</summary>
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
          get { return global::Spiderrock.Protobuf.LiveExpiryAtm.Descriptor.NestedTypes[0]; }
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
          ekey_ = other.ekey_ != null ? other.ekey_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey Clone() {
          return new PKey(this);
        }

        /// <summary>Field number for the "ekey" field.</summary>
        public const int EkeyFieldNumber = 10;
        private global::Spiderrock.Protobuf.ExpiryKey ekey_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.ExpiryKey Ekey {
          get { return ekey_; }
          set {
            ekey_ = value;
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
          if (!object.Equals(Ekey, other.Ekey)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (ekey_ != null) hash ^= Ekey.GetHashCode();
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
          if (ekey_ != null) {
            output.WriteRawTag(82);
            output.WriteMessage(Ekey);
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
          if (ekey_ != null) {
            output.WriteRawTag(82);
            output.WriteMessage(Ekey);
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
          if (ekey_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ekey);
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
          if (other.ekey_ != null) {
            if (ekey_ == null) {
              Ekey = new global::Spiderrock.Protobuf.ExpiryKey();
            }
            Ekey.MergeFrom(other.Ekey);
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
                if (ekey_ == null) {
                  Ekey = new global::Spiderrock.Protobuf.ExpiryKey();
                }
                input.ReadMessage(Ekey);
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
                if (ekey_ == null) {
                  Ekey = new global::Spiderrock.Protobuf.ExpiryKey();
                }
                input.ReadMessage(Ekey);
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
