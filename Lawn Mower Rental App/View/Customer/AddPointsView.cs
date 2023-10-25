using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AddPointsView
{
    public static void AddPointsMenu(CustomerManager customerManager)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t\t    ADD POINTS/DISCOUNTS MENU \t\t\t\t\t|", "ADD POINTS/DISCOUNTS MENU", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 1.- Add Discounts to a Basic Customer \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 2.- Add Points to a Prime Customer \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 3.- Return to Main Menu \t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("Please enter your option of choice:");
            string option = HelperMethods.ReadLine();

            switch (option)
            {
                case "1":
                    AddDiscountsToBasicCustomer(customerManager);
                    break;
                case "2":
                    AddPointsToPrimeCustomer(customerManager);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public static void AddDiscountsToBasicCustomer(CustomerManager customerManager)
    {
        Console.Clear();
        Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
        HelperMethods.WriteColoredText("|\t\t\t\t\t\t   ADD DISCOUNTS TO BASIC CUSTOMER \t\t\t\t\t|", "ADD DISCOUNTS TO BASIC CUSTOMER", ConsoleColor.Yellow);
        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
        Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
        Console.WriteLine("Enter the Customer ID of the Basic Customer:");
        int customerId;
        while (!int.TryParse(HelperMethods.ReadLine(), out customerId))
        {
            Console.WriteLine("ID not found. Please enter a valid Customer ID:");
        }

        Console.WriteLine("Enter the number of discounts to add:");
        int discountsToAdd;
        while (!int.TryParse(HelperMethods.ReadLine(), out discountsToAdd))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for discounts:");
        }

        customerManager.AddDiscountsToBasicCustomer(customerId, discountsToAdd);

        Console.WriteLine($"Discounts added to Basic Customer (ID: {customerId}).");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    public static void AddPointsToPrimeCustomer(CustomerManager customerManager)
    {
        Console.Clear();
        Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
        HelperMethods.WriteColoredText("|\t\t\t\t\t\t    ADD POINTS TO PRIME CUSTOMER \t\t\t\t\t|", "ADD POINTS TO PRIME CUSTOMER", ConsoleColor.Yellow);
        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
        Console.WriteLine("|\t\t\t   -----------------------------------------------\t\t\t\t|");
        Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
        Console.WriteLine("Enter the Customer ID of the Prime Customer:");
        int customerId;
        while (!int.TryParse(HelperMethods.ReadLine(), out customerId))
        {
            Console.WriteLine("ID not found. Please enter a valid Customer ID:");
        }

        Console.WriteLine("Enter the number of points to add:");
        int pointsToAdd;
        while (!int.TryParse(HelperMethods.ReadLine(), out pointsToAdd))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for points:");
        }

        customerManager.AddBonusPointsToPrimeCustomer(customerId, pointsToAdd);

        Console.WriteLine($"Points added to Prime Customer (ID: {customerId}).");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

}

