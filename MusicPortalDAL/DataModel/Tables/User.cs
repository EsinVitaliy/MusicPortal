using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MusicPortalDAL.DataModel.Tables
{
    public class User
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [Column(TypeName = "nvarchar"), MaxLength(256)]
        public string LastName { get; set; }


        [Required]
        [Column(TypeName = "nvarchar"), MaxLength(256)]
        public string FirstName { get; set; }


        [Required]
        [Column(TypeName = "nvarchar"), MaxLength(256)]
        public string Email { get; set; }


        public virtual ICollection<Album> Albums { get; set; }
    }
}
