using Lawn_Mower_Rental_App.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Model
{
    public class LawnMower
    {
        public int LawnMowerId { get; set; }
        public string Model { get; set;  } = "HUSQVARNA LB 448S KLIPPO";
        public bool IsAvailable { get; set; } = true;
        public DateTime? LastMaintenance { get; set; } = DateTime.Now;
        public decimal PricePerDay { get; set; } = 99.95M;
        public string AvailabilityStatus
        {
            get { return IsAvailable ? "Available" : "In Use"; }
        }

        public LawnMower(int lawnMowerId)
        {
            LawnMowerId = lawnMowerId;
        }
        public override string ToString()
        {
            return $"ID: {LawnMowerId}, {Model}, {AvailabilityStatus}, Last Maintenance: {LastMaintenance.ToShortDateString()}, {PricePerDay}SEK/day";
        }




    }
}
