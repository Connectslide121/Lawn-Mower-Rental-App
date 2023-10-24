using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Helper;
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
        public static void DisplaySearchResults(List<BasicCustomer> searchResults)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t  CUSTOMER SEARCH RESULTS \t\t\t\t\t|", "CUSTOMER SEARCH RESULTS", ConsoleColor.Yellow);
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
                    HelperMethods.WriteLineFitBox("|", customer.ToString(), "|", 103);
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