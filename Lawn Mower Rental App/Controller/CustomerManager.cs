using Lawn_Mower_Rental_App.Model;
using System.Text.Json;
using System.Xml;

public class CustomerManager
{
    private List<Customer> customers;

    public CustomerManager()
    {
        customers = LoadCustomersFromJson();
    }
    // Just setting up so we can interact with the json file.
    public void RegisterNewCustomer(Customer customer)
    {
        customers.Add(customer);
        SaveCustomersToJson();
        Console.WriteLine("Customer registered successfully.");
    }

    public void ViewListOfCustomers()
    {
        if (customers.Count == 0)
        {
            Console.WriteLine("No customers registered yet.");
            return;
        }

        Console.WriteLine("List of registered customers:");
        foreach (var customer in customers)
        {
            Console.WriteLine(customer);
        }
    }

    private List<Customer> LoadCustomersFromJson()
    {
        if (File.Exists("CustomerData.json"))
        {
            string jsonData = File.ReadAllText("CustomerData.json");
            return JsonSerializer.Deserialize<List<Customer>>(jsonData);
        }
        return new List<Customer>();
    }
    private void SaveCustomersToJson()
    {
        string jsonData = JsonSerializer.Serialize(customers, typeof(List<Customer>), new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText("CustomerData.json", jsonData);
    }

}
