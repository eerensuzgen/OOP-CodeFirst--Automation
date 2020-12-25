using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee
{
    class PersonelSale:ISale
    {
        public decimal SalePrice(decimal price)
        {
            return price * 0.7M;
        }
    }
}
