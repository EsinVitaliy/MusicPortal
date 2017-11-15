using System;
using System.Collections.Generic;



namespace MusicPortalDAL.Intefaces
{
    interface IRepository<T> where T : class
    {
        List<T> GetAll();

        T Get(int id);

        List<T> Find(Func<T, Boolean> predicate);
    }
}
