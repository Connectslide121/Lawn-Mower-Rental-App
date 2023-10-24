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
    public class CustomerListView
    {
        public static void DisplayCustomerList(List<BasicCustomer> basicCustomers)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      CUSTOMER LIST \t\t\t\t\t\t|", "CUSTOMER LIST", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");

            if (basicCustomers.Count == 0)
            {
                Console.WriteLine("|\t\t\tNo customers registered yet.\t\t\t|");
            }
            else
            {
                foreach (Customer customer in basicCustomers)
                {
                    HelperMethods.WriteLineFitBox("|", customer.ToString(), "|", 103);
                }
            }

            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
}
