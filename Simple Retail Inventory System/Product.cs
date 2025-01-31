using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Retail_Inventory_System
{
    internal class Product
    {
        //setting the class attributes
        private int id;
        private string name;
        private int quantity;
        private double price;

        //empty constructor
        public Product() { }

        //setting up the class properties for getters and setters
        public int ProductId
        {
            get { return id; }
            set { id = value; }
        }

        public string ProductName
        {
            get { return name; }
            set { name = value; }
        }

        public int ProductQuantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double ProductPrice
        {
            get { return price; }
            set { price = value; }
        }

        //print all atttributes for testing purpose
        public override string ToString() {
            return $"Product id: {id}\nProduct name: {name}\nProduct quantity: {quantity}\nProduct price: {price}";
        }

    }
}
