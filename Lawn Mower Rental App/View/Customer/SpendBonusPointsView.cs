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
    public class SpendBonusPointsView
    {
        public void SpendBonusPointsForPrimeCustomer()
        {
            CustomerManager customerManager = new CustomerManager();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteColoredText("|\t\t\t\t\t SPEND BONUS POINTS FOR CUSTOMER \t\t\t\t|", "SPEND BONUS POINTS FOR CUSTOMER", ConsoleColor.Yellow);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t   Enter Customer ID: \t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|*******************************************************************************************************|");
                Console.WriteLine("Enter the Customer ID of the Prime Customer:");

                string customerIdInput = HelperMethods.ReadLine();
                int customerId;

                while (!int.TryParse(customerIdInput, out customerId))
                {
                    Console.WriteLine("ID not found. Please enter a valid Customer ID:");
                    customerIdInput = HelperMethods.ReadLine();
                }

                Customer customer;
                if (customerManager.TryFindCustomerById(customerId, out customer))
                {
                    if (customer is PrimeCustomer primeCustomer)
                    {
                        Console.Clear();
                        Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        HelperMethods.WriteColoredText("|\t\t\t\t\t SPEND BONUS POINTS FOR PRIME CUSTOMER \t\t\t\t|", "SPEND BONUS POINTS FOR PRIME CUSTOMER", ConsoleColor.Yellow);
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        HelperMethods.WriteLineFitBox("|\t\t\t\t\t   ", $"Customer Name: {primeCustomer.FirstName} {primeCustomer.LastName}", "|", 61);
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        HelperMethods.WriteLineFitBox("|\t\t\t\t\t   ", $"Current Bonus Points: {primeCustomer.BonusPoints}", "|", 61);
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        Console.WriteLine("|\t\t\t\t\t   Enter Points to Spend: \t\t\t\t\t|");
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        Console.WriteLine("|*******************************************************************************************************|");

                        string pointsToSpendInput = HelperMethods.ReadLine();
                        int pointsToSpend;

                        while (!int.TryParse(pointsToSpendInput, out pointsToSpend) || pointsToSpend <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number of points to spend:");
                            pointsToSpendInput = HelperMethods.ReadLine();
                        }
                        customerManager.WithdrawCustomerBonusPoints(customerId, pointsToSpend);

                        Console.Clear();
                        Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        HelperMethods.WriteColoredText("|\t\t\t\t\t SPEND BONUS POINTS FOR PRIME CUSTOMER \t\t\t\t|", "SPEND BONUS POINTS FOR PRIME CUSTOMER", ConsoleColor.Yellow);
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        HelperMethods.WriteLineFitBox("|\t\t\t\t\t   ", $"Customer Name: {primeCustomer.FirstName} {primeCustomer.LastName}", "|", 61);
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        HelperMethods.WriteLineFitBox("|\t\t\t\t\t   ", $"Current Bonus Points: {primeCustomer.BonusPoints}", "|", 61);
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        HelperMethods.WriteLineFitBox("|\t\t\t\t\t   ", $"{pointsToSpend} Points Spent Successfully!", "|", 61);
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                        Console.WriteLine("|*******************************************************************************************************|");

                        Console.WriteLine("Press any key to continue or 'X' to return to the main menu.");
                        string continueInput = HelperMethods.ReadLine();

                        if (continueInput.Equals("X", StringComparison.OrdinalIgnoreCase))
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Prime Customer not found.");
                        Console.WriteLine("Press any key to continue.");
                        HelperMethods.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Customer not found.");
                    Console.WriteLine("Press any key to continue.");
                    HelperMethods.ReadLine();
                }
            }
        }
    }
}

