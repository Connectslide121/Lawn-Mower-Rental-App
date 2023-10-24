

using System;

class Rental
{
    public Customer Customer { get; }
    public LawnMower LawnMower { get; }
    public DateTime RentalDate { get; }
    public DateTime ReturnDate { get; }
    public decimal TotalPrice { get; }

    public Rental(Customer customer, LawnMower lawnMower, DateTime rentalDate, DateTime returnDate, decimal
    totalPrice)
    {
        Customer = customer;
        LawnMower = lawnMower;
        RentalDate = rentalDate;
        ReturnDate = returnDate;
        TotalPrice = totalPrice;
    }
}