using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Model
{
    public class BasicCustomer : Customer
    {
        public int RemainingDiscounts { get; set; }

        public BasicCustomer(int customerId) : base(customerId)
        {
            RemainingDiscounts = 1;
        }

        public override string ToString()
        {
            return $"ID: {CustomerId} - {FirstName} {LastName} - Contact: {ContactNumber} - Address: {Address} - {DateOfRegistry.ToString("d")} - Discounts left: {RemainingDiscounts.ToString()}";
        }
    }
}

