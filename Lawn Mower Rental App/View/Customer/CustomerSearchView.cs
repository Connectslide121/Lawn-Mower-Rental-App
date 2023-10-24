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
        public void SearchCustomers(CustomerType customerType)
        {
            CustomerManager customerManager = new CustomerManager();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      SEARCH CUSTOMERS \t\t\t\t\t\t|", "SEARCH CUSTOMERS", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Enter search query:");
            string searchQuery = HelperMethods.ReadLine();

            List<Customer> searchResults = customerManager.SearchCustomers(searchQuery, customerType);

            if (searchResults.Count == 0)
            {
                Console.WriteLine("No customers found matching the search criteria.");
            }
            else
            {
                Console.WriteLine("Search results:");
                CustomerListView.DisplayCustomerList(searchResults);
            }

            Console.WriteLine("Press any key to go back to Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
}
