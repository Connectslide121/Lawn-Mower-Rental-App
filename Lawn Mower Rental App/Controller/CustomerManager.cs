using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using System.Text.Json;

namespace Lawn_Mower_Rental_App.Controller
{
    public class CustomerManager
    {
        private List<Customer> customers;
        string relativePath = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "CustomerData.json");
        public CustomerManager(List<Customer> customers)
        {
            this.customers = customers;
        }

        public CustomerManager()
        {
            customers = LoadCustomersFromJson();
        }

        public void RegisterNewCustomer(Customer customer) // When i was trying to get PrimeCustomer set in, it made sense to just get Basic and Prime both done in one go. 
        { // NewCustomerForm has to be updated 
            NewCustomerForm newCustomerForm = new NewCustomerForm();

            bool customerExists = customers.Any(item =>
                item.FirstName.ToLower() == customer.FirstName.ToLower() &&
                item.LastName.ToLower() == customer.LastName.ToLower() &&
                item.ContactNumber == customer.ContactNumber);

            if (customerExists)
            {
                newCustomerForm.CustomerExistsMessage(customer);
            }
            else
            {
                customers.Add(customer);
                SaveCustomersToJson(customers);
                newCustomerForm.CustomerRegisteredMessage(customer);
            }
        }

        public int GetCustomerId()
        {
            if (customers.Count == 0)
            {
                return 1;
            }

            int highestID = customers.Max(customer => customer.CustomerId);

            for (int i = 1; i <= highestID + 1; i++)
            {
                if (!customers.Any(customer => customer.CustomerId == i))
                {
                    return i;
                }
            }
            return highestID + 1;
        }

        public void DeleteCustomer(string firstName, string lastName, int customerId)
        {
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();
            int initialCount = customers.Count;

            customers.RemoveAll(customer =>
                customer.FirstName.ToLower() == firstName.ToLower() &&
                customer.LastName.ToLower() == lastName.ToLower() &&
                customer.CustomerId == customerId
                );
            SaveCustomersToJson(customers);

            if (customers.Count == initialCount)
            {
            deleteCustomerForm.CustomerNotFoundMessage(firstName, lastName, customerId);
            }
            else
            {
            deleteCustomerForm.CustomerDeletedMessage(firstName, lastName, customerId);
            }
        }

        public void ViewListOfCustomers()
        {
                CustomerListView.DisplayCustomerList(customers);
        }

        private List<Customer> LoadCustomersFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePath);
                return JsonSerializer.Deserialize<List<Customer>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.CustomerFileNotFoundException(); }
            return customers;
        }

        private void SaveCustomersToJson(List<Customer> customers)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(customers, typeof(List<Customer>), new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(relativePath, jsonData);
            }
            catch { ErrorsExceptions.CustomerFileNotFoundException(); }
        }

        public void FindCustomerById(int customerId)
        {
            Customer foundCustomer = customers.Find(customer => customer.CustomerId == customerId);
            if (foundCustomer != null)
            {
                RentLawnMowerForm.RentLawnMowerForm__(foundCustomer);
            }
            else
            {
                RentLawnMowerForm.CustomerNotFoundMessage(customerId);
            };
        }

        public List<Customer> SearchCustomers(string query)
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
