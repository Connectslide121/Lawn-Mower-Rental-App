

using System;

class Customer
{
    private static int customerCount = 0;

    public int Id { get; private set; }
    public string Name { get; }
    public string Address { get; }
    public bool IsPrime { get; set; }
    public decimal BonusPoints { get; set; }
    public Customer()
    {
        // Default constructor needed for JSON deserialization.
    }
    public Customer(string name, string address, bool isPrime = false)
    {
        Id = ++customerCount;
        Name = name;
        Address = address;
        IsPrime = isPrime;
        BonusPoints = 0; // Initialize bonus points
    }
    public static void ResetCustomerCount()
    {
        customerCount = 0;
    }
}
