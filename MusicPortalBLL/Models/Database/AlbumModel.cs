using System.Runtime.Serialization;
using MusicPortalDAL.DataModel.Tables;



namespace MusicPortalBLL.Models.Database
{
    [DataContract]
    public class AlbumModel
    {
        [DataMember(Name = "Id")]
        public int Id { get; private set; }


        [DataMember(Name = "Name")]
        public string Name { get; set; }



        public AlbumModel(Album album)
        {
            Id = album.Id;
            Name = album.Name;
        }
    }
}
