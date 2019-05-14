// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/localization/proto/localization_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Localization {

  /// <summary>Holder for reflection information generated from modules/localization/proto/localization_config.proto</summary>
  public static partial class LocalizationConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/localization/proto/localization_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocalizationConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRtb2R1bGVzL2xvY2FsaXphdGlvbi9wcm90by9sb2NhbGl6YXRpb25fY29u",
            "ZmlnLnByb3RvEhNhcG9sbG8ubG9jYWxpemF0aW9uIo8BChJMb2NhbGl6YXRp",
            "b25Db25maWcSUwoRbG9jYWxpemF0aW9uX3R5cGUYASABKA4yOC5hcG9sbG8u",
            "bG9jYWxpemF0aW9uLkxvY2FsaXphdGlvbkNvbmZpZy5Mb2NhbGl6YXRpb25U",
            "eXBlIiQKEExvY2FsaXphdGlvblR5cGUSBwoDUlRLEAASBwoDTVNGEAFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Localization.LocalizationConfig), global::Apollo.Localization.LocalizationConfig.Parser, new[]{ "LocalizationType" }, null, new[]{ typeof(global::Apollo.Localization.LocalizationConfig.Types.LocalizationType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LocalizationConfig : pb::IMessage<LocalizationConfig> {
    private static readonly pb::MessageParser<LocalizationConfig> _parser = new pb::MessageParser<LocalizationConfig>(() => new LocalizationConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LocalizationConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Localization.LocalizationConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocalizationConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocalizationConfig(LocalizationConfig other) : this() {
      localizationType_ = other.localizationType_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocalizationConfig Clone() {
      return new LocalizationConfig(this);
    }

    /// <summary>Field number for the "localization_type" field.</summary>
    public const int LocalizationTypeFieldNumber = 1;
    private global::Apollo.Localization.LocalizationConfig.Types.LocalizationType localizationType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Localization.LocalizationConfig.Types.LocalizationType LocalizationType {
      get { return localizationType_; }
      set {
        localizationType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LocalizationConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LocalizationConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LocalizationType != other.LocalizationType) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LocalizationType != 0) hash ^= LocalizationType.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (LocalizationType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) LocalizationType);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LocalizationType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LocalizationType);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LocalizationConfig other) {
      if (other == null) {
        return;
      }
      if (other.LocalizationType != 0) {
        LocalizationType = other.LocalizationType;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            localizationType_ = (global::Apollo.Localization.LocalizationConfig.Types.LocalizationType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the LocalizationConfig message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum LocalizationType {
        [pbr::OriginalName("RTK")] Rtk = 0,
        [pbr::OriginalName("MSF")] Msf = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code