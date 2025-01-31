using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Retail_Inventory_System
{
    internal class InventoryManager
    {
        Dictionary<int, Product> inventory= new Dictionary<int, Product>();

        public void AddProduct(int id,Product product) {
            inventory.Add(id,product);
        }

        public void Show() {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"\n{inventory[i]}\n");
            }
        }
    }
}
