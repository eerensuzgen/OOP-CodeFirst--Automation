using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace S_CupCoffee
{
    public class Cash:Pay
    {
        public override string payPrice()
        {
            return "Nakit olarak ödeme tamamlandı";
        }
    }
}
