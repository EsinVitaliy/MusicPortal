using System.Data.Entity;
using MusicPortalDAL.DataModel.Tables;



namespace MusicPortalDAL.DataModel
{
    public class MusicPortalContext : DbContext
    {
        public MusicPortalContext()
            : base("name=DatabaseConnection")
        {
            Database.SetInitializer(new MusicPortalContextFirstTimeSeeder());
        }



        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
    }
}
