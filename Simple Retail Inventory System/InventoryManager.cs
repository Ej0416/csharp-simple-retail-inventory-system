using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Retail_Inventory_System
{
    internal class InventoryManager:Utility
    {
        //set to readonly and private to prevent accidental changes to the dictionary
        private readonly Dictionary<int, Product> inventory = new Dictionary<int, Product>();

        //function for adding product to inventory
        public void AddProduct(int id,Product product) {
            inventory.Add(id,product);
        }

        //print curent conent of inventory
        public void Show() {
            Console.WriteLine($"\n{Spaces(' ',5)}Product id{Spaces(' ', 10)}" +
                $"Product name{Spaces(' ', 15)}Product price{Spaces(' ', 10)}" +
                $"Product quantity");
            
            Console.WriteLine(Spaces('-', 98));
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{Spaces(' ',10)}{inventory[i].ProductId}" +
                    $"{Spaces(' ', 18)}{inventory[i].ProductName}" +
                    $"{Spaces(' ', 22)}$ {inventory[i].ProductPrice}" +
                    $"{Spaces(' ', 22)}{inventory[i].ProductQuantity}{Spaces(' ', 10)}");
            } 
        }

        //function to edit product data in inventory
        public void EditProduct(int id) {
            if (inventory.ContainsKey(id)) { 
                
            } else {
                Console.WriteLine("No product found associated with given id.");
            }
        }

        //check if inventory have contents
        public bool IsEmpty() {
            bool isEmpty = inventory.Count() == 0;
            return isEmpty;
        }
    }
}
