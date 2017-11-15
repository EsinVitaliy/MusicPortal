using System.Runtime.Serialization;
using MusicPortalDAL.DataModel.Tables;



namespace MusicPortalBLL.Models.Database
{
    [DataContract]
    public class UserModel
    {
        [DataMember(Name = "Id")]
        public int Id { get; private set; }


        [DataMember(Name = "LastName")]
        public string LastName { get; set; }


        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }


        [DataMember(Name = "Email")]
        public string Email { get; set; }



        public UserModel(User user)
        {
            Id = user.Id;
            LastName = user.LastName;
            FirstName = user.FirstName;
            Email = user.Email;
        }
    }
}
