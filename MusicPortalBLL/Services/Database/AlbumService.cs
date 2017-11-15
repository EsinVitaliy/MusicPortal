using System.Collections.Generic;
using System.Linq;
using MusicPortalBLL.Models.Database;
using MusicPortalDAL.DataModel.Tables;
using MusicPortalDAL.Repositories;



namespace MusicPortalBLL.Services.Database
{
    public class AlbumService
    {
        public List<AlbumModel> GetAlbums()
        {
            using (AlbumRepository albumRepository = new AlbumRepository())
            {
                var albums = albumRepository.GetAll();
                return GetAlbumModels(albums);
            }
        }



        public AlbumModel GetAlbum(int albumId)
        {
            using (AlbumRepository albumRepository = new AlbumRepository())
            {
                var album = albumRepository.Get(albumId);

                if (album == null)
                    return null;

                return new AlbumModel(album);
            }
        }



        public List<AlbumModel> GetUserAlbums(int userId)
        {
            using (AlbumRepository albumRepository = new AlbumRepository())
            {
                var albums = albumRepository.Find(album => album.Users.Any(user => user.Id == userId));
                return GetAlbumModels(albums);
            }
        }



        private List<AlbumModel> GetAlbumModels(List<Album> albums)
        {
            List<AlbumModel> albumModels = new List<AlbumModel>();

            foreach (var album in albums)
                albumModels.Add(new AlbumModel(album));

            return albumModels;
        }
    }
}
