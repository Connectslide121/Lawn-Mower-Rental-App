using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using Lawn_Mower_Rental_App.View.Lawn_Mower_Rental_App.View;
using System.Text.Json;
using System.Xml;

namespace Lawn_Mower_Rental_App.Controller
{
    public class CustomerManager
    {
        private List<Customer> customers;
        string relativePath = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "CustomerData.json");


        public CustomerManager()
        {
            customers = LoadCustomersFromJson();
        }
        // Just setting up so we can interact with the json file.

        public void RegisterNewCustomer(Customer customer)
        {
            customers.Add(customer);
            SaveCustomersToJson(customers);
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
                customer.FirstName.ToLower() == firstName &&
                customer.LastName.ToLower() == lastName &&
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
        if (customers.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("No customers registered yet.");//**THIS SHOULD CALL A METHOD IN VIEW FOLDER WITH THE RIGHT FORMATTING
        }

        else
        {
            Console.WriteLine("List of registered customers:"); //**THIS SHOULD CALL A METHOD IN VIEW FOLDER WITH THE RIGHT FORMATTING
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Press any key to go back to the Main Menu");//**THIS SHOULD CALL A METHOD IN VIEW FOLDER WITH THE RIGHT FORMATTING
        Console.ReadKey();
        MainMenu.MainMenu_();
    }

    private List<Customer> LoadCustomersFromJson()
    {
        try
        {
            if (File.Exists(relativePath))
            {
                string jsonData = File.ReadAllText(relativePath);
                return JsonSerializer.Deserialize<List<Customer>>(jsonData);
            }
        }
        catch (Exception) { ErrorsExceptions.CustomerFileNotFoundException(); }
        return customers;
    }

        private void SaveCustomersToJson(List<Customer> customers)
        {
            string jsonData = JsonSerializer.Serialize(customers, typeof(List<Customer>), new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(relativePath, jsonData);
        }

    }
}
