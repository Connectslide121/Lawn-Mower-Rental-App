using System;
using System.Collections.Generic;
using System.Linq;
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
        public decimal TotalPrice { get; set; }


        public Rental(int rentalId) 
        {
            RentalId = rentalId;
        }
    }

}
