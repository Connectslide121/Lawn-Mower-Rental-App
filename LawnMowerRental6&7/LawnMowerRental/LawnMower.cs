

using System;

class LawnMower
{
    public int Id { get; }
    public string Type { get; }
    public string Model { get; }
    public bool IsAvailable { get; set; }
    public decimal PricePerDay { get; }
    public string AvailabilityStatus
    {
        get { return IsAvailable ? "Available" : "In Use"; }
    }
    public LawnMower(int id, string type, string model, bool isAvailable, decimal pricePerDay)
    {
        Id = id;
        Type = type;
        Model = model;
        IsAvailable = isAvailable;
        PricePerDay = pricePerDay;
    }
}