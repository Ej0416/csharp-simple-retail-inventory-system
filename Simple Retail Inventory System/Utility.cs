using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Retail_Inventory_System
{
    internal class Utility
    {
        //helper function for getting user input
        public static string UserInput(string msg = default)
        {
            Console.Write(msg);
            string input = Console.ReadLine();
            return input;
        }

        //helper function to add  lines
        public string Spaces(char content, int count)
        {
            string space = new string(content, count);
            return space;
        }
    }
}
