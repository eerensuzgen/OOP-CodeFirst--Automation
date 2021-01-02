using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee.Entity
{
    class Category
    {
        [Key]
        public int categoryID { get; set; }

        public string categoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
