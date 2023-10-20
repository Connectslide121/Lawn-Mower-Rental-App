using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;


namespace Lawn_Mower_Rental_App.View
{
    public class NewCustomerForm
    {
        public void NewCustomerForm_()
        {
            CustomerManager customerManager = new CustomerManager();
            Customer customer = new Customer(customerManager.GetCustomerId());

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the customer information as requested: \t\t\t\t|");
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
            customer.FirstName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the customer information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string firstName = customer.FirstName;
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
            Console.WriteLine("Please enter last name:");
            customer.LastName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
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

            string lastName = customer.LastName;
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

            string contactNumber;
            int contactNumberInt;

            do
            {
                Console.WriteLine("Please enter contact number:");
                contactNumber = Console.ReadLine();
            } 
            while (!int.TryParse(contactNumber, out contactNumberInt));

            customer.ContactNumber = contactNumberInt;

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
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

            int lineLengthContactNumber = 46;

            if (contactNumber.Length < lineLengthContactNumber)
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber.PadRight(lineLengthContactNumber)); Console.WriteLine(" |");
            }
            else if (contactNumber.Length > lineLengthContactNumber)
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber.Substring(0, lineLengthContactNumber)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber); Console.WriteLine("|");
            }

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
            customer.Address = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
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

            if (contactNumber.Length < lineLengthContactNumber)
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber.PadRight(lineLengthContactNumber)); Console.WriteLine(" |");
            }
            else if (contactNumber.Length > lineLengthContactNumber)
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber.Substring(0, lineLengthContactNumber)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string address = customer.Address;
            int lineLengthAddress = 53;

            if (address.Length < lineLengthAddress)
            {
                Console.Write("|\t\t\t\t\t Address: "); Console.Write(address.PadRight(lineLengthAddress)); Console.WriteLine(" |");
            }
            else if (address.Length > lineLengthAddress)
            {
                Console.Write("|\t\t\t\t\t Address: "); Console.Write(address.Substring(0, lineLengthAddress)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Address: "); Console.Write(address); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\tPress any key to validate\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.ReadKey();
            customerManager.RegisterNewCustomer(customer);
        }

        public void CustomerExistsMessage(Customer customer)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string firstName = customer.FirstName;
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

            string lastName = customer.LastName;
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

            string contactNumber = customer.ContactNumber.ToString();
            int lineLengthContactNumber = 46;

            if (contactNumber.Length < lineLengthContactNumber)
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber.PadRight(lineLengthContactNumber)); Console.WriteLine(" |");
            }
            else if (contactNumber.Length > lineLengthContactNumber)
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber.Substring(0, lineLengthContactNumber)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string address = customer.Address;
            int lineLengthAddress = 53;

            if (address.Length < lineLengthAddress)
            {
                Console.Write("|\t\t\t\t\t Address: "); Console.Write(address.PadRight(lineLengthAddress)); Console.WriteLine(" |");
            }
            else if (address.Length > lineLengthAddress)
            {
                Console.Write("|\t\t\t\t\t Address: "); Console.Write(address.Substring(0, lineLengthAddress)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Address: "); Console.Write(address); Console.WriteLine("|");
            }

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

        public void CustomerRegisteredMessage(Customer customer)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t       NEW CUSTOMER \t\t\t\t\t\t|", "NEW CUSTOMER", ConsoleColor.Yellow);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string firstName = customer.FirstName;
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

            string lastName = customer.LastName;
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

            string contactNumber = customer.ContactNumber.ToString();
            int lineLengthContactNumber = 46;

            if (contactNumber.Length < lineLengthContactNumber)
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber.PadRight(lineLengthContactNumber)); Console.WriteLine(" |");
            }
            else if (contactNumber.Length > lineLengthContactNumber)
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber.Substring(0, lineLengthContactNumber)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Contact number: "); Console.Write(contactNumber); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string address = customer.Address;
            int lineLengthAddress = 53;

            if (address.Length < lineLengthAddress)
            {
                Console.Write("|\t\t\t\t\t Address: "); Console.Write(address.PadRight(lineLengthAddress)); Console.WriteLine(" |");
            }
            else if (address.Length > lineLengthAddress)
            {
                Console.Write("|\t\t\t\t\t Address: "); Console.Write(address.Substring(0, lineLengthAddress)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Address: "); Console.Write(address); Console.WriteLine("|");
            }

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
            MainMenu.MainMenu_();
        }
    }
}
