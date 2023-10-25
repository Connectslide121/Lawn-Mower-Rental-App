using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Helper;
using Lawn_Mower_Rental_App.Model;


namespace Lawn_Mower_Rental_App.View
{
    public class NewCustomerForm
    {
        public void NewCustomerForm_()
        {
            CustomerManager customerManager = new CustomerManager();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t First name: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Last name: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Contact number: \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Address: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Please enter first name:");
            string firstName = HelperMethods.ReadLine();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t First name: ", firstName, "|", 51);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Last name: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Contact number: \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Address: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Please enter last name:");
            string lastName = HelperMethods.ReadLine();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t First name: ", firstName, "|", 51);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Last name: ", lastName, "|", 52);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Contact Number: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Address: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Please enter contact number:");
            string contactNumberInput = HelperMethods.ReadLine();
            int contactNumber;

            while (!int.TryParse(contactNumberInput, out contactNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for contact number:");
                contactNumberInput = HelperMethods.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t First name: ", firstName, "|", 51);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Last name: ", lastName, "|", 52);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Contact number: ", contactNumberInput, "|", 47);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Address: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Please enter address:");
            string address = HelperMethods.ReadLine();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t First name: ", firstName, "|", 51);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Last name: ", lastName, "|", 52);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Contact number: ", contactNumberInput, "|", 47);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Address: ", address, "|", 54);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Please any key to validate:");
            Console.ReadKey();

            BasicCustomer basicCustomer = new BasicCustomer(customerManager.GetCustomerId());

            basicCustomer.FirstName = firstName;
            basicCustomer.LastName = lastName;
            basicCustomer.ContactNumber = contactNumber;
            basicCustomer.Address = address;

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t First name: ", firstName, "|", 51);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Last name: ", lastName, "|", 52);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Contact number: ", contactNumberInput, "|", 47);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Address: ", address, "|", 54);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t   Customer registered successfully!\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to Main Menu");
            Console.ReadKey();
        }

        public void CustomerExistsMessage(BasicCustomer basicCustomer)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t First name: ", basicCustomer.FirstName, "|", 51);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Last name: ", basicCustomer.LastName, "|", 52);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Contact number: ", basicCustomer.ContactNumber.ToString(), "|", 47);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Address: ", basicCustomer.Address, "|", 54);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\tCustomer already exists!\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }

        public void CustomerRegisteredMessage(BasicCustomer basicCustomer)
        {
            CustomerManager customerManager = new CustomerManager();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t First name: ", basicCustomer.FirstName, "|", 51);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Last name: ", basicCustomer.LastName, "|", 52);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Contact number: ", basicCustomer.ContactNumber.ToString(), "|", 47);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Address: ", basicCustomer.Address, "|", 54);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine($"|\t\t\t\t   Customer {basicCustomer.CustomerId} registered successfully!\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\tDoes the customer want an upgrade? (Y/N)\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");


            string userInput;

            do
            {
                Console.WriteLine("Please enter \"y\" or \"n\"");
                userInput = HelperMethods.ReadLine();
            }
            while (userInput.ToLower() != "y" && userInput.ToLower() != "n");

            if (userInput == "y")
            {
                customerManager.ConvertBasicToPrime(basicCustomer.CustomerId);

                Console.Clear();
                Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteLineFitBox("|\t\t\t\t\t First name: ", basicCustomer.FirstName, "|", 51);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteLineFitBox("|\t\t\t\t\t Last name: ", basicCustomer.LastName, "|", 52);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteLineFitBox("|\t\t\t\t\t Contact number: ", basicCustomer.ContactNumber.ToString(), "|", 47);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteLineFitBox("|\t\t\t\t\t Address: ", basicCustomer.Address, "|", 54);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine($"|\t\t\t\t   Customer {basicCustomer.CustomerId} registered successfully!\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\tCustomer upgraded successfully!\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|*******************************************************************************************************|");
                Console.WriteLine("Press any key to go back to Main Menu");
                Console.ReadKey();
                MainMenu.MainMenu_();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteLineFitBox("|\t\t\t\t\t First name: ", basicCustomer.FirstName, "|", 51);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteLineFitBox("|\t\t\t\t\t Last name: ", basicCustomer.LastName, "|", 52);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteLineFitBox("|\t\t\t\t\t Contact number: ", basicCustomer.ContactNumber.ToString(), "|", 47);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteLineFitBox("|\t\t\t\t\t Address: ", basicCustomer.Address, "|", 54);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine($"|\t\t\t\t   Customer {basicCustomer.CustomerId} registered successfully!\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\tMaybe next time!\t\t\t\t\t\t\t\t|");
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
