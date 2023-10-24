

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Xml;
using Newtonsoft.Json;

namespace Lawn_Mower_Rental_App
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public bool IsPrime { get; set; }
        public DateTime DateOfRegistry { get; set; }
    }
    public class BasicCustomer : Customer { }
    public class PrimeCustomer : Customer { }
    public class CustomerManager
    {
        private List<Customer> customers;
        string relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomerData.json");
        public CustomerManager()
        {
            customers = LoadCustomersFromJson();
        }
        public void RegisterNewCustomer(Customer customer, bool isPrimeCustomer)
        {
            // Implementation for registering a new customer
            int newCustomerId = customers.Count + 1;
            customer.CustomerId = newCustomerId;
            customer.DateOfRegistry = DateTime.Now;
            customer.IsPrime = isPrimeCustomer;
            customers.Add(customer);
            SaveCustomersToJson(customers);
        }
        public void UpgradeCustomerToPrime(int customerId)
        {
            Customer customer = customers.Find(cust => cust.CustomerId == customerId);
            if (customer != null)
            {
                if (!customer.IsPrime)
                {
                    decimal subscriptionFee = 19.90m;
                    Console.WriteLine($"Customer {customer.CustomerId}: {customer.FirstName} {customer.LastName} has chosen to upgrade to a prime account.");
                    Console.WriteLine($"A subscription fee of {subscriptionFee} kr will be charged.");
                    Console.Write("Continue? (Y/N): ");
                    if (AskUserForConfirmation())
                    {
                        ChargeCustomer(subscriptionFee, customer.FirstName);
                        customer.IsPrime = true;
                        SaveCustomersToJson(customers);
                        Console.WriteLine("Upgrade to prime successful!");
                    }
                    else
                    {
                        Console.WriteLine("Thank you. Come again.");
                    }
                }
                else
                {
                    Console.WriteLine($"Customer {customer.CustomerId}: {customer.FirstName} {customer.LastName} is already a prime user.");
                }
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
        // Other methods for managing customers (e.g., DeleteCustomer, ViewListOfCustomers, etc.)
        private bool AskUserForConfirmation()
        {
            string response = Console.ReadLine().Trim().ToUpper();
            return response == "Y" || response == "YES";
        }
        private List<Customer> LoadCustomersFromJson()
        {
            if (File.Exists(relativePath))
            {
                string json = File.ReadAllText(relativePath);
                return JsonConvert.DeserializeObject<List<Customer>>(json);
            }
            else
            {
                return new List<Customer>();
            }
        }
        private void SaveCustomersToJson(List<Customer> customers)
        {
            string json = JsonConvert.SerializeObject(customers, Formatting.Indented);
            File.WriteAllText(relativePath, json);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            // Call the UpgradeCustomerToPrime function with a customer ID
            customerManager.UpgradeCustomerToPrime(1);
            // Other parts of your application
        }
    }
}




