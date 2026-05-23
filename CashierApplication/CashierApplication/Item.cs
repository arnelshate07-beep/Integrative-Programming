using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string item_name, double price, int quantity)
        {
            this.item_name = item_name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public virtual double GetTotalPrice()
        {
            total_price = item_price * item_quantity;
            return total_price;
        }

        public virtual void setPayment(double amount)
        {

        }
    }
}
