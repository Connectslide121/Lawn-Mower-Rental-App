using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using System.Text.Json;

namespace Lawn_Mower_Rental_App.Controller
{
    public class CustomerManager
    {
        private List<BasicCustomer> basicCustomers;
        private List<PrimeCustomer> primeCustomers;
        string relativePathBasic = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "BasicCustomerData.json");
        string relativePathPrime = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "PrimeCustomerData.json");

        public CustomerManager()
        {
            basicCustomers = LoadBasicCustomersFromJson();
        }

        public void RegisterNewCustomer(BasicCustomer basicCustomer) //This should also check in the primeCustomers list
        {
            NewCustomerForm newCustomerForm = new NewCustomerForm();

            bool customerExists = basicCustomers.Any(item =>
                item.FirstName.ToLower() == basicCustomer.FirstName.ToLower() &&
                item.LastName.ToLower() == basicCustomer.LastName.ToLower() &&
                item.ContactNumber == basicCustomer.ContactNumber);

            if (customerExists)
            {
                newCustomerForm.CustomerExistsMessage(basicCustomer);
            }
            else
            {
                basicCustomers.Add(basicCustomer);
                SaveBasicCustomersToJson(basicCustomers);
                newCustomerForm.CustomerRegisteredMessage(basicCustomer);
            }
        }

        public int GetCustomerId() //This should also check in the primeCustomers list
        {
            if (basicCustomers.Count == 0)
            {
                return 1;
            }

            int highestID = basicCustomers.Max(basicCustomer => basicCustomer.CustomerId);

            for (int i = 1; i <= highestID + 1; i++)
            {
                if (!basicCustomers.Any(basicCustomer => basicCustomer.CustomerId == i))
                {
                    return i;
                }
            }
            return highestID + 1;
        }

        public void DeleteCustomer(string firstName, string lastName, int customerId) //This should also check in the primeCustomers list
        {
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();
            int initialCount = basicCustomers.Count;

            basicCustomers.RemoveAll(basicCustomer =>
                basicCustomer.FirstName.ToLower() == firstName.ToLower() &&
                basicCustomer.LastName.ToLower() == lastName.ToLower() &&
                basicCustomer.CustomerId == customerId
                );
            SaveBasicCustomersToJson(basicCustomers);

            if (basicCustomers.Count == initialCount)
            {
            deleteCustomerForm.CustomerNotFoundMessage(firstName, lastName, customerId);
            }
            else
            {
            deleteCustomerForm.CustomerDeletedMessage(firstName, lastName, customerId);
            }
        }

        public void ViewListOfCustomers() //This should also check in the primeCustomers list
        {
                CustomerListView.DisplayCustomerList(basicCustomers);
        }

        private List<BasicCustomer> LoadBasicCustomersFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePathBasic);
                return JsonSerializer.Deserialize<List<BasicCustomer>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.CustomerFileNotFoundException(); }
            return basicCustomers;
        }

        private void SaveBasicCustomersToJson(List<BasicCustomer> basicCustomers)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(basicCustomers, typeof(List<BasicCustomer>), new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(relativePathBasic, jsonData);
            }
            catch { ErrorsExceptions.CustomerFileNotFoundException(); }
        }

        public void FindCustomerById(int customerId) //This should also check in the primeCustomers list
        {
            Customer foundCustomer = basicCustomers.Find(basicCustomer => basicCustomer.CustomerId == customerId);
            if (foundCustomer != null)
            {
                RentLawnMowerForm.RentLawnMowerForm__(foundCustomer);
            }
            else
            {
                RentLawnMowerForm.CustomerNotFoundMessage(customerId);
            };
        }

        public List<BasicCustomer> SearchCustomers(string query) //This should also check in the primeCustomers list
        {
            query = query.ToLower();

            return basicCustomers.Where(basicCustomer =>
                basicCustomer.FirstName.ToLower().Contains(query) ||
                basicCustomer.LastName.ToLower().Contains(query) ||
                basicCustomer.CustomerId.ToString().Contains(query) ||
                basicCustomer.Address.ToLower().Contains(query) ||
                basicCustomer.ContactNumber.ToString().Contains(query) ||
                basicCustomer.DateOfRegistry.ToString().Contains(query)
            ).ToList();
        }
    }
}
