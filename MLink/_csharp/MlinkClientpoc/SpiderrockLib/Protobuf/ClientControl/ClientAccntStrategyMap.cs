// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/ClientControl/ClientAccntStrategyMap.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/ClientControl/ClientAccntStrategyMap.proto</summary>
  public static partial class ClientAccntStrategyMapReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/ClientControl/ClientAccntStrategyMap.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientAccntStrategyMapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNQcm90b2J1Zi9DbGllbnRDb250cm9sL0NsaWVudEFjY250U3RyYXRlZ3lN",
            "YXAucHJvdG8SE3NwaWRlcnJvY2sucHJvdG9idWYaF3NwaWRlcnJvY2tfY29t",
            "bW9uLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIowE",
            "ChZDbGllbnRBY2NudFN0cmF0ZWd5TWFwEjMKBV9tZXRhGAEgASgLMiQuc3Bp",
            "ZGVycm9jay5wcm90b2J1Zi5NZXNzYWdlTWV0YWRhdGESPgoEcGtleRgCIAEo",
            "CzIwLnNwaWRlcnJvY2sucHJvdG9idWYuQ2xpZW50QWNjbnRTdHJhdGVneU1h",
            "cC5QS2V5EhAKCGFjY250X2lEGGQgASgDEhMKC3N0cmF0ZWd5X2lEGGcgASgD",
            "EhIKCmFjY250X25hbWUYaiABKAkSEgoKdXNlcl9lbWFpbBhtIAEoCRISCgp1",
            "c2VyX3Bob25lGHAgASgJEhQKDGxlZ2FsX2VudGl0eRhzIAEoCRI0ChBkZWZh",
            "dWx0X3N0cmF0ZWd5GHkgASgOMhouc3BpZGVycm9jay5wcm90b2J1Zi5ZZXNO",
            "bxITCgttb2RpZmllZF9ieRh8IAEoCRI4Cgttb2RpZmllZF9pbhh/IAEoDjIj",
            "LnNwaWRlcnJvY2sucHJvdG9idWYuU3lzRW52aXJvbm1lbnQSLgoJdGltZXN0",
            "YW1wGIIBIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAaTwoEUEtl",
            "eRINCgVhY2NudBgKIAEoCRIQCghzdHJhdGVneRgLIAEoCRIRCglyaXNrX3Vz",
            "ZXIYDCABKAkSEwoLY2xpZW50X2Zpcm0YDSABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.ClientAccntStrategyMap), global::Spiderrock.Protobuf.ClientAccntStrategyMap.Parser, new[]{ "Meta", "Pkey", "AccntID", "StrategyID", "AccntName", "UserEmail", "UserPhone", "LegalEntity", "DefaultStrategy", "ModifiedBy", "ModifiedIn", "Timestamp" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.ClientAccntStrategyMap.Types.PKey), global::Spiderrock.Protobuf.ClientAccntStrategyMap.Types.PKey.Parser, new[]{ "Accnt", "Strategy", "RiskUser", "ClientFirm" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientAccntStrategyMap : pb::IMessage<ClientAccntStrategyMap>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientAccntStrategyMap> _parser = new pb::MessageParser<ClientAccntStrategyMap>(() => new ClientAccntStrategyMap());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientAccntStrategyMap> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.ClientAccntStrategyMapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientAccntStrategyMap() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientAccntStrategyMap(ClientAccntStrategyMap other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      accntID_ = other.accntID_;
      strategyID_ = other.strategyID_;
      accntName_ = other.accntName_;
      userEmail_ = other.userEmail_;
      userPhone_ = other.userPhone_;
      legalEntity_ = other.legalEntity_;
      defaultStrategy_ = other.defaultStrategy_;
      modifiedBy_ = other.modifiedBy_;
      modifiedIn_ = other.modifiedIn_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientAccntStrategyMap Clone() {
      return new ClientAccntStrategyMap(this);
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
    private global::Spiderrock.Protobuf.ClientAccntStrategyMap.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.ClientAccntStrategyMap.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "accnt_iD" field.</summary>
    public const int AccntIDFieldNumber = 100;
    private long accntID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long AccntID {
      get { return accntID_; }
      set {
        accntID_ = value;
      }
    }

    /// <summary>Field number for the "strategy_iD" field.</summary>
    public const int StrategyIDFieldNumber = 103;
    private long strategyID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long StrategyID {
      get { return strategyID_; }
      set {
        strategyID_ = value;
      }
    }

    /// <summary>Field number for the "accnt_name" field.</summary>
    public const int AccntNameFieldNumber = 106;
    private string accntName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccntName {
      get { return accntName_; }
      set {
        accntName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_email" field.</summary>
    public const int UserEmailFieldNumber = 109;
    private string userEmail_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserEmail {
      get { return userEmail_; }
      set {
        userEmail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_phone" field.</summary>
    public const int UserPhoneFieldNumber = 112;
    private string userPhone_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserPhone {
      get { return userPhone_; }
      set {
        userPhone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "legal_entity" field.</summary>
    public const int LegalEntityFieldNumber = 115;
    private string legalEntity_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LegalEntity {
      get { return legalEntity_; }
      set {
        legalEntity_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "default_strategy" field.</summary>
    public const int DefaultStrategyFieldNumber = 121;
    private global::Spiderrock.Protobuf.YesNo defaultStrategy_ = global::Spiderrock.Protobuf.YesNo.Unspecified;
    /// <summary>
    /// if yes, UI tools will ignore saved selection and populate strategy dropdown with this item
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.YesNo DefaultStrategy {
      get { return defaultStrategy_; }
      set {
        defaultStrategy_ = value;
      }
    }

    /// <summary>Field number for the "modified_by" field.</summary>
    public const int ModifiedByFieldNumber = 124;
    private string modifiedBy_ = "";
    /// <summary>
    /// user who last modified this record
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ModifiedBy {
      get { return modifiedBy_; }
      set {
        modifiedBy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "modified_in" field.</summary>
    public const int ModifiedInFieldNumber = 127;
    private global::Spiderrock.Protobuf.SysEnvironment modifiedIn_ = global::Spiderrock.Protobuf.SysEnvironment.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.SysEnvironment ModifiedIn {
      get { return modifiedIn_; }
      set {
        modifiedIn_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 130;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    /// <summary>
    /// timestamp of last modification
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
      return Equals(other as ClientAccntStrategyMap);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientAccntStrategyMap other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (AccntID != other.AccntID) return false;
      if (StrategyID != other.StrategyID) return false;
      if (AccntName != other.AccntName) return false;
      if (UserEmail != other.UserEmail) return false;
      if (UserPhone != other.UserPhone) return false;
      if (LegalEntity != other.LegalEntity) return false;
      if (DefaultStrategy != other.DefaultStrategy) return false;
      if (ModifiedBy != other.ModifiedBy) return false;
      if (ModifiedIn != other.ModifiedIn) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (AccntID != 0L) hash ^= AccntID.GetHashCode();
      if (StrategyID != 0L) hash ^= StrategyID.GetHashCode();
      if (AccntName.Length != 0) hash ^= AccntName.GetHashCode();
      if (UserEmail.Length != 0) hash ^= UserEmail.GetHashCode();
      if (UserPhone.Length != 0) hash ^= UserPhone.GetHashCode();
      if (LegalEntity.Length != 0) hash ^= LegalEntity.GetHashCode();
      if (DefaultStrategy != global::Spiderrock.Protobuf.YesNo.Unspecified) hash ^= DefaultStrategy.GetHashCode();
      if (ModifiedBy.Length != 0) hash ^= ModifiedBy.GetHashCode();
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) hash ^= ModifiedIn.GetHashCode();
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
      if (AccntID != 0L) {
        output.WriteRawTag(160, 6);
        output.WriteInt64(AccntID);
      }
      if (StrategyID != 0L) {
        output.WriteRawTag(184, 6);
        output.WriteInt64(StrategyID);
      }
      if (AccntName.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(AccntName);
      }
      if (UserEmail.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(UserEmail);
      }
      if (UserPhone.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(UserPhone);
      }
      if (LegalEntity.Length != 0) {
        output.WriteRawTag(154, 7);
        output.WriteString(LegalEntity);
      }
      if (DefaultStrategy != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        output.WriteRawTag(200, 7);
        output.WriteEnum((int) DefaultStrategy);
      }
      if (ModifiedBy.Length != 0) {
        output.WriteRawTag(226, 7);
        output.WriteString(ModifiedBy);
      }
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        output.WriteRawTag(248, 7);
        output.WriteEnum((int) ModifiedIn);
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
      if (AccntID != 0L) {
        output.WriteRawTag(160, 6);
        output.WriteInt64(AccntID);
      }
      if (StrategyID != 0L) {
        output.WriteRawTag(184, 6);
        output.WriteInt64(StrategyID);
      }
      if (AccntName.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(AccntName);
      }
      if (UserEmail.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(UserEmail);
      }
      if (UserPhone.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(UserPhone);
      }
      if (LegalEntity.Length != 0) {
        output.WriteRawTag(154, 7);
        output.WriteString(LegalEntity);
      }
      if (DefaultStrategy != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        output.WriteRawTag(200, 7);
        output.WriteEnum((int) DefaultStrategy);
      }
      if (ModifiedBy.Length != 0) {
        output.WriteRawTag(226, 7);
        output.WriteString(ModifiedBy);
      }
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        output.WriteRawTag(248, 7);
        output.WriteEnum((int) ModifiedIn);
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
      if (AccntID != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(AccntID);
      }
      if (StrategyID != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(StrategyID);
      }
      if (AccntName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AccntName);
      }
      if (UserEmail.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(UserEmail);
      }
      if (UserPhone.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(UserPhone);
      }
      if (LegalEntity.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(LegalEntity);
      }
      if (DefaultStrategy != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) DefaultStrategy);
      }
      if (ModifiedBy.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ModifiedBy);
      }
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) ModifiedIn);
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
    public void MergeFrom(ClientAccntStrategyMap other) {
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
          Pkey = new global::Spiderrock.Protobuf.ClientAccntStrategyMap.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.AccntID != 0L) {
        AccntID = other.AccntID;
      }
      if (other.StrategyID != 0L) {
        StrategyID = other.StrategyID;
      }
      if (other.AccntName.Length != 0) {
        AccntName = other.AccntName;
      }
      if (other.UserEmail.Length != 0) {
        UserEmail = other.UserEmail;
      }
      if (other.UserPhone.Length != 0) {
        UserPhone = other.UserPhone;
      }
      if (other.LegalEntity.Length != 0) {
        LegalEntity = other.LegalEntity;
      }
      if (other.DefaultStrategy != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        DefaultStrategy = other.DefaultStrategy;
      }
      if (other.ModifiedBy.Length != 0) {
        ModifiedBy = other.ModifiedBy;
      }
      if (other.ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        ModifiedIn = other.ModifiedIn;
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
              Pkey = new global::Spiderrock.Protobuf.ClientAccntStrategyMap.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 800: {
            AccntID = input.ReadInt64();
            break;
          }
          case 824: {
            StrategyID = input.ReadInt64();
            break;
          }
          case 850: {
            AccntName = input.ReadString();
            break;
          }
          case 874: {
            UserEmail = input.ReadString();
            break;
          }
          case 898: {
            UserPhone = input.ReadString();
            break;
          }
          case 922: {
            LegalEntity = input.ReadString();
            break;
          }
          case 968: {
            DefaultStrategy = (global::Spiderrock.Protobuf.YesNo) input.ReadEnum();
            break;
          }
          case 994: {
            ModifiedBy = input.ReadString();
            break;
          }
          case 1016: {
            ModifiedIn = (global::Spiderrock.Protobuf.SysEnvironment) input.ReadEnum();
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
              Pkey = new global::Spiderrock.Protobuf.ClientAccntStrategyMap.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 800: {
            AccntID = input.ReadInt64();
            break;
          }
          case 824: {
            StrategyID = input.ReadInt64();
            break;
          }
          case 850: {
            AccntName = input.ReadString();
            break;
          }
          case 874: {
            UserEmail = input.ReadString();
            break;
          }
          case 898: {
            UserPhone = input.ReadString();
            break;
          }
          case 922: {
            LegalEntity = input.ReadString();
            break;
          }
          case 968: {
            DefaultStrategy = (global::Spiderrock.Protobuf.YesNo) input.ReadEnum();
            break;
          }
          case 994: {
            ModifiedBy = input.ReadString();
            break;
          }
          case 1016: {
            ModifiedIn = (global::Spiderrock.Protobuf.SysEnvironment) input.ReadEnum();
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
    /// <summary>Container for nested types declared in the ClientAccntStrategyMap message type.</summary>
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
          get { return global::Spiderrock.Protobuf.ClientAccntStrategyMap.Descriptor.NestedTypes[0]; }
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
          accnt_ = other.accnt_;
          strategy_ = other.strategy_;
          riskUser_ = other.riskUser_;
          clientFirm_ = other.clientFirm_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey Clone() {
          return new PKey(this);
        }

        /// <summary>Field number for the "accnt" field.</summary>
        public const int AccntFieldNumber = 10;
        private string accnt_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Accnt {
          get { return accnt_; }
          set {
            accnt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "strategy" field.</summary>
        public const int StrategyFieldNumber = 11;
        private string strategy_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Strategy {
          get { return strategy_; }
          set {
            strategy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "risk_user" field.</summary>
        public const int RiskUserFieldNumber = 12;
        private string riskUser_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string RiskUser {
          get { return riskUser_; }
          set {
            riskUser_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "client_firm" field.</summary>
        public const int ClientFirmFieldNumber = 13;
        private string clientFirm_ = "";
        /// <summary>
        /// SR assigned client firm acronym
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
          if (Accnt != other.Accnt) return false;
          if (Strategy != other.Strategy) return false;
          if (RiskUser != other.RiskUser) return false;
          if (ClientFirm != other.ClientFirm) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Accnt.Length != 0) hash ^= Accnt.GetHashCode();
          if (Strategy.Length != 0) hash ^= Strategy.GetHashCode();
          if (RiskUser.Length != 0) hash ^= RiskUser.GetHashCode();
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
          if (Accnt.Length != 0) {
            output.WriteRawTag(82);
            output.WriteString(Accnt);
          }
          if (Strategy.Length != 0) {
            output.WriteRawTag(90);
            output.WriteString(Strategy);
          }
          if (RiskUser.Length != 0) {
            output.WriteRawTag(98);
            output.WriteString(RiskUser);
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
          if (Accnt.Length != 0) {
            output.WriteRawTag(82);
            output.WriteString(Accnt);
          }
          if (Strategy.Length != 0) {
            output.WriteRawTag(90);
            output.WriteString(Strategy);
          }
          if (RiskUser.Length != 0) {
            output.WriteRawTag(98);
            output.WriteString(RiskUser);
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
          if (Accnt.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Accnt);
          }
          if (Strategy.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Strategy);
          }
          if (RiskUser.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(RiskUser);
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
          if (other.Accnt.Length != 0) {
            Accnt = other.Accnt;
          }
          if (other.Strategy.Length != 0) {
            Strategy = other.Strategy;
          }
          if (other.RiskUser.Length != 0) {
            RiskUser = other.RiskUser;
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
                Accnt = input.ReadString();
                break;
              }
              case 90: {
                Strategy = input.ReadString();
                break;
              }
              case 98: {
                RiskUser = input.ReadString();
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
                Accnt = input.ReadString();
                break;
              }
              case 90: {
                Strategy = input.ReadString();
                break;
              }
              case 98: {
                RiskUser = input.ReadString();
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
