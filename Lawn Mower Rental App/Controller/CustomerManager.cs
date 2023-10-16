using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using System.Text.Json;
using System.Xml;

public class CustomerManager
{
    private List<Customer> customers;
    string relativePath = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..")), "CustomerData.json");


    public CustomerManager()
    {
        customers = LoadCustomersFromJson();
    }
    // Just setting up so we can interact with the json file.
    public void RegisterNewCustomer(Customer customer)
    {
        customers.Add(customer);
        SaveCustomersToJson(customers);
        Console.WriteLine("Customer registered successfully. Press any key to go back to the Main Menu");
        Console.ReadKey();
        Main.MainMenu();
    }

    public void ViewListOfCustomers()
    {
        if (customers.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("No customers registered yet.");
        }

        else
        {
            Console.WriteLine("List of registered customers:"); //**********************SHOULD THIS CALL A METHOD IN A VIEW FOLDER? WITH THE RIGHT FORMATTING??
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Press any key to go back to the Main Menu");
        Console.ReadKey();
        Main.MainMenu();
    }

    private List<Customer> LoadCustomersFromJson()
    {
        if (File.Exists(relativePath))
        {
            string jsonData = File.ReadAllText(relativePath);
            return JsonSerializer.Deserialize<List<Customer>>(jsonData);
        }
        return new List<Customer>();
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
