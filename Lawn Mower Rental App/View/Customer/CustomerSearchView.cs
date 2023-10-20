using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class CustomerSearchView
    {
        public static void DisplaySearchResults(List<Customer> searchResults)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t  CUSTOMER SEARCH RESULTS \t\t\t\t\t|", "CUSTOMER SEARCH RESULTS", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");

            if (searchResults.Count == 0)
            {
                Console.WriteLine("|\t\t\t\t\tNo customer(s) found.\t\t\t\t\t\t|");
            }
            else
            {
                foreach (var customer in searchResults)
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

            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_(); 
        }
    }
}