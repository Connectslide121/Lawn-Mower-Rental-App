using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Model
{
    public class BasicCustomer : Customer
    {
        public bool HasDiscount { get; set; }
        public int RemainingDiscounts { get; set; }

        public BasicCustomer(int customerId) : base(customerId)
        {
            HasDiscount = true;
            RemainingDiscounts = 1;
        }
    }
} // In hindsight i think Basic and Prime could have worked in one class, but im keeping them seperate for now so its easier to tweak. // Daniel

