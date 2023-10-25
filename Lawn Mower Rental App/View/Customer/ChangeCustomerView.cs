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
    public class ChangeCustomerView
    {
        private CustomerManager customerManager;
        public ChangeCustomerView()
        {
            customerManager = new CustomerManager();
        }
        public void ChangeCustomerMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteColoredText("|\t\t\t\t\t   CHANGE CUSTOMER TYPE MENU \t\t\t\t\t|", "CHANGE CUSTOMER TYPE MENU", ConsoleColor.Yellow);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t   01.- Change Customer Type by Customer ID \t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t   02.- Go back to Main Menu \t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|*******************************************************************************************************|");
                Console.WriteLine("Please enter your option of choice:");
                string option = HelperMethods.ReadLine();

                switch (option)
                {
                    case "1":
                        ChangeCustomerType();
                        break;
                    case "2":
                        return; // Go back to the main menu
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        public void ChangeCustomerType()
        {

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t   CHANGE CUSTOMER TYPE BY CUSTOMER ID \t\t\t\t\t|", "CHANGE CUSTOMER TYPE BY CUSTOMER ID", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t   Enter Customer ID: \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Enter the Customer ID:");
            string customerIdInput = HelperMethods.ReadLine();
            int customerId;

            while (!int.TryParse(customerIdInput, out customerId))
            {
                Console.WriteLine("Invalid input. Please enter a valid Customer ID:");
                customerIdInput = HelperMethods.ReadLine();
            }

            Customer customer;
            if (customerManager.TryFindCustomerById(customerId, out customer))
            {
                Console.WriteLine("Customer found. Do something with the customer...");
            }
            else
            {
                RentLawnMowerForm.CustomerNotFoundMessage(customerId);
            }

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("Customer Details:");
            Console.WriteLine("Customer ID: " + customer.CustomerId);
            Console.WriteLine("Name: " + customer.FirstName + " " + customer.LastName);
            Console.WriteLine("Address: " + customer.Address);
            Console.WriteLine("Contact Number: " + customer.ContactNumber);
            Console.WriteLine("Customer Type: " + (customer is BasicCustomer ? "Basic" : "Prime"));
            Console.WriteLine("|*******************************************************************************************************|");

            if (customer is BasicCustomer)
            {
                Console.WriteLine("1. Change to Prime Customer");
            }
            else if (customer is PrimeCustomer)
            {
                Console.WriteLine("2. Change to Basic Customer");
            }
            Console.WriteLine("3. Cancel and go back to Main Menu");

            Console.WriteLine("Please enter your choice:");

            string choice = HelperMethods.ReadLine();

            switch (choice)
            {
                case "1":
                    if (customer is BasicCustomer)
                    {
                        customerManager.ConvertBasicToPrime(customerId);
                        Console.WriteLine("Customer changed to Prime. Press any key to continue.");
                        HelperMethods.ReadLine();
                    }
                    break;
                case "2":
                    if (customer is PrimeCustomer)
                    {
                        customerManager.ConvertPrimeToBasic(customerId);
                        Console.WriteLine("Customer changed to Basic. Press any key to continue.");
                        HelperMethods.ReadLine();
                    }
                    break;
                case "3":
                    // Go back to the main menu
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue.");
                    HelperMethods.ReadLine();
                    break;
            }
        }
    }
}
