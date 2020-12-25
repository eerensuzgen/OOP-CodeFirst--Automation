using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee
{
    
    public class Cart
    {
        public List<Cart> cartList;
        public string productName;
        public string productPrice;
        public Cart(string pn,string pp)
        {
            productName = pn;
            productPrice = pp;
            cartList = new List<Cart>();
        }
        public override string ToString()
        {
            return productName + " ---- " + productPrice + "₺";
        }
        public void addCart(Cart cart)
        {
            cartList.Add(cart);
        }
        public void removeCart(int pos)
        {
            cartList.RemoveAt(pos);
        }
        public string getCart(int pos)
        {
            return cartList[pos].productPrice;
        }
        
        
    }
}
