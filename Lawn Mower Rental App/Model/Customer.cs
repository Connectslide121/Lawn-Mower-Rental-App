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
        // We can add more if we need it

        public Customer() 
        {
            CustomerManager customerManager = new CustomerManager();
            CustomerId = customerManager.GetCustomerId();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - Contact: {ContactNumber}, Address: {Address}, Customer ID:";
        }
    }

}
