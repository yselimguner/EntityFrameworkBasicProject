using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.DAL.ORM.Entity
{
    public class BaseEntity
    {
        [Key]
        [Column(Order =1)]
        public int Id { get; set; }
        [Column (Order =2)]
        public string Name { get; set; }
        [Column(Order =3)]
        public DateTime? Added_Date { get; set; }
        public bool isActive { get; set; }
    }
}
