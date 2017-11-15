using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MusicPortalDAL.DataModel.Tables
{
    public class Album
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [Column(TypeName = "nvarchar"), MaxLength(256)]
        public string Name { get; set; }


        public virtual ICollection<User> Users { get; set; }
    }
}
