using System;
using System.Collections.Generic;
using System.Linq;
using MusicPortalDAL.DataModel;
using MusicPortalDAL.DataModel.Tables;
using MusicPortalDAL.Intefaces;



namespace MusicPortalDAL.Repositories
{
    public class AlbumRepository : IRepository<Album>, IDisposable
    {
        private readonly MusicPortalContext _db;



        public AlbumRepository()
        {
            _db = new MusicPortalContext();
        }



        public List<Album> GetAll()
        {
            return _db.Albums.ToList();
        }



        public Album Get(int id)
        {
            return _db.Albums.FirstOrDefault(album => album.Id == id);
        }



        public List<Album> Find(Func<Album, bool> predicate)
        {
            return _db.Albums.Where(predicate).ToList();
        }



        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
