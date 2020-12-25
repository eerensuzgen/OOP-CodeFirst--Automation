using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace S_CupCoffee.Entity
{
    class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        //public DbSet<Cart> Carts { get; set; }

        //public DbSet<Table> Tables { get; set; }


    }
}
