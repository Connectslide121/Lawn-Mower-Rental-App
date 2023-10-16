// See https://aka.ms/new-console-template for more information


Class LawnMower

{
    public int Id { get; }

using System.Globalization;
using System.Reflection;

public string Model { get; }
public bool IsAvailable { get; set; }
public DateTime? LastMaintenance { get; set; }
public decimal PricePerDay { get; }
public string AvailabilityStatus
{
    get { return IsAvailable ? "Available" : "In Use"; }
}
public LawnMower(int id, string model, bool isAvailable, DateTime? lastMaintenance, decimal pricePerDay)
{
    Id = id;
    Model = model. 
    IsAvailable = isAvailable;
    LastMaintenance = lastMaintenance;
    PricePerDay = pricePerDay;
}
}
if (File.Exists(lawnMowersFile))
{
    foreach (var line in File.ReadLines(lawnMowersFile))
    {
        string[] parts = line.Split(',');
        if (parts.Length == 5)
        {
            int id = int.Parse(parts[0]);
            string model = parts[1];
            bool isAvailable = bool.Parse(parts[2]);
            DateTime? lastMaintenance = string.IsNullOrEmpty(parts[3]) ? (DateTime?)null : DateTime.Parse(parts[3]);
            decimal pricePerDay = decimal.Parse(parts[4], CultureInfo.InvariantCulture);
            lawnMowers.Add(new LawnMower(id, model, isAvailable, lastMaintenance, pricePerDay));
        }
    }
}
if (rentals.Any())
{
    Console.WriteLine("Customers with Rentals:");
    foreach (var rental in rentals)
    {
        Console.WriteLine($"Customer ID: {rental.Customer.Id:000}, Name: {rental.Customer.Name}");
        Console.WriteLine($"Lawn Mower ID: {rental.LawnMower.Id:00} - {rental.LawnMower.AvailabilityStatus}");
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

static void RentLawnMowerForCustomer(Customer customer, int rentalDays)
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