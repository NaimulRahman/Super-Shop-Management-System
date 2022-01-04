using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Shop_Management_System
{
    class ProductReciept
    {
        public string Name{ get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float totalPrice { get; set; }
        public ProductReciept(string name,int quantity,float price,float totalPrice)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.totalPrice = totalPrice;
        }
    }
}
