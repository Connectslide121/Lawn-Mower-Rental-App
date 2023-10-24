using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Helper;
using Lawn_Mower_Rental_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CustomerListView
{
    public static void DisplayCustomerList(List<Customer> allCustomers)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      CUSTOMER LIST \t\t\t\t\t\t|", "CUSTOMER LIST", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");

            Console.WriteLine("Options:");
            Console.WriteLine("1 - View All Customers (Basic and Prime)");
            Console.WriteLine("2 - View All Basic Customers (Basic Only)");
            Console.WriteLine("3 - View All Prime Customers (Prime Only)");
            Console.WriteLine("4 - Go back to Main Menu");

            Console.Write("Enter the option number: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    DisplayCustomers(allCustomers);
                    break;
                case "2":
                    DisplayCustomers(allCustomers.Where(customer => customer is BasicCustomer).ToList());
                    break;
                case "3":
                    DisplayCustomers(allCustomers.Where(customer => customer is PrimeCustomer).ToList());
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void DisplayCustomers(List<Customer> customers)
    {
        Console.Clear();
        Console.WriteLine("Customer List:");

        if (customers.Count == 0)
        {
            Console.WriteLine("No customers registered yet.");
        }
        else
        {
            foreach (Customer customer in customers)
            {
                HelperMethods.WriteLineFitBox("|", customer.ToString(), "|", 103);
            }
        }

        Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
        Console.WriteLine("Press any key to go back to the menu");
        Console.ReadKey();
    }
}

