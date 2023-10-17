using Lawn_Mower_Rental_App.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Model
{
    public class LawnMower
    {
        public int Id { get; }
        public string Model { get; } = "HUSQVARNA LB 448S KLIPPO";
        public bool IsAvailable { get; set; } = true;
        public DateTime? LastMaintenance { get; set; }
        public decimal PricePerDay { get; } = 99.95M;
        public string AvailabilityStatus
        {
            get { return IsAvailable ? "Available" : "In Use"; }
        }

        public LawnMower(DateTime? lastMaintenance)
        {
            LawnMowerManager lawnMowerManager = new LawnMowerManager();
            Id = lawnMowerManager.GetId();
            LastMaintenance = lastMaintenance;
        }

       

    }
}
