// See https://aka.ms/new-console-template for more information


using System;
using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;
namespace Lawn_Mower_Rental_App.View
{
    public class RentLawnMowerForm
    {
        public void RentLawnMowerForm_()
        {
            //previous code for renting a lawn mower
            // Calculate the rental cost based on the rental period and price per day
            decimal pricePerDay = lawnMowerToRent.PricePerDay;
            TimeSpan rentalPeriod = returnDate - rentalDate;
            decimal totalCost = pricePerDay * (decimal)rentalPeriod.TotalDays;
            //display the total cost to the user
            Console.WriteLine($"Total Cost: ${totalCost}");
            rentalManager.RentLawnMower(customerToRent, lawnMowerToRent, rentalDate, returnDate,
            totalCost);
            Console.WriteLine("Lawn mower rented successfully. Press any key to return to the main menu.");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
}
// calculate the totalCost by multiplying the pricePerDay with the number of days between rentalDate and
//returnDate.This calculation assumes that the rental price is specified per day.
// then display the totalCost to the user. You can format it as needed to show currency symbols or decimal places.
//the totalCost is also passed to the RentalManager for record-keeping and later retrieval in rental history. Make sure you have an appropriate method in RentalManager to handle this.

