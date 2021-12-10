using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.DAL.ORM.Entity
{
    [Table("Users")]
    public class AppUser:BaseEntity
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool Gender { get; set; }
        public string FullName { get; set; }

    }
}
