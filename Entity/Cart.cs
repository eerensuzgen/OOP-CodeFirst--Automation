using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee.Entity
{
    class Cart
    {
        [Key]
        public int cartID { get; set; }

        public int tableID { get; set; }

        public int productID { get; set; }

        public Table Table { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
