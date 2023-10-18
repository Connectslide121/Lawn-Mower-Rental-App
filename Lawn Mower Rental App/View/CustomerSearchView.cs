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
            Console.WriteLine("|\t\t\t\t\t    CUSTOMER SEARCH RESULTS \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t---------------------------------------------\t\t\t\t\t|");

            if (searchResults.Count == 0)
            {
                Console.WriteLine("|\t\t\tNo customers found matching the search query.\t\t\t|");
            }
            else
            {
                foreach (var customer in searchResults)
                {
                    Console.WriteLine($"|\t{customer}\t|");
                }
            }

            Console.WriteLine("|\t\t\t-----------------------------------------------\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_(); // This is about as far as i got, even with ChatGPT which im still new to using i had issues to get it to the MainMenu, rolled back to undo problems and code breaking.
        }
    }
}