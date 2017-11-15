using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MusicPortalBLL.Models.Database;
using MusicPortalBLL.Services.Database;



namespace MusicPortal.Controllers
{
    public class AlbumsController : ApiController
    {
        // GET api/albums
        public IEnumerable<AlbumModel> Get()
        {
            var albumService = new AlbumService();
            return albumService.GetAlbums();
        }



        // GET api/albums/{id}
        public AlbumModel Get(int id)
        {
            var albumService = new AlbumService();

            var albumModel = albumService.GetAlbum(id);

            if (albumModel == null)
            {
                var response = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent($"No album with Id = {id}"),
                    ReasonPhrase = "Album Id not found"

                };
                throw new HttpResponseException(response);
            }

            return albumModel;
        }



        // GET api/albums/user/{userId}
        [Route("api/albums/user/{userId}")]
        public List<AlbumModel> GetUserAlbums(int userId)
        {
            var albumService = new AlbumService();
            return albumService.GetUserAlbums(userId);
        }
    }
}
