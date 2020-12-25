using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee.Entity
{
    class Table
    {
        [Key]
        public int tableID { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
