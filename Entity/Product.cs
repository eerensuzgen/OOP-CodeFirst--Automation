using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee.Entity
{
    class Product
    {
        [Key]
        public int productID { get; set; }

        public int categoryID { get; set; }

        public string productName { get; set; }

        public double unitPrice { get; set; }

        public Category Category { get; set; }
    }
}
