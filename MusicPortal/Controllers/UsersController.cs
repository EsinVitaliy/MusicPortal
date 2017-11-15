using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MusicPortal.Security;
using MusicPortalBLL.Models.Database;
using MusicPortalBLL.Services.Database;



namespace MusicPortal.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/users
        public IEnumerable<UserModel> Get()
        {
            var userService = new UserService();
            return userService.GetUsers();
        }



        // GET api/users/{id}
        public UserModel Get(int id)
        {
            var userService = new UserService();
            var userModel = userService.GetUser(id);

            if (userModel == null)
            {
                var response = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent($"No user with Id = {id}"),
                    ReasonPhrase = "User Id not found"

                };
                throw new HttpResponseException(response);
            }

            TripleDES tripleDes = new TripleDES();
            userModel.Email = tripleDes.Encrypt(userModel.Email, userModel.LastName);
            return userModel;
        }
    }
}
