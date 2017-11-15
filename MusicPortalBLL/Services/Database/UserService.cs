using System.Collections.Generic;
using MusicPortalBLL.Models.Database;
using MusicPortalDAL.DataModel.Tables;
using MusicPortalDAL.Repositories;



namespace MusicPortalBLL.Services.Database
{
    public class UserService
    {
        public List<UserModel> GetUsers()
        {
            using (UserRepository userRepository = new UserRepository())
            {
                var users = userRepository.GetAll();
                return GetUserModels(users);
            }
        }



        public UserModel GetUser(int userId)
        {
            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(userId);

                if (user == null)
                    return null;

                return new UserModel(user);
            }
        }



        private List<UserModel> GetUserModels(List<User> users)
        {
            List<UserModel> userModels = new List<UserModel>();

            foreach (var user in users)
                userModels.Add(new UserModel(user));

            return userModels;
        }
    }
}
