// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/SpreadExchData/SpreadExchDefinition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/SpreadExchData/SpreadExchDefinition.proto</summary>
  public static partial class SpreadExchDefinitionReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/SpreadExchData/SpreadExchDefinition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpreadExchDefinitionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJQcm90b2J1Zi9TcHJlYWRFeGNoRGF0YS9TcHJlYWRFeGNoRGVmaW5pdGlv",
            "bi5wcm90bxITc3BpZGVycm9jay5wcm90b2J1ZhoXc3BpZGVycm9ja19jb21t",
            "b24ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8i+AMK",
            "FFNwcmVhZEV4Y2hEZWZpbml0aW9uEjMKBV9tZXRhGAEgASgLMiQuc3BpZGVy",
            "cm9jay5wcm90b2J1Zi5NZXNzYWdlTWV0YWRhdGESPAoEcGtleRgCIAEoCzIu",
            "LnNwaWRlcnJvY2sucHJvdG9idWYuU3ByZWFkRXhjaERlZmluaXRpb24uUEtl",
            "eRItCgl0aW1lc3RhbXAYaSABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0",
            "YW1wEjwKBGxlZ3MYZCADKAsyLi5zcGlkZXJyb2NrLnByb3RvYnVmLlNwcmVh",
            "ZEV4Y2hEZWZpbml0aW9uLkxlZ3MaRwoEUEtleRIqCgRleGNoGAogASgOMhwu",
            "c3BpZGVycm9jay5wcm90b2J1Zi5PcHRFeGNoEhMKC2V4Y2hfc3ByX2lEGAsg",
            "ASgJGrYBCgRMZWdzEjMKC2xlZ19zZWNfa2V5GGUgASgLMh4uc3BpZGVycm9j",
            "ay5wcm90b2J1Zi5PcHRpb25LZXkSNgoMbGVnX3NlY190eXBlGGYgASgOMiAu",
            "c3BpZGVycm9jay5wcm90b2J1Zi5TcGRyS2V5VHlwZRIuCghsZWdfc2lkZRhn",
            "IAEoDjIcLnNwaWRlcnJvY2sucHJvdG9idWYuQnV5U2VsbBIRCglsZWdfcmF0",
            "aW8YaCABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.SpreadExchDefinition), global::Spiderrock.Protobuf.SpreadExchDefinition.Parser, new[]{ "Meta", "Pkey", "Timestamp", "Legs" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.SpreadExchDefinition.Types.PKey), global::Spiderrock.Protobuf.SpreadExchDefinition.Types.PKey.Parser, new[]{ "Exch", "ExchSprID" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.SpreadExchDefinition.Types.Legs), global::Spiderrock.Protobuf.SpreadExchDefinition.Types.Legs.Parser, new[]{ "LegSecKey", "LegSecType", "LegSide", "LegRatio" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SpreadExchDefinition : pb::IMessage<SpreadExchDefinition>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpreadExchDefinition> _parser = new pb::MessageParser<SpreadExchDefinition>(() => new SpreadExchDefinition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpreadExchDefinition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.SpreadExchDefinitionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpreadExchDefinition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpreadExchDefinition(SpreadExchDefinition other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      legs_ = other.legs_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpreadExchDefinition Clone() {
      return new SpreadExchDefinition(this);
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
    private global::Spiderrock.Protobuf.SpreadExchDefinition.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.SpreadExchDefinition.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 105;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "legs" field.</summary>
    public const int LegsFieldNumber = 100;
    private static readonly pb::FieldCodec<global::Spiderrock.Protobuf.SpreadExchDefinition.Types.Legs> _repeated_legs_codec
        = pb::FieldCodec.ForMessage(802, global::Spiderrock.Protobuf.SpreadExchDefinition.Types.Legs.Parser);
    private readonly pbc::RepeatedField<global::Spiderrock.Protobuf.SpreadExchDefinition.Types.Legs> legs_ = new pbc::RepeatedField<global::Spiderrock.Protobuf.SpreadExchDefinition.Types.Legs>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Spiderrock.Protobuf.SpreadExchDefinition.Types.Legs> Legs {
      get { return legs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpreadExchDefinition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpreadExchDefinition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      if(!legs_.Equals(other.legs_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      hash ^= legs_.GetHashCode();
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
      legs_.WriteTo(output, _repeated_legs_codec);
      if (timestamp_ != null) {
        output.WriteRawTag(202, 6);
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
      legs_.WriteTo(ref output, _repeated_legs_codec);
      if (timestamp_ != null) {
        output.WriteRawTag(202, 6);
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
      if (timestamp_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      size += legs_.CalculateSize(_repeated_legs_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpreadExchDefinition other) {
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
          Pkey = new global::Spiderrock.Protobuf.SpreadExchDefinition.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
      }
      legs_.Add(other.legs_);
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
              Pkey = new global::Spiderrock.Protobuf.SpreadExchDefinition.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            legs_.AddEntriesFrom(input, _repeated_legs_codec);
            break;
          }
          case 842: {
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
              Pkey = new global::Spiderrock.Protobuf.SpreadExchDefinition.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            legs_.AddEntriesFrom(ref input, _repeated_legs_codec);
            break;
          }
          case 842: {
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
    /// <summary>Container for nested types declared in the SpreadExchDefinition message type.</summary>
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
          get { return global::Spiderrock.Protobuf.SpreadExchDefinition.Descriptor.NestedTypes[0]; }
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
          exch_ = other.exch_;
          exchSprID_ = other.exchSprID_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey Clone() {
          return new PKey(this);
        }

        /// <summary>Field number for the "exch" field.</summary>
        public const int ExchFieldNumber = 10;
        private global::Spiderrock.Protobuf.OptExch exch_ = global::Spiderrock.Protobuf.OptExch.Unspecified;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.OptExch Exch {
          get { return exch_; }
          set {
            exch_ = value;
          }
        }

        /// <summary>Field number for the "exch_spr_iD" field.</summary>
        public const int ExchSprIDFieldNumber = 11;
        private string exchSprID_ = "";
        /// <summary>
        /// unique exchange spread id
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string ExchSprID {
          get { return exchSprID_; }
          set {
            exchSprID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
          if (Exch != other.Exch) return false;
          if (ExchSprID != other.ExchSprID) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Exch != global::Spiderrock.Protobuf.OptExch.Unspecified) hash ^= Exch.GetHashCode();
          if (ExchSprID.Length != 0) hash ^= ExchSprID.GetHashCode();
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
          if (Exch != global::Spiderrock.Protobuf.OptExch.Unspecified) {
            output.WriteRawTag(80);
            output.WriteEnum((int) Exch);
          }
          if (ExchSprID.Length != 0) {
            output.WriteRawTag(90);
            output.WriteString(ExchSprID);
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
          if (Exch != global::Spiderrock.Protobuf.OptExch.Unspecified) {
            output.WriteRawTag(80);
            output.WriteEnum((int) Exch);
          }
          if (ExchSprID.Length != 0) {
            output.WriteRawTag(90);
            output.WriteString(ExchSprID);
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
          if (Exch != global::Spiderrock.Protobuf.OptExch.Unspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Exch);
          }
          if (ExchSprID.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ExchSprID);
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
          if (other.Exch != global::Spiderrock.Protobuf.OptExch.Unspecified) {
            Exch = other.Exch;
          }
          if (other.ExchSprID.Length != 0) {
            ExchSprID = other.ExchSprID;
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
                Exch = (global::Spiderrock.Protobuf.OptExch) input.ReadEnum();
                break;
              }
              case 90: {
                ExchSprID = input.ReadString();
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
                Exch = (global::Spiderrock.Protobuf.OptExch) input.ReadEnum();
                break;
              }
              case 90: {
                ExchSprID = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

      public sealed partial class Legs : pb::IMessage<Legs>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Legs> _parser = new pb::MessageParser<Legs>(() => new Legs());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Legs> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Spiderrock.Protobuf.SpreadExchDefinition.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Legs() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Legs(Legs other) : this() {
          legSecKey_ = other.legSecKey_ != null ? other.legSecKey_.Clone() : null;
          legSecType_ = other.legSecType_;
          legSide_ = other.legSide_;
          legRatio_ = other.legRatio_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Legs Clone() {
          return new Legs(this);
        }

        /// <summary>Field number for the "leg_sec_key" field.</summary>
        public const int LegSecKeyFieldNumber = 101;
        private global::Spiderrock.Protobuf.OptionKey legSecKey_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.OptionKey LegSecKey {
          get { return legSecKey_; }
          set {
            legSecKey_ = value;
          }
        }

        /// <summary>Field number for the "leg_sec_type" field.</summary>
        public const int LegSecTypeFieldNumber = 102;
        private global::Spiderrock.Protobuf.SpdrKeyType legSecType_ = global::Spiderrock.Protobuf.SpdrKeyType.Unspecified;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.SpdrKeyType LegSecType {
          get { return legSecType_; }
          set {
            legSecType_ = value;
          }
        }

        /// <summary>Field number for the "leg_side" field.</summary>
        public const int LegSideFieldNumber = 103;
        private global::Spiderrock.Protobuf.BuySell legSide_ = global::Spiderrock.Protobuf.BuySell.Unspecified;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.BuySell LegSide {
          get { return legSide_; }
          set {
            legSide_ = value;
          }
        }

        /// <summary>Field number for the "leg_ratio" field.</summary>
        public const int LegRatioFieldNumber = 104;
        private uint legRatio_;
        /// <summary>
        /// leg ratio (1, 2, etc)
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint LegRatio {
          get { return legRatio_; }
          set {
            legRatio_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Legs);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Legs other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(LegSecKey, other.LegSecKey)) return false;
          if (LegSecType != other.LegSecType) return false;
          if (LegSide != other.LegSide) return false;
          if (LegRatio != other.LegRatio) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (legSecKey_ != null) hash ^= LegSecKey.GetHashCode();
          if (LegSecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) hash ^= LegSecType.GetHashCode();
          if (LegSide != global::Spiderrock.Protobuf.BuySell.Unspecified) hash ^= LegSide.GetHashCode();
          if (LegRatio != 0) hash ^= LegRatio.GetHashCode();
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
          if (legSecKey_ != null) {
            output.WriteRawTag(170, 6);
            output.WriteMessage(LegSecKey);
          }
          if (LegSecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
            output.WriteRawTag(176, 6);
            output.WriteEnum((int) LegSecType);
          }
          if (LegSide != global::Spiderrock.Protobuf.BuySell.Unspecified) {
            output.WriteRawTag(184, 6);
            output.WriteEnum((int) LegSide);
          }
          if (LegRatio != 0) {
            output.WriteRawTag(192, 6);
            output.WriteUInt32(LegRatio);
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
          if (legSecKey_ != null) {
            output.WriteRawTag(170, 6);
            output.WriteMessage(LegSecKey);
          }
          if (LegSecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
            output.WriteRawTag(176, 6);
            output.WriteEnum((int) LegSecType);
          }
          if (LegSide != global::Spiderrock.Protobuf.BuySell.Unspecified) {
            output.WriteRawTag(184, 6);
            output.WriteEnum((int) LegSide);
          }
          if (LegRatio != 0) {
            output.WriteRawTag(192, 6);
            output.WriteUInt32(LegRatio);
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
          if (legSecKey_ != null) {
            size += 2 + pb::CodedOutputStream.ComputeMessageSize(LegSecKey);
          }
          if (LegSecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
            size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) LegSecType);
          }
          if (LegSide != global::Spiderrock.Protobuf.BuySell.Unspecified) {
            size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) LegSide);
          }
          if (LegRatio != 0) {
            size += 2 + pb::CodedOutputStream.ComputeUInt32Size(LegRatio);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Legs other) {
          if (other == null) {
            return;
          }
          if (other.legSecKey_ != null) {
            if (legSecKey_ == null) {
              LegSecKey = new global::Spiderrock.Protobuf.OptionKey();
            }
            LegSecKey.MergeFrom(other.LegSecKey);
          }
          if (other.LegSecType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
            LegSecType = other.LegSecType;
          }
          if (other.LegSide != global::Spiderrock.Protobuf.BuySell.Unspecified) {
            LegSide = other.LegSide;
          }
          if (other.LegRatio != 0) {
            LegRatio = other.LegRatio;
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
              case 810: {
                if (legSecKey_ == null) {
                  LegSecKey = new global::Spiderrock.Protobuf.OptionKey();
                }
                input.ReadMessage(LegSecKey);
                break;
              }
              case 816: {
                LegSecType = (global::Spiderrock.Protobuf.SpdrKeyType) input.ReadEnum();
                break;
              }
              case 824: {
                LegSide = (global::Spiderrock.Protobuf.BuySell) input.ReadEnum();
                break;
              }
              case 832: {
                LegRatio = input.ReadUInt32();
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
              case 810: {
                if (legSecKey_ == null) {
                  LegSecKey = new global::Spiderrock.Protobuf.OptionKey();
                }
                input.ReadMessage(LegSecKey);
                break;
              }
              case 816: {
                LegSecType = (global::Spiderrock.Protobuf.SpdrKeyType) input.ReadEnum();
                break;
              }
              case 824: {
                LegSide = (global::Spiderrock.Protobuf.BuySell) input.ReadEnum();
                break;
              }
              case 832: {
                LegRatio = input.ReadUInt32();
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
