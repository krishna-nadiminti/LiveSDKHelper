using System.Runtime.Serialization;

namespace LiveSDKHelper.SkyDrive
{
    [DataContract]
    public enum ItemType
    {
        [DataMember(Name = "file")]
        File = 0,

        [DataMember(Name = "album")]
        Album,

        [DataMember(Name = "folder")]
        Folder,

        [DataMember(Name= "photo")]
        Photo,

        [DataMember(Name = "notebook")]
        Notebook,

        [DataMember(Name = "audio")]
        Audio
    }
}