using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee.Entity
{
    class Admin
    {
        [Key]
        public int adminID { get; set; }

        public string userName { get; set; }
        public string password{ get; set; }
    }
}
