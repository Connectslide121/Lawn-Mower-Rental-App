using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Model
{
    public class PetrolLawnMower : LawnMower
    {
        public decimal Emission { get; set; } = 862M;

        public PetrolLawnMower(int lawnMowerId) : base(lawnMowerId)
        {

        }

        public override string ToString()
        {
            return $"ID: {LawnMowerId}, {Model}, {AvailabilityStatus}, Maintenance: {LastMaintenance.ToString("d")}, {PricePerDay} SEK/day, Emission: {Emission.ToString()} g/kWh";
        }
    }
}
