using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class RentLawnMowerForm
    {
        public void RentLawnMowerForm_()
        {
            
            CustomerManager customerManager = new CustomerManager();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t    RENT A LAWN MOWER \t\t\t\t\t\t|", "RENT A LAWN MOWER", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t Please enter information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Customer ID: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Rental Date: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Return Date: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");

            string customerId;
            int customerIdInt;

            do
            {
                Console.WriteLine("Please enter customer ID:");
                customerId = Console.ReadLine();
            }
            while (!int.TryParse(customerId, out customerIdInt));

            customerManager.FindCustomerById(customerIdInt);
        }

        public static void RentLawnMowerForm__(Customer customer)
        {
            RentalManager rentalManager = new RentalManager();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t    RENT A LAWN MOWER \t\t\t\t\t\t|", "RENT A LAWN MOWER", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t Please enter information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string customerId = customer.CustomerId.ToString();
            int lineLengthCustomerId = 49;

            if (customerId.Length < lineLengthCustomerId)
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId.PadRight(lineLengthCustomerId)); Console.WriteLine(" |");
            }
            else if (customerId.Length > lineLengthCustomerId)
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId.Substring(0, lineLengthCustomerId)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Rental Date: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Return Date: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");

            string rentalDate;
            DateTime rentalDateValid;

            do
            {
                Console.WriteLine("Please enter rental date (YYYY-MM-DD):");
                rentalDate = Console.ReadLine();
            }
            while (!DateTime.TryParse(rentalDate, out rentalDateValid));

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t    RENT A LAWN MOWER \t\t\t\t\t\t|", "RENT A LAWN MOWER", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t Please enter information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            if (customerId.Length < lineLengthCustomerId)
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId.PadRight(lineLengthCustomerId)); Console.WriteLine(" |");
            }
            else if (customerId.Length > lineLengthCustomerId)
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId.Substring(0, lineLengthCustomerId)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId); Console.WriteLine("|");
            }
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine($"|\t\t\t\t\t Rental Date: {rentalDateValid.ToString("d")}\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Return Date: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");

            string returnDate;
            DateTime returnDateValid;

            do
            {
                Console.WriteLine("Please enter return date (YYYY-MM-DD):");
                returnDate = Console.ReadLine();
            }
            while (!DateTime.TryParse(returnDate, out returnDateValid));

            Rental rentalToAdd = rentalManager.RentLawnMower(customer, rentalDateValid, returnDateValid);

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t    RENT A LAWN MOWER \t\t\t\t\t\t|", "RENT A LAWN MOWER", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t Please enter information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            if (customerId.Length < lineLengthCustomerId)
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId.PadRight(lineLengthCustomerId)); Console.WriteLine(" |");
            }
            else if (customerId.Length > lineLengthCustomerId)
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId.Substring(0, lineLengthCustomerId)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId); Console.WriteLine("|");
            }
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine($"|\t\t\t\t\t Rental Date: {rentalDateValid.ToString("d")}\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine($"|\t\t\t\t\t Return Date: {returnDateValid.ToString("d")}\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string totalPrice = rentalToAdd.TotalPrice.ToString();
            int lineLengthTotalPrice = 49;

            if (totalPrice.Length < lineLengthTotalPrice)
            {
                Console.Write("|\t\t\t\t\t Total price: "); Console.Write($"{totalPrice} SEK".PadRight(lineLengthTotalPrice)); Console.WriteLine(" |");
            }
            else if (totalPrice.Length > lineLengthTotalPrice)
            {
                Console.Write("|\t\t\t\t\t Total price: "); Console.Write($"{totalPrice} SEK".Substring(0, lineLengthTotalPrice)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Total price: "); Console.Write($"{totalPrice} SEK"); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t    Press any key to create rental\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.ReadKey();

            rentalManager.AddRentalToList(rentalToAdd);

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t    RENT A LAWN MOWER \t\t\t\t\t\t|", "RENT A LAWN MOWER", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t Please enter information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            if (customerId.Length < lineLengthCustomerId)
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId.PadRight(lineLengthCustomerId)); Console.WriteLine(" |");
            }
            else if (customerId.Length > lineLengthCustomerId)
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId.Substring(0, lineLengthCustomerId)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Customer ID: "); Console.Write(customerId); Console.WriteLine("|");
            }
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine($"|\t\t\t\t\t Rental Date: {rentalDateValid.ToString("d")}\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine($"|\t\t\t\t\t Return Date: {returnDateValid.ToString("d")}\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            if (totalPrice.Length < lineLengthTotalPrice)
            {
                Console.Write("|\t\t\t\t\t Total price: "); Console.Write($"{totalPrice} SEK".PadRight(lineLengthTotalPrice)); Console.WriteLine(" |");
            }
            else if (totalPrice.Length > lineLengthTotalPrice)
            {
                Console.Write("|\t\t\t\t\t Total price: "); Console.Write($"{totalPrice} SEK".Substring(0, lineLengthTotalPrice)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Total price: "); Console.Write($"{totalPrice} SEK"); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t    Rental created successfully!\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }

        public static void CustomerNotFoundMessage()
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t    RENT A LAWN MOWER \t\t\t\t\t\t|", "RENT A LAWN MOWER", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t Please enter information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Customer ID: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Rental Date: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Return Date: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Customer not found\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();

        }

        public static void NoLawnMowersAvailableMessage()
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t    RENT A LAWN MOWER \t\t\t\t\t\t|", "RENT A LAWN MOWER", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\tNo lawn mowers available\t\t\t\t\t|");
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


