using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee
{
    class CreditCard:Pay
    {
        public override string payPrice()
        {
            return "Kredi kartı ile ödeme tamamlandı";
        }
    }
}
