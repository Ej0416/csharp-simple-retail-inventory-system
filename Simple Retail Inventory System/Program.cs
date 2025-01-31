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
            //initialize inventory m,anager class to be access its functions locally
            InventoryManager inventoryManager = new InventoryManager();

            //initiate while loop for the programm process
            bool isLooping = true;
            //keyId use to assign unique id to itms in the dictionary
            int keyId = 0;
            while (isLooping == true)
            {
                //check if inventory is empty and display message or current inventory content
                if (inventoryManager.IsEmpty() == true)
                {
                    Console.WriteLine($"\n{Spaces('.', 40)}Inventory is curently empty{Spaces('.', 40)}");
                }
                else
                {
                    Console.WriteLine($"\n{Spaces('-', 40)}Inventory Content{Spaces('-', 40)}");
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
                            Console.WriteLine($"\n{Spaces('-', 40)}Adding Product Data{Spaces('-', 40)}\n");
                            inventoryManager.AddProduct(keyId, CreateProduct(keyId));
                            keyId += 1;
                            break;
                        // for editing product data
                        case 2:
                            Console.WriteLine($"\n{Spaces('-', 40)}Editing Product Data{Spaces('-', 40)}\n");
                            int.TryParse(UserInput("Enter Product id to edit: "), out int idToEdit);
                            inventoryManager.EditProduct(idToEdit);
                            break;
                        //for removing product data
                        case 3:
                            Console.WriteLine($"\n{Spaces('-', 40)}remove product data{Spaces('-', 40)}\n");
                            int.TryParse(UserInput("Enter Product id to remove: "), out int idToRemove);
                            inventoryManager.RemoveProduct(idToRemove);
                            break;
                        // for printing total value of products in inventory
                        case 4:
                            inventoryManager.TotalValue();
                            break;
                        //end programm trigger
                        default:
                            Console.WriteLine($"\n{Spaces('-', 40)}GOOD BYE{Spaces('-', 40)}");
                            isLooping = !options.Equals("5");
                            break;
                    }
                }
            }
        }

        // product data creation
        static Product CreateProduct(int id)
        {
            //initialized p[rodut class inorder to make an instace
            Product product = new Product();
            //catch exceprtion escpecially format exception
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
