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
        public void SearchCustomers()
        {
            CustomerManager customerManager = new CustomerManager();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      SEARCH CUSTOMERS \t\t\t\t\t\t|", "SEARCH CUSTOMERS", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Please enter search query\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            string searchQuery = HelperMethods.ReadLine();

            customerManager.SearchCustomers(searchQuery);



        }

        public static void DisplaySearchResult(List<BasicCustomer> basicCustomers, List<PrimeCustomer> primeCustomers)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      SEARCH CUSTOMERS \t\t\t\t\t\t|", "SEARCH CUSTOMERS", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            if (basicCustomers.Count == 0 && primeCustomers.Count == 0)
            {
                Console.WriteLine("|\t\t\t\t\tNo customers registered yet.\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|*******************************************************************************************************|");
                Console.WriteLine("Press any key to go back to Main Menu");
                Console.ReadKey();
                MainMenu.MainMenu_();
            }
            else
            {
                HelperMethods.WriteColoredText("|\t\t\t\t\t      BASIC CUSTOMERS \t\t\t\t\t\t|", "BASIC CUSTOMERS", ConsoleColor.DarkYellow);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

                    foreach (Customer customer in basicCustomers)
                    {
                        HelperMethods.WriteLineFitBox("|", customer.ToString(), "|", 103);
                    }

                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteColoredText("|\t\t\t\t\t      PRIME CUSTOMERS \t\t\t\t\t\t|", "PRIME CUSTOMERS", ConsoleColor.DarkYellow);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

                    foreach (Customer customer in primeCustomers)
                    {
                        HelperMethods.WriteLineFitBox("|", customer.ToString(), "|", 103);
                    }

                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|*******************************************************************************************************|");
                Console.WriteLine("Press any key to go back to Main Menu");
                Console.ReadKey();
                MainMenu.MainMenu_();
            }
        }
    }
}
