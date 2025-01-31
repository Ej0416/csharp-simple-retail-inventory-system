using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Retail_Inventory_System
{
    internal class Program : Utility
    {
        static void Main(string[] args)
        {
            //change the title of console window
            Console.Title = "Simple Retail Inventory System";
            InventoryManager inventoryManager = new InventoryManager();

            //initiate while loop for the programm process
            bool isLooping = true;
            int keyId = 0;
            while (isLooping == true)
            {
                //check if inventory is empty and display message or current inventory content
                if (inventoryManager.IsEmpty() == true)
                {
                    Console.WriteLine("\n...Inventory is curently empty...");
                }
                else
                {
                    Console.WriteLine($"\n{inventoryManager.Spaces('-', 40)}Inventory Content{inventoryManager.Spaces('-', 40)}");
                    inventoryManager.Show();
                }

                //user input selection
                string options = UserInput("\nSelect Options:\n  " +
                    "[1] - add product\n  " +
                    "[2] - edit product\n  " +
                    "[3] - remove product\n  " +
                    "[4] - get total value \n  " +
                    "[5] - exit " +
                    "\n\nEnter: ");

                bool isValid = int.TryParse(options, out int optionNum);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input please try again");
                }
                else
                {
                    //accessing functions base on user input via switch case
                    switch (optionNum)
                    {
                        //for adding product to inventory dictionary
                        case 1:
                            Console.WriteLine("\nadding product data\n");
                            inventoryManager.AddProduct(keyId, CreateProduct(keyId));
                            keyId += 1;
                            break;
                        // for editing product data
                        case 2:
                            Console.WriteLine("\nediting product data\n");
                            int.TryParse(UserInput("Enter Product id to edit: "), out int idToEdit);
                            inventoryManager.EditProduct(idToEdit);
                            break;
                        //for removing product data
                        case 3:
                            Console.WriteLine("\nremove product data\n");
                            int.TryParse(UserInput("Enter Product id to remove: "), out int idToRemove);
                            inventoryManager.RemoveProduct(idToRemove);
                            break;
                        // for printing total value of products in inventory
                        case 4:
                            Console.WriteLine("total inventory value");
                            inventoryManager.TotalValue();
                            break;
                        //end programm trigger
                        default:
                            Console.WriteLine("good bye");
                            isLooping = !options.Equals("5");
                            break;
                    }
                }
            }
        }

        // product data creation
        static Product CreateProduct(int id)
        {

            Product product = new Product();
            try
            {
                product.ProductId = id;
                product.ProductName = UserInput("Product name: ");
                product.ProductPrice = Convert.ToDouble(UserInput("Product price: "));
                product.ProductQuantity = Convert.ToInt32(UserInput("Product quantity: "));
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Invalid format input...");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e}");
            }
            return product;
        }

    }
}
