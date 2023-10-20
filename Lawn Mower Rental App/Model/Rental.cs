using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Model
{
    public class Rental
    {
        public int RentalId { get; set; }
        public LawnMower LawnMower { get; set; }
        public Customer Customer { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal CostPerDay { get; set; } // New property
        public decimal TotalPrice { get; set; }
        public bool IsActive { get; set; } = true;


        public Rental(int rentalId, decimal costPerDay) 
        {
            RentalId = rentalId;
            CostPerDay = costPerDay;
        }

        public override string ToString()
        {
            return $"ID: {RentalId}, LawnMowerID:{LawnMower.LawnMowerId}, CustomerID:{Customer.CustomerId}, From: {RentalDate.ToString("d")} To:{ReturnDate.ToString("d")}, Price: {TotalPrice} SEK";
        }
    }

}
