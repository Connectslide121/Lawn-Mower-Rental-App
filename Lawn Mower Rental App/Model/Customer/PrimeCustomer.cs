using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Model
{
    public class PrimeCustomer : Customer
    {
        public int BonusPoints { get; set; }

        public PrimeCustomer(int customerId) : base(customerId)
        {
            BonusPoints = 0;
        }
    }
}

