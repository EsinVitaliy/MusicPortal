using System;
using System.Collections.Generic;
using System.Linq;
using MusicPortalDAL.DataModel;
using MusicPortalDAL.DataModel.Tables;
using MusicPortalDAL.Intefaces;


namespace MusicPortalDAL.Repositories
{
    public class UserRepository : IRepository<User>, IDisposable
    {
        private readonly MusicPortalContext _db;



        public UserRepository()
        {
            _db = new MusicPortalContext();
        }



        public List<User> GetAll()
        {
            return _db.Users.ToList();
        }



        public User Get(int id)
        {
            return _db.Users.FirstOrDefault(user => user.Id == id);
        }



        public List<User> Find(Func<User, bool> predicate)
        {
            return _db.Users.Where(predicate).ToList();
        }



        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
