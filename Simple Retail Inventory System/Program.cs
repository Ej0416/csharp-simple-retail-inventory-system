using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Retail_Inventory_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = CreateProduct();
            Console.WriteLine(product);

            Console.ReadLine();
        }

        // product data creation
        static Product CreateProduct()
        {
            Product product = new Product
            {
                ProductId = 1,
                ProductName = "Test",
                ProductPrice = 10,
                ProductQuantity = 100,
            };
            return product;
        }
    }
}
