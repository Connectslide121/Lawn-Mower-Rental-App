using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Model
{
    
    public class Customer
    {
        
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfRegistry { get; set; } = DateTime.Now;


        public Customer(int customerId) 
        {
            CustomerId = customerId;
        }

        public override string ToString()
        {
            return $"ID: {CustomerId} - {FirstName} {LastName} - Contact: {ContactNumber} - Address: {Address} - {DateOfRegistry.ToString("d")}";
        }
    }
}
