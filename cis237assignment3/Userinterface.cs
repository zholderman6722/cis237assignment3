using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Userinterface
    {
        public Userinterface()
        {
            
        }
    
        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to Droid Builder! What would you like to do?");
            Console.WriteLine("1. Build a New Droid" +Environment.NewLine + "2: Print List of Droids" + Environment.NewLine + "3: Exit");
            string MenuChoice = Console.ReadLine().Trim();
            Console.WriteLine();
            
            switch (MenuChoice)
            {
                case "1":
                    Console.WriteLine("what material will you be using? Please Indicate by choosing the corresponding integer 1, 2 or 3.");
                    Console.WriteLine("1: Titanium" + Environment.NewLine + "2: Steel" + Environment.NewLine + "3: Iron" + Environment.NewLine);
                    String material = Console.ReadLine();
                     
                    
                    Console.WriteLine("What model will you be using? Please indicate by choosing the corresponding integer 1, 2 or 3.");
                    String model = Console.ReadLine();
                    Console.WriteLine("What color would you like your droid to be? Current options are: " + Environment.NewLine + "1: Gold" + Environment.NewLine + "2: Silver" + Environment.NewLine + "3: Bronze:");
                    String color = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Printing droid List...");
                    break;
                case "3":
                    Console.WriteLine("Good Bye!");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

        }
    }
}
