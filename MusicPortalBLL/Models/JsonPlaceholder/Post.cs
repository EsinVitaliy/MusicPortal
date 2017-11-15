using System.Runtime.Serialization;



namespace MusicPortalBLL.Models.JsonPlaceholder
{
    [DataContract]
    public class Post
    {
        [DataMember(Name = "UserId")]
        public int UserId { get; set; }

        [DataMember(Name = "Id")]
        public int Id { get; set; }

        [DataMember(Name = "Title")]
        public string Title { get; set; }

        [DataMember(Name = "Body")]
        public string Body { get; set; }
    }
}
