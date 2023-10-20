﻿using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class DeleteCustomerForm
    {
        public void DeleteCustomerForm_() 
        {
            CustomerManager customerManager = new CustomerManager();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t     DELETE CUSTOMER \t\t\t\t\t\t|", "DELETE CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t First name: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Last name: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Customer ID: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Please enter first name:");
            string firstName = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t     DELETE CUSTOMER \t\t\t\t\t\t|", "DELETE CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            int lineLengthFirstName = 50;

            if (firstName.Length < lineLengthFirstName)
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName.PadRight(lineLengthFirstName)); Console.WriteLine(" |");
            }
            else if (firstName.Length > lineLengthFirstName)
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName.Substring(0, lineLengthFirstName)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Last name: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Customer ID: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Please enter last name:");
            string lastName = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t     DELETE CUSTOMER \t\t\t\t\t\t|", "DELETE CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            if (firstName.Length < lineLengthFirstName)
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName.PadRight(lineLengthFirstName)); Console.WriteLine(" |");
            }
            else if (firstName.Length > lineLengthFirstName)
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName.Substring(0, lineLengthFirstName)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            int lineLengthLastName = 51;

            if (lastName.Length < lineLengthLastName)
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName.PadRight(lineLengthLastName)); Console.WriteLine(" |");
            }
            else if (lastName.Length > lineLengthLastName)
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName.Substring(0, lineLengthLastName)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Customer ID: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");

            string customerID;
            int customerIDInt;

            do
            {
                Console.WriteLine("Please enter customer ID:");
                customerID = Console.ReadLine();
            }
            while (!int.TryParse(customerID, out customerIDInt));

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t     DELETE CUSTOMER \t\t\t\t\t\t|", "DELETE CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            
            if (firstName.Length < lineLengthFirstName)
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName.PadRight(lineLengthFirstName)); Console.WriteLine(" |");
            }
            else if (firstName.Length > lineLengthFirstName)
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName.Substring(0, lineLengthFirstName)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            if (lastName.Length < lineLengthLastName)
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName.PadRight(lineLengthLastName)); Console.WriteLine(" |");
            }
            else if (lastName.Length > lineLengthLastName)
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName.Substring(0, lineLengthLastName)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine($"|\t\t\t\t\t Customer ID: {customerIDInt}\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t WARNING! Customer will be deleted!\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t    Press any key to continue \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.ReadKey();

            customerManager.DeleteCustomer(firstName, lastName, customerIDInt);

        }


        public void CustomerDeletedMessage(string firstName, string lastName, int customerID)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t     DELETE CUSTOMER \t\t\t\t\t\t|", "DELETE CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            int lineLengthFirstName = 50;

            if (firstName.Length < lineLengthFirstName)
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName.PadRight(lineLengthFirstName)); Console.WriteLine(" |");
            }
            else if (firstName.Length > lineLengthFirstName)
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName.Substring(0, lineLengthFirstName)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName); Console.WriteLine("|");
            }
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            int lineLengthLastName = 51;

            if (lastName.Length < lineLengthLastName)
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName.PadRight(lineLengthLastName)); Console.WriteLine(" |");
            }
            else if (lastName.Length > lineLengthLastName)
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName.Substring(0, lineLengthLastName)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine($"|\t\t\t\t\t Customer ID: {customerID}\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t   Customer deleted successfully!\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }

        public void CustomerNotFoundMessage(string firstName, string lastName, int customerID)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t     DELETE CUSTOMER \t\t\t\t\t\t|", "DELETE CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            int lineLengthFirstName = 50;

            if (firstName.Length < lineLengthFirstName)
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName.PadRight(lineLengthFirstName)); Console.WriteLine(" |");
            }
            else if (firstName.Length > lineLengthFirstName)
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName.Substring(0, lineLengthFirstName)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t First name: "); Console.Write(firstName); Console.WriteLine("|");
            }
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            int lineLengthLastName = 51;

            if (lastName.Length < lineLengthLastName)
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName.PadRight(lineLengthLastName)); Console.WriteLine(" |");
            }
            else if (lastName.Length > lineLengthLastName)
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName.Substring(0, lineLengthLastName)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Last name: "); Console.Write(lastName); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine($"|\t\t\t\t\t Customer ID: {customerID}\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Customer not found\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();


        }
    }
}
