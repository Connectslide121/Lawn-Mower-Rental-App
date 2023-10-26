using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Helper;
using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class CustomerListView
    {
        public static void DisplayCustomerList(List<BasicCustomer> basicCustomers, List<PrimeCustomer> primeCustomers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteColoredText("|\t\t\t\t\t      CUSTOMER LIST \t\t\t\t\t\t|", "CUSTOMER LIST", ConsoleColor.Yellow);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t      -----------------------------------------------\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t 01.- View all customers (Basic and Prime) \t\t\t\t|");
                Console.WriteLine("|\t\t\t\t 02.- View all basic customers (Basic only) \t\t\t\t|");
                Console.WriteLine("|\t\t\t\t 03.- View all prime customers (Prime only) \t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t      -----------------------------------------------\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|*******************************************************************************************************|");
                Console.WriteLine("Please enter your option of choice:");
                string option = HelperMethods.ReadLine();

                switch (option)
                {
                    case "1":
                        DisplayAllCustomers(basicCustomers, primeCustomers);
                        break;
                    case "2":
                        DisplayBasicCustomers(basicCustomers);
                        break;
                    case "3":
                        DisplayPrimeCustomers(primeCustomers);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        public static void DisplayAllCustomers(List<BasicCustomer> basicCustomers, List<PrimeCustomer> primeCustomers)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      CUSTOMER LIST \t\t\t\t\t\t|", "CUSTOMER LIST", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            if (basicCustomers.Count == 0 && primeCustomers.Count == 0)
            {
                Console.WriteLine("|\t\t\t\t\tNo customers registered yet.\t\t\t\t|");
            }
            else
            {
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

                if (basicCustomers.Count > 0)
                {
                    HelperMethods.WriteColoredText("|\t\t\t\t\t      BASIC CUSTOMERS (DISCOUNTS)\t\t\t\t\t\t|", "BASIC CUSTOMERS", ConsoleColor.DarkYellow);
                    Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

                    foreach (BasicCustomer customer in basicCustomers)
                    {
                        HelperMethods.WriteLineFitBox("|", customer.ToString(), "|", 103);
                    }
                }

                if (primeCustomers.Count > 0)
                {
                    HelperMethods.WriteColoredText("|\t\t\t\t\t      PRIME CUSTOMERS (BONUS POINTS)\t\t\t\t\t\t|", "PRIME CUSTOMERS", ConsoleColor.DarkYellow);
                    Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

                    foreach (PrimeCustomer customer in primeCustomers)
                    {
                        string customerInfo = customer.ToString();
                        if (customerInfo.Contains("Discounts"))
                        {
                            customerInfo = customerInfo.Replace("Discounts", "Bonus Points");
                        }
                        HelperMethods.WriteLineFitBox("|", customerInfo, "|", 103);
                    }
                }
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu.");
            HelperMethods.ReadLine();
            MainMenu.MainMenu_();
        }


        public static void DisplayBasicCustomers(List<BasicCustomer> basicCustomers)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      CUSTOMER LIST \t\t\t\t\t\t|", "CUSTOMER LIST", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      BASIC CUSTOMERS \t\t\t\t\t\t|", "BASIC CUSTOMERS", ConsoleColor.DarkYellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            if (basicCustomers.Count == 0)
            {
                Console.WriteLine("|\t\t\t\t\tNo basic customers registered yet.\t\t\t\t|");
            }
            else
            {
                foreach (Customer customer in basicCustomers)
                {
                    HelperMethods.WriteLineFitBox("|", customer.ToString(), "|", 103);
                }
            }
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu.");
            HelperMethods.ReadLine();
            MainMenu.MainMenu_();

        }

        public static void DisplayPrimeCustomers(List<PrimeCustomer> primeCustomers)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      CUSTOMER LIST \t\t\t\t\t\t|", "CUSTOMER LIST", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      PRIME CUSTOMERS \t\t\t\t\t\t|", "PRIME CUSTOMERS", ConsoleColor.DarkYellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            if (primeCustomers.Count == 0)
            {
                Console.WriteLine("|\t\t\t\t\tNo prime customers registered yet.\t\t\t\t|");
            }
            else
            {
                foreach (Customer customer in primeCustomers)
                {
                    HelperMethods.WriteLineFitBox("|", customer.ToString().Replace("Discounts", "Bonus Points"), "|", 103);
                }
            }
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu.");
            HelperMethods.ReadLine();
            MainMenu.MainMenu_();
        }
    }
}

