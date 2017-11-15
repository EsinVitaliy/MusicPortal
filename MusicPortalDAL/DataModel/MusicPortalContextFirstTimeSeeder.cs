using System.Collections.Generic;
using System.Data.Entity;
using MusicPortalDAL.DataModel.Tables;



namespace MusicPortalDAL.DataModel
{
    public class MusicPortalContextFirstTimeSeeder : CreateDatabaseIfNotExists<MusicPortalContext>
    {
        protected override void Seed(MusicPortalContext context)
        {
            Album firstAlbum = new Album
            {
                Name = "Back for Good"
            };

            Album secondAlbum = new Album
            {
                Name = "Pandora's Box"
            };


            List<Album> albums = new List<Album>();
            albums.Add(firstAlbum);
            albums.Add(secondAlbum);

            context.Albums.AddRange(albums);


            User firstUser = new User
            {
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivanov@pisem.net",
                Albums = new List<Album>()
            };

            firstUser.Albums.Add(firstAlbum);


            User secondUser = new User
            {
                FirstName = "Петр",
                LastName = "Петров",
                Email = "petrov@gmail.com",
                Albums = albums
            };


            context.Users.Add(firstUser);
            context.Users.Add(secondUser);

            base.Seed(context);
        }
    }
}
