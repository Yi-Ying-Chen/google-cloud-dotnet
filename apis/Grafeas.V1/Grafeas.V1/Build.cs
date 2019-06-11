// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: grafeas/v1/build.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grafeas.V1 {

  /// <summary>Holder for reflection information generated from grafeas/v1/build.proto</summary>
  public static partial class BuildReflection {

    #region Descriptor
    /// <summary>File descriptor for grafeas/v1/build.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuildReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZncmFmZWFzL3YxL2J1aWxkLnByb3RvEgpncmFmZWFzLnYxGhtncmFmZWFz",
            "L3YxL3Byb3ZlbmFuY2UucHJvdG8iUwoJQnVpbGROb3RlEhcKD2J1aWxkZXJf",
            "dmVyc2lvbhgBIAEoCRItCglzaWduYXR1cmUYAiABKAsyGi5ncmFmZWFzLnYx",
            "LkJ1aWxkU2lnbmF0dXJlIscBCg5CdWlsZFNpZ25hdHVyZRISCgpwdWJsaWNf",
            "a2V5GAEgASgJEhEKCXNpZ25hdHVyZRgCIAEoDBIOCgZrZXlfaWQYAyABKAkS",
            "NAoIa2V5X3R5cGUYBCABKA4yIi5ncmFmZWFzLnYxLkJ1aWxkU2lnbmF0dXJl",
            "LktleVR5cGUiSAoHS2V5VHlwZRIYChRLRVlfVFlQRV9VTlNQRUNJRklFRBAA",
            "EhUKEVBHUF9BU0NJSV9BUk1PUkVEEAESDAoIUEtJWF9QRU0QAiJcCg9CdWls",
            "ZE9jY3VycmVuY2USLwoKcHJvdmVuYW5jZRgBIAEoCzIbLmdyYWZlYXMudjEu",
            "QnVpbGRQcm92ZW5hbmNlEhgKEHByb3ZlbmFuY2VfYnl0ZXMYAiABKAlCUQoN",
            "aW8uZ3JhZmVhcy52MVABWjhnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2dyYWZlYXMvdjE7Z3JhZmVhc6ICA0dSQWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Grafeas.V1.ProvenanceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.BuildNote), global::Grafeas.V1.BuildNote.Parser, new[]{ "BuilderVersion", "Signature" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.BuildSignature), global::Grafeas.V1.BuildSignature.Parser, new[]{ "PublicKey", "Signature", "KeyId", "KeyType" }, null, new[]{ typeof(global::Grafeas.V1.BuildSignature.Types.KeyType) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.BuildOccurrence), global::Grafeas.V1.BuildOccurrence.Parser, new[]{ "Provenance", "ProvenanceBytes" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Note holding the version of the provider's builder and the signature of the
  /// provenance message in the build details occurrence.
  /// </summary>
  public sealed partial class BuildNote : pb::IMessage<BuildNote> {
    private static readonly pb::MessageParser<BuildNote> _parser = new pb::MessageParser<BuildNote>(() => new BuildNote());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuildNote> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.BuildReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildNote() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildNote(BuildNote other) : this() {
      builderVersion_ = other.builderVersion_;
      signature_ = other.signature_ != null ? other.signature_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildNote Clone() {
      return new BuildNote(this);
    }

    /// <summary>Field number for the "builder_version" field.</summary>
    public const int BuilderVersionFieldNumber = 1;
    private string builderVersion_ = "";
    /// <summary>
    /// Required. Immutable. Version of the builder which produced this build.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuilderVersion {
      get { return builderVersion_; }
      set {
        builderVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 2;
    private global::Grafeas.V1.BuildSignature signature_;
    /// <summary>
    /// Signature of the build in occurrences pointing to this build note
    /// containing build details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grafeas.V1.BuildSignature Signature {
      get { return signature_; }
      set {
        signature_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuildNote);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuildNote other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuilderVersion != other.BuilderVersion) return false;
      if (!object.Equals(Signature, other.Signature)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BuilderVersion.Length != 0) hash ^= BuilderVersion.GetHashCode();
      if (signature_ != null) hash ^= Signature.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BuilderVersion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BuilderVersion);
      }
      if (signature_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Signature);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BuilderVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuilderVersion);
      }
      if (signature_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Signature);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuildNote other) {
      if (other == null) {
        return;
      }
      if (other.BuilderVersion.Length != 0) {
        BuilderVersion = other.BuilderVersion;
      }
      if (other.signature_ != null) {
        if (signature_ == null) {
          signature_ = new global::Grafeas.V1.BuildSignature();
        }
        Signature.MergeFrom(other.Signature);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            BuilderVersion = input.ReadString();
            break;
          }
          case 18: {
            if (signature_ == null) {
              signature_ = new global::Grafeas.V1.BuildSignature();
            }
            input.ReadMessage(signature_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Message encapsulating the signature of the verified build.
  /// </summary>
  public sealed partial class BuildSignature : pb::IMessage<BuildSignature> {
    private static readonly pb::MessageParser<BuildSignature> _parser = new pb::MessageParser<BuildSignature>(() => new BuildSignature());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuildSignature> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.BuildReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildSignature() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildSignature(BuildSignature other) : this() {
      publicKey_ = other.publicKey_;
      signature_ = other.signature_;
      keyId_ = other.keyId_;
      keyType_ = other.keyType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildSignature Clone() {
      return new BuildSignature(this);
    }

    /// <summary>Field number for the "public_key" field.</summary>
    public const int PublicKeyFieldNumber = 1;
    private string publicKey_ = "";
    /// <summary>
    /// Public key of the builder which can be used to verify that the related
    /// findings are valid and unchanged. If `key_type` is empty, this defaults
    /// to PEM encoded public keys.
    ///
    /// This field may be empty if `key_id` references an external key.
    ///
    /// For Cloud Build based signatures, this is a PEM encoded public
    /// key. To verify the Cloud Build signature, place the contents of
    /// this field into a file (public.pem). The signature field is base64-decoded
    /// into its binary representation in signature.bin, and the provenance bytes
    /// from `BuildDetails` are base64-decoded into a binary representation in
    /// signed.bin. OpenSSL can then verify the signature:
    /// `openssl sha256 -verify public.pem -signature signature.bin signed.bin`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PublicKey {
      get { return publicKey_; }
      set {
        publicKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 2;
    private pb::ByteString signature_ = pb::ByteString.Empty;
    /// <summary>
    /// Required. Signature of the related `BuildProvenance`. In JSON, this is
    /// base-64 encoded.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key_id" field.</summary>
    public const int KeyIdFieldNumber = 3;
    private string keyId_ = "";
    /// <summary>
    /// An ID for the key used to sign. This could be either an ID for the key
    /// stored in `public_key` (such as the ID or fingerprint for a PGP key, or the
    /// CN for a cert), or a reference to an external key (such as a reference to a
    /// key in Cloud Key Management Service).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KeyId {
      get { return keyId_; }
      set {
        keyId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key_type" field.</summary>
    public const int KeyTypeFieldNumber = 4;
    private global::Grafeas.V1.BuildSignature.Types.KeyType keyType_ = 0;
    /// <summary>
    /// The type of the key, either stored in `public_key` or referenced in
    /// `key_id`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grafeas.V1.BuildSignature.Types.KeyType KeyType {
      get { return keyType_; }
      set {
        keyType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuildSignature);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuildSignature other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PublicKey != other.PublicKey) return false;
      if (Signature != other.Signature) return false;
      if (KeyId != other.KeyId) return false;
      if (KeyType != other.KeyType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PublicKey.Length != 0) hash ^= PublicKey.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (KeyId.Length != 0) hash ^= KeyId.GetHashCode();
      if (KeyType != 0) hash ^= KeyType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PublicKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PublicKey);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Signature);
      }
      if (KeyId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(KeyId);
      }
      if (KeyType != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) KeyType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PublicKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PublicKey);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature);
      }
      if (KeyId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KeyId);
      }
      if (KeyType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) KeyType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuildSignature other) {
      if (other == null) {
        return;
      }
      if (other.PublicKey.Length != 0) {
        PublicKey = other.PublicKey;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.KeyId.Length != 0) {
        KeyId = other.KeyId;
      }
      if (other.KeyType != 0) {
        KeyType = other.KeyType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            PublicKey = input.ReadString();
            break;
          }
          case 18: {
            Signature = input.ReadBytes();
            break;
          }
          case 26: {
            KeyId = input.ReadString();
            break;
          }
          case 32: {
            keyType_ = (global::Grafeas.V1.BuildSignature.Types.KeyType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BuildSignature message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Public key formats.
      /// </summary>
      public enum KeyType {
        /// <summary>
        /// `KeyType` is not set.
        /// </summary>
        [pbr::OriginalName("KEY_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// `PGP ASCII Armored` public key.
        /// </summary>
        [pbr::OriginalName("PGP_ASCII_ARMORED")] PgpAsciiArmored = 1,
        /// <summary>
        /// `PKIX PEM` public key.
        /// </summary>
        [pbr::OriginalName("PKIX_PEM")] PkixPem = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// Details of a build occurrence.
  /// </summary>
  public sealed partial class BuildOccurrence : pb::IMessage<BuildOccurrence> {
    private static readonly pb::MessageParser<BuildOccurrence> _parser = new pb::MessageParser<BuildOccurrence>(() => new BuildOccurrence());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuildOccurrence> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.BuildReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildOccurrence() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildOccurrence(BuildOccurrence other) : this() {
      provenance_ = other.provenance_ != null ? other.provenance_.Clone() : null;
      provenanceBytes_ = other.provenanceBytes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildOccurrence Clone() {
      return new BuildOccurrence(this);
    }

    /// <summary>Field number for the "provenance" field.</summary>
    public const int ProvenanceFieldNumber = 1;
    private global::Grafeas.V1.BuildProvenance provenance_;
    /// <summary>
    /// Required. The actual provenance for the build.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grafeas.V1.BuildProvenance Provenance {
      get { return provenance_; }
      set {
        provenance_ = value;
      }
    }

    /// <summary>Field number for the "provenance_bytes" field.</summary>
    public const int ProvenanceBytesFieldNumber = 2;
    private string provenanceBytes_ = "";
    /// <summary>
    /// Serialized JSON representation of the provenance, used in generating the
    /// build signature in the corresponding build note. After verifying the
    /// signature, `provenance_bytes` can be unmarshalled and compared to the
    /// provenance to confirm that it is unchanged. A base64-encoded string
    /// representation of the provenance bytes is used for the signature in order
    /// to interoperate with openssl which expects this format for signature
    /// verification.
    ///
    /// The serialized form is captured both to avoid ambiguity in how the
    /// provenance is marshalled to json as well to prevent incompatibilities with
    /// future changes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProvenanceBytes {
      get { return provenanceBytes_; }
      set {
        provenanceBytes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuildOccurrence);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuildOccurrence other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Provenance, other.Provenance)) return false;
      if (ProvenanceBytes != other.ProvenanceBytes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (provenance_ != null) hash ^= Provenance.GetHashCode();
      if (ProvenanceBytes.Length != 0) hash ^= ProvenanceBytes.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (provenance_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Provenance);
      }
      if (ProvenanceBytes.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProvenanceBytes);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (provenance_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Provenance);
      }
      if (ProvenanceBytes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProvenanceBytes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuildOccurrence other) {
      if (other == null) {
        return;
      }
      if (other.provenance_ != null) {
        if (provenance_ == null) {
          provenance_ = new global::Grafeas.V1.BuildProvenance();
        }
        Provenance.MergeFrom(other.Provenance);
      }
      if (other.ProvenanceBytes.Length != 0) {
        ProvenanceBytes = other.ProvenanceBytes;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (provenance_ == null) {
              provenance_ = new global::Grafeas.V1.BuildProvenance();
            }
            input.ReadMessage(provenance_);
            break;
          }
          case 18: {
            ProvenanceBytes = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code