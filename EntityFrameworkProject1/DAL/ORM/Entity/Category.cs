using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.DAL.ORM.Entity
{
    public class Category:BaseEntity
    {
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
