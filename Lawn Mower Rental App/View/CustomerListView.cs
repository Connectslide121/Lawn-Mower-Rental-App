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
                Console.WriteLine("|\t\t\t\t\t    CUSTOMER LIST \t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t---------------------------------------------\t\t\t\t\t|");

                if (customers.Count == 0)
                {
                    Console.WriteLine("|\t\t\tNo customers registered yet.\t\t\t|");
                }
                else
                {
                    foreach (var customer in customers)
                    {
                        Console.WriteLine($"|\t{customer}\t|");
                    }
                }

                Console.WriteLine("|\t\t\t-----------------------------------------------\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|*******************************************************************************************************|");
                Console.WriteLine();
                Console.WriteLine("Press any key to go back to the Main Menu");
                Console.ReadKey();
}

}

}
