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

        public DateTime date { get; set; }

        public ICollection<Cart> Carts { get; set; }
    }
}
