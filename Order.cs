using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee
{
    
    public class Order
    {
        public List<Order> cartList;
        public int tableId;
        public string productName;
        public string productPrice;
        public Order()
        {
            cartList = new List<Order>();
        }
        public Order(string pn,string pp)
        {
            productName = pn;
            productPrice = pp;
            tableId = 0;
            cartList = new List<Order>();
        }
        public Order(string pn,string pp,int tId)
        {
            productName = pn;
            productPrice = pp;
            tableId = tId;
            cartList = new List<Order>();
        }
        public override string ToString()
        {
            return productName + " ---- " + productPrice + "₺";
        }
        public void AddCart(Order cart)
        {
            cartList.Add(cart);          
        }
        public void RemoveCart(int pos)
        {
            cartList.RemoveAt(pos);
        }
        public string GetCart(int pos)
        {
            return cartList[pos].productPrice;
        } 
    }
}
