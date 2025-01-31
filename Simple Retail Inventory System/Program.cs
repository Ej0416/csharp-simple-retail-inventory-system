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

            InventoryManager inventoryManager = new InventoryManager();
            int inventoryId = 0;
            bool isLooping = true;

            while (isLooping)
            {
               
                inventoryManager.AddProduct(inventoryId, CreateProduct(inventoryId));
            }

            inventoryManager.Show();
            Console.ReadLine();
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
        static string UserInput(string msg) {
            Console.Write(msg);
            string input = Console.ReadLine();
            return input;
        } 
    }
}
