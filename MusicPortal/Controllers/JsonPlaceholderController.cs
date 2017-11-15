using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MusicPortalBLL.Models.JsonPlaceholder;
using MusicPortalBLL.Services.ThirdParty;



namespace MusicPortal.Controllers
{
    public class JsonPlaceholderController : ApiController
    {
        // GET api/jsonplaceholder
        public async Task<List<Post>> GetAsync()
        {
            JsonPlaceholderService jsonService = new JsonPlaceholderService();

            try
            {
                var reply = await jsonService.GetPostsAsync();
                return reply;
            }
            catch (Exception ex)
            {
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
                throw new HttpResponseException(response);
            }
        }
    }
}
