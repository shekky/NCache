//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetGroupNextChunkCommand.proto
// Note: requires additional types generated from: GroupEnumerationPointer.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetGroupNextChunkCommand")]
  public partial class GetGroupNextChunkCommand : global::ProtoBuf.IExtensible
  {
    public GetGroupNextChunkCommand() {}
    

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.GroupEnumerationPointer _groupEnumerationPointer = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"groupEnumerationPointer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.GroupEnumerationPointer groupEnumerationPointer
    {
      get { return _groupEnumerationPointer; }
      set { _groupEnumerationPointer = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}