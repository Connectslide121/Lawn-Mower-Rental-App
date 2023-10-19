// See https://aka.ms/new-console-template for more information


public static void ReturnLawnMower(int rentalId)
{
    Rental rental = rentals.Find(r => r.Id == rentalId);
    if (rental != null)
    {
        LawnMower rentedMower = rental.LawnMower;
        if (!rentedMower.IsAvailable)
        {
            rentedMower.IsAvailable = true;
            rental.IsActive = false;
            Console.WriteLine($"Lawn Mower ID: {rentedMower.Id} has been returned.");
            SaveDataToJson();
        }
        else
        {
            Console.WriteLine($"Lawn Mower ID: {rentedMower.Id} is already available.");
        }
    }
    else
    {
        Console.WriteLine($"Rental with ID {rentalId} not found.");
    }
}
//This method should take the RentalID as a parameter, find the corresponding rental, and update the status
//of the lawn mower and rental
//update the Rental class to include an Id property
class Rental
{
    public int Id { get; private set; } // Add an Id property
    public Customer Customer { get; }
    public LawnMower LawnMower { get; }
    public DateTime RentalDate { get; }
    public DateTime ReturnDate { get; }
    public decimal TotalPrice { get; }
    public bool IsActive { get; set; } // Add IsActive property
    public Rental(Customer customer, LawnMower lawnMower, DateTime rentalDate, DateTime returnDate, decimal
   totalPrice)
    {
        Id = GenerateUniqueId(); // Call the GenerateUniqueId method to set the Id
        Customer = customer;
        LawnMower = lawnMower;
        RentalDate = rentalDate;
        ReturnDate = returnDate;
        TotalPrice = totalPrice;
        IsActive = true; // Set IsActive to true by default
    }
    // Method to generate a unique Id for each rental
    private int GenerateUniqueId()
    {

        return Interlocked.Increment(ref lastRentalId);
    }
}
// We can implement a logic to generate a unique Id, for example, incrementing from a counter
// We may want to store the last used Id in our data and increment it here
// For simplicity, I'll assume a unique  Id is assigned sequentially



