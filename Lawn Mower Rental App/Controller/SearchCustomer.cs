using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lawn_Mower_Rental_App.Controller
{
    public class SearchCustomer
    {
        private List<Customer> customers;

        public SearchCustomer(List<Customer> customers)
        {
            this.customers = customers;
        }

        public void SearchCustomers_()
        {
            Console.WriteLine("Enter the information of the customer you are looking for.:");
            string query = Console.ReadLine();

            var searchResults = Search(query);

            CustomerSearchView.DisplaySearchResults(searchResults);
        }

        public List<Customer> Search(string query)
        {
            query = query.ToLower();

            return customers.Where(customer =>
                customer.FirstName.ToLower().Contains(query) ||
                customer.LastName.ToLower().Contains(query) ||
                customer.CustomerId.ToString().Contains(query) ||
                customer.Address.ToLower().Contains(query) ||
                customer.ContactNumber.ToString().Contains(query) ||
                customer.DateOfRegistry.ToString().Contains(query)
            ).ToList();
        }
    }
}


