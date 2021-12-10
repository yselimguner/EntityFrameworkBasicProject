using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.DAL.ORM.Entity
{
    public class Product:BaseEntity
    {
        public decimal? UnitPrice { get; set; }
        public short? UnitsinStock { get; set; }
        [MaxLength(500)]
        public string Quantity { get; set; }
    }
}
