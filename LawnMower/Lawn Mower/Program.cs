// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class LawnMower

{
    public int Id { get; set; }
    public string AvailabilityStatus { get; set; }
    public decimal PricePerDay { get; set; }
    public bool IsAvailable { get; set; }

}

class Customer

{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Rental
{
    public Customer Customer { get; set; }
    public LawnMower LawnMower { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public decimal TotalPrice { get; set; }

    public Rental (Customer customer, LawnMower lawnMower, DateTime rentalDate,
        DateTime returnDate, decimal totalPrice)
    {
        Customer = customer;
        LawnMower = lawnMower;
        RentalDate = rentalDate;
        ReturnDate = returnDate;
        TotalPrice = totalPrice;
    }
}

class Program

{
    static List<Rental> rentals = new List<Rental>();
    static List<LawnMower> lawnMowers = new List<LawnMower>();

    static void Main()
    {
        // THIS WILL INITIALIZE THE LAWN MOWERS LIST WITH SAMPLE DATA
        InitializeLawnMowers();


        if (rentals.Any()) //rentals IS A LIST OF LAWNMAWERS THAT HAVE BEEN RENTED OUT ("IsAvailable" == false) THIS WAS MEANT TO BE USED TO DISPLAY
                           //WHAT LAWN MOWERS ARE RENTED, BUT WE DECIDED TO DISPLAY THE ENTIRE INVENTORY INSTEAD, WHICH WILL SHOW WHAT MOWERS ARE RENTED AS WELL
        {

            Console.WriteLine("Customers with Rentals:");
            foreach (var rental in rentals)

            {
                Console.WriteLine($"Customer ID: {rental.Customer.Id:000}, Name: {rental.Customer.Name}");
                Console.WriteLine($"Lawn Mower ID: {rental.LawnMower.Id:00} - {rental.LawnMower.AvailabilityStatus} ");
            if (!rental.LawnMower.IsAvailable)

                {
                    Console.WriteLine($"Rental Date: {rental.RentalDate}, Return Date: {rental.ReturnDate}");
                    Console.WriteLine($"Total Price: {rental.TotalPrice:0.00} kr\n");
                }
                else
                {
                    Console.WriteLine("Lawn mower returned.\n");
                }
            }
        }
        else

        {
            Console.WriteLine("No rentals found.");
        }
    }

    static void InitializeLawnMowers()
    {
        // THIS WILL ALSO INITIALIZE THE LAWN MOWERS LIST WITH SAMPLE DATA
        for (int i = 1; i <= 15; i++)
        {
            lawnMowers.Add(new LawnMower
            {
                Id = i,
                AvailabilityStatus = "Available",
                PricePerDay = 99.9m,
                IsAvailable = true
            });
        }
    }

    static void RentLawnMowerForCustomer(Customer customer, int rentalDays) //lawnMowers IS A LIST OF ALL THE LAWN MOWERS. THIS HAS NOT BEEN CREATED YET.
    {
        int rentedMowerId = lawnMowers.FindIndex(m => m.IsAvailable);
        if (rentedMowerId >= 0)

        {
            var selectedMower = lawnMowers[rentedMowerId];
            selectedMower.IsAvailable = false;
            DateTime rentalDateTime = DateTime.Now;
            DateTime returnDateTime = rentalDateTime.AddDays(rentalDays);
            decimal totalPrice = selectedMower.PricePerDay * rentalDays;

            rentals.Add(new Rental(customer, selectedMower, rentalDateTime, returnDateTime, totalPrice));
            Console.WriteLine($"You have rented Lawn Mower ID: {selectedMower.Id:00} for {rentalDays} day(s).");
            Console.WriteLine($"Total Price: {totalPrice:0.00} kr");

        }
        else
        {
            Console.WriteLine("No available lawn mowers. Cannot proceed with the rental.");
        }
    }
}