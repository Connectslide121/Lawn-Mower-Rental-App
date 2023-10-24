using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Model
{
    public class ElectricLawnMower : LawnMower
    {
        public decimal BatteryEffect { get; set; } = 75.6M;


        public ElectricLawnMower(int lawnMowerId) : base(lawnMowerId)
        {

        }

        public override string ToString()
        {
            return $"ID: {LawnMowerId}, {Model}, {AvailabilityStatus}, Maintenance: {LastMaintenance.ToString("d")}, {PricePerDay} SEK/day, Battery effect: {BatteryEffect.ToString()} Wh";
        }
    }
}
