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
            Console.Title = "Simple Retail Inventory System";
            bool isLooping = true;
            while (isLooping == true)
            {
                string options = UserInput("\nSelect Options:\n  " +
                    "[0] - view inventory\n  " +
                    "[1] - add product\n  " +
                    "[2] - edit product\n  " +
                    "[3] - remove product\n  " +
                    "[4] - get total value \n  " +
                    "[5] - exit " +
                    "\n\nEnter: ");

                isLooping = options.Equals("5") ? false : true;
            }
        }

        // product data creation
        static Product CreateProduct(int id)
        {
            Product product = new Product
            {
                ProductId = id,
                ProductName = "Test",
                ProductPrice = 10,
                ProductQuantity = 100,
            };
            return product;
        }

        //helper function for getting user input
        static string UserInput(string msg = default) {
            Console.Write(msg);
            string input = Console.ReadLine();
            return input;
        } 
    }
}
