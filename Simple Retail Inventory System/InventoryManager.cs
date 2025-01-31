using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Retail_Inventory_System
{
    internal class InventoryManager : Utility
    {
        //set to readonly and private to prevent accidental changes to the dictionary
        private readonly Dictionary<int, Product> inventory = new Dictionary<int, Product>();

        //function for adding product to inventory
        public void AddProduct(int id, Product product)
        {
            inventory.Add(id, product);
        }

        //print curent conent of inventory
        public void Show()
        {
            Console.WriteLine($"\n{Spaces(' ', 5)}Product id{Spaces(' ', 10)}" +
                $"Product name{Spaces(' ', 15)}Product price{Spaces(' ', 10)}" +
                $"Product quantity");

            Console.WriteLine(Spaces('-', 98));
          
            //iterate over our dictionary to print its data content
            foreach (var item in inventory)
            {
                Console.WriteLine($"{Spaces(' ', 10)}{item.Value.ProductId}" +
                    $"{Spaces(' ', 18)}{item.Value.ProductName}" +
                    $"{Spaces(' ', 22)}$ {item.Value.ProductPrice}" +
                    $"{Spaces(' ', 22)}{item.Value.ProductQuantity}{Spaces(' ', 10)}");
            }

        }

        //function to edit product data in inventory
        public void EditProduct(int id)
        {
            if (inventory.ContainsKey(id))
            {

                try
                {
                    inventory[id].ProductName = UserInput("New product name: ");
                    inventory[id].ProductPrice = Convert.ToDouble(UserInput("New product price: "));
                    inventory[id].ProductQuantity = Convert.ToInt32(UserInput("New product quantity: "));

                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError: Invalid format input...");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\nError: {e}");
                }
            }
            else
            {
                Console.WriteLine("No product found associated with given id.");
            }
        }

        //function to remove product data in inventory
        public void RemoveProduct(int id)
        {
            if (inventory.ContainsKey(id))
            {
                inventory.Remove(id);
                Console.WriteLine("Product remove from inventory");
            }
            else
            {
                Console.WriteLine("No product found associated with given id.");
            }
        }

        //check if inventory have contents
        public bool IsEmpty()
        {
            bool isEmpty = inventory.Count() == 0;
            return isEmpty;
        }
    }
}
