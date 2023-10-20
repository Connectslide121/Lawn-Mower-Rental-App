using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class CustomerListView
    {
        public static void DisplayCustomerList(List<Customer> customers)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t    CUSTOMER LIST \t\t\t\t\t\t|", "CUSTOMER LIST", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t-----------------------------------------------\t\t\t\t\t|");

            if (customers.Count == 0)
            {
                Console.WriteLine("|\t\t\tNo customers registered yet.\t\t\t|");
            }
            else
            {
                foreach (Customer customer in customers)
                {
                    string line = customer.ToString();
                    int lineLength = 101;

                    if (line.Length < lineLength)
                    {
                        Console.Write("|  "); Console.Write(line.PadRight(lineLength)); Console.WriteLine("|");
                    }
                    else if (line.Length > lineLength)
                    {
                        Console.Write("|  "); Console.Write(line.Substring(0, lineLength)); Console.WriteLine("|");
                    }
                    else
                    {
                        Console.Write("|  "); Console.Write(line); Console.WriteLine("|");
                    }
                }
            }

            Console.WriteLine("|\t\t\t-----------------------------------------------\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
}
