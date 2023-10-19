// See https://aka.ms/new-console-template for more information


using System;
using System.IO;
using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;
namespace Lawn_Mower_Rental_App.View
{
    public class RentLawnMowerForm
    {
        public void RentLawnMowerForm_()
        {
            RentalManager rentalManager = new RentalManager();
            CustomerManager customerManager = new CustomerManager();
            LawnMowerManager lawnMowerManager = new LawnMowerManager();
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM)* *************************************| ");
            Console.WriteLine("|                   | ");

            Console.WriteLine("| RENT A LAWN MOWER | ");
            Console.WriteLine("|                   | ");
            Console.WriteLine("| Please enter the lawn mower information as requested:| ");
            Console.WriteLine("|                   | ");

            // GETTING THE CUSTOMER ID
            int customerId;
            do
            {
                Console.Write("Please enter customer ID: ");
            } while (!int.TryParse(Console.ReadLine(), out customerId));
            Customer customerToRent = customerManager.FindCustomerById(customerId);
            if (customerToRent == null)
            {
                Console.WriteLine("Customer not found. Press any key to return to the main menu.");
                Console.ReadKey();
                MainMenu.MainMenu_();
                return;
            }

            // GETTING THE RENTAL DATE
            DateTime rentalDate;
            do
            {
                Console.Write("Please enter rental date (YYYY-MM-DD hh:mm:ss): ");
            } while (!DateTime.TryParse(Console.ReadLine(), out rentalDate));
            // GETTING THE RETURN DATE
            DateTime returnDate;
            do
            {
                Console.Write("Please enter return date (YYYY-MM-DD hh:mm:ss): ");
            } while (!DateTime.TryParse(Console.ReadLine(), out returnDate));
            // THIS WILL GET THE LAWN MOWER ID
            int lawnMowerId;
            do
            {
                Console.Write("Please enter lawn mower ID: ");
            } while (!int.TryParse(Console.ReadLine(), out lawnMowerId));
            LawnMower lawnMowerToRent = lawnMowerManager.FindLawnMowerById(lawnMowerId);
            if (lawnMowerToRent == null)
            {
                Console.WriteLine("Lawn mower not found. Press any key to return to the main menu.");
                Console.ReadKey();
                MainMenu.MainMenu_();
                return;
            }
            if (!lawnMowerToRent.IsAvailable)
            {
                Console.WriteLine("Lawn mower is not available for rent. Press any key to return to the main menu.");
                Console.ReadKey();
                MainMenu.MainMenu_();
                return;
            }
            rentalManager.RentLawnMower(customerToRent, lawnMowerToRent, rentalDate, returnDate);
            Console.WriteLine("Lawn mower rented successfully. Press any key to return to the main menu.");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
    public class ViewCurrentRentalsForm
    {
        public void ViewCurrentRentals()
        {
            RentalManager rentalManager = new RentalManager();
            var currentRentals = rentalManager.GetCurrentRentals();
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM)* *************************************| ");
            Console.WriteLine("|                        | ");
            Console.WriteLine("| VIEW CURRENT RENTALS   | ");
            Console.WriteLine("|                        | ");
        if (currentRentals.Count == 0)
            {
                Console.WriteLine("No current rentals found.");
            }
            else
            {
                Console.WriteLine("Current Rentals:");
                foreach (var rental in currentRentals)
                {
                    Console.WriteLine(rental);
                }
            }
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
    public class ViewRentalHistoryForm
    {
        public void ViewRentalHistory()
        {
            RentalManager rentalManager = new RentalManager();
            var rentalHistory = rentalManager.GetRentalHistory();
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM)* *************************************| ");
            Console.WriteLine("|                     | ");
            Console.WriteLine("| VIEW RENTAL HISTORY | ");
            Console.WriteLine("|                     | ");
        if (rentalHistory.Count == 0)
            {
                Console.WriteLine("No rental history found.");
            }
            else
            {
                Console.WriteLine("Rental History:");
                foreach (var rental in rentalHistory)
                {
                    Console.WriteLine(rental);
                }
            }
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
}
//The user is prompted to enter customer ID, rental date, return date, and lawn mower ID.
//This changes will check if the customer and lawn mower exist and if the lawn mower is available for rent.
//Please make sure that your CustomerManager, LawnMowerManager, and RentalManager classes have the

//necessary methods to interact with customers, lawn mowers, and rentals, respectively.
//I added a new class ViewCurrentRentalsForm for viewing the current rentals and a class

//ViewRentalHistoryForm for viewing the rental history.
//The ViewCurrentRentalsForm and ViewRentalHistoryForm classes allow users to view the current rentals and
//rental history, respectively. The data is obtained from the RentalManager class.

//Please ensure that you have methods in your RentalManager class to retrieve current rentals and rental
//history and that your JSON file handling logic correctly updates the rental history data.

//RENT LAWN MOWER FORM
//using System;
//using Lawn_Mower_Rental_App.Controller;
//using Lawn_Mower_Rental_App.Model;
//namespace Lawn_Mower_Rental_App.View
//{
    //public class RentLawnMowerForm
    //{
        //public void RentLawnMowerForm_()
        //{
        //}
   // }
//}

//VIEW CURRENT RENTAL FORM
//using System;
//using Lawn_Mower_Rental_App.Controller;
//namespace Lawn_Mower_Rental_App.View
//{
    //public class ViewCurrentRentalsForm
    //{
        //public void ViewCurrentRentals()
        //{
        //}
    //}
//}

//VIEW RENTAL HISTORY FORM
//using System;
//using Lawn_Mower_Rental_App.Controller;
//namespace Lawn_Mower_Rental_App.View
//{
    //public class ViewCurrentRentalsForm
    //{
        //public void ViewCurrentRentals()
        //{
        //}
    //}
//}

