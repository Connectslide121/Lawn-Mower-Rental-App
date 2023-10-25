using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using System.Text.Json;

namespace Lawn_Mower_Rental_App.Controller
{
    public enum CustomerType // Not sure if Enum is the right call, but felt like the obvious fix to me
    {
        Basic,
        Prime
    }
    public class CustomerManager
    {
        private List<BasicCustomer> basicCustomers;
        private List<PrimeCustomer> primeCustomers;
        string relativePathBasic = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "BasicCustomerData.json");
        string relativePathPrime = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "PrimeCustomerData.json");

        public CustomerManager()
        {
            basicCustomers = LoadBasicCustomersFromJson();
            primeCustomers = LoadPrimeCustomersFromJson();
        }

        public void RegisterNewCustomer(Customer customer)
        {
            NewCustomerForm newCustomerForm = new NewCustomerForm();

            bool customerExists = customer is BasicCustomer
                ? basicCustomers.Any(item =>
                    item.FirstName.ToLower() == customer.FirstName.ToLower() &&
                    item.LastName.ToLower() == customer.LastName.ToLower() &&
                    item.ContactNumber == customer.ContactNumber)
                : primeCustomers.Any(item =>
                    item.FirstName.ToLower() == customer.FirstName.ToLower() &&
                    item.LastName.ToLower() == customer.LastName.ToLower() &&
                    item.ContactNumber == customer.ContactNumber);

            if (customerExists)
            {
                newCustomerForm.CustomerExistsMessage(customer);
            }
            else
            {
                if (customer is BasicCustomer)
                {
                    basicCustomers.Add(customer as BasicCustomer);
                    SaveBasicCustomersToJson(basicCustomers);
                }
                else if (customer is PrimeCustomer)
                {
                    primeCustomers.Add(customer as PrimeCustomer);
                    SavePrimeCustomersToJson(primeCustomers);
                }
                newCustomerForm.CustomerRegisteredMessage(customer);
            }
        }

        public int GetCustomerId(CustomerType customerType)
        {
            List<Customer> allCustomers = new List<Customer>();

            if (customerType == CustomerType.Basic)
            {
                allCustomers.AddRange(basicCustomers.Cast<Customer>());
                allCustomers.AddRange(primeCustomers.Cast<Customer>());
            }
            else
            {
                allCustomers.AddRange(primeCustomers.Cast<Customer>());
                allCustomers.AddRange(basicCustomers.Cast<Customer>());
            }

            if (allCustomers.Count == 0)
            {
                return 1;
            }

            int highestID = allCustomers.Max(cust => cust.CustomerId);

            for (int i = 1; i <= highestID + 1; i++)
            {
                if (!allCustomers.Any(cust => cust.CustomerId == i))
                {
                    return i;
                }
            }
            return highestID + 1;
        }

        public void DeleteCustomer(string firstName, string lastName, int customerId)
        {
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();

            List<Customer> customers = basicCustomers.Cast<Customer>().ToList();
            var customerType = "Basic";

            if (customers.Count == 0)
            {
                customers = primeCustomers.Cast<Customer>().ToList();
                customerType = "Prime";
            }

            int initialCount = customers.Count;

            customers.RemoveAll(cust =>
                cust.FirstName.ToLower() == firstName.ToLower() &&
                cust.LastName.ToLower() == lastName.ToLower() &&
                cust.CustomerId == customerId
            );

            if (customerType == "Basic")
            {
                basicCustomers = customers.Cast<BasicCustomer>().ToList();
                SaveBasicCustomersToJson(basicCustomers);
            }
            else
            {
                primeCustomers = customers.Cast<PrimeCustomer>().ToList();
                SavePrimeCustomersToJson(primeCustomers);
            }

            if (customers.Count == initialCount)
            {
                deleteCustomerForm.CustomerNotFoundMessage(firstName, lastName, customerId);
            }
            else
            {
                deleteCustomerForm.CustomerDeletedMessage(firstName, lastName, customerId);
            }
        }

        public void ViewListOfCustomers(CustomerType customerType)
        {
            List<Customer> allCustomers = new List<Customer>();

            if (customerType == CustomerType.Basic)
            {
                allCustomers.AddRange(basicCustomers);
            }
            else
            {
                allCustomers.AddRange(primeCustomers);
            }

            CustomerListView.DisplayCustomerList(allCustomers);
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

        private List<PrimeCustomer> LoadPrimeCustomersFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePathPrime);
                return JsonSerializer.Deserialize<List<PrimeCustomer>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.CustomerFileNotFoundException(); }
            return primeCustomers;
        }

        private void SaveBasicCustomersToJson(List<BasicCustomer> customers)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(customers, typeof(List<BasicCustomer>), new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(relativePathBasic, jsonData);
            }
            catch { ErrorsExceptions.CustomerFileNotFoundException(); }
        }

        private void SavePrimeCustomersToJson(List<PrimeCustomer> customers)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(customers, typeof(List<PrimeCustomer>), new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(relativePathPrime, jsonData);
            }
            catch { ErrorsExceptions.CustomerFileNotFoundException(); }
        }

        public void FindCustomerById(int customerId, CustomerType customerType)
        {
            var customers = customerType == CustomerType.Basic
                ? basicCustomers.Cast<Customer>().ToList()
                : primeCustomers.Cast<Customer>().ToList();

            Customer foundCustomer = customers.Find(cust => cust.CustomerId == customerId);
            if (foundCustomer != null)
            {
                RentLawnMowerForm.RentLawnMowerForm__(foundCustomer);
            }
            else
            {
                RentLawnMowerForm.CustomerNotFoundMessage(customerId);
            }
        }

        public List<Customer> SearchCustomers(string query, CustomerType customerType)
        {
            query = query.ToLower();
            var customers = customerType == CustomerType.Basic
                ? basicCustomers.Cast<Customer>().ToList()
                : primeCustomers.Cast<Customer>().ToList();

            return customers.Where(cust =>
                cust.FirstName.ToLower().Contains(query) ||
                cust.LastName.ToLower().Contains(query) ||
                cust.CustomerId.ToString().Contains(query) ||
                cust.Address.ToLower().Contains(query) ||
                cust.ContactNumber.ToString().Contains(query) ||
                cust.DateOfRegistry.ToString().Contains(query)
            ).ToList();
        }
        public void ConvertBasicToPrime(int customerId)
        {
            BasicCustomer basicCustomer = basicCustomers.Find(cust => cust.CustomerId == customerId);

            if (basicCustomer != null)
            {
                PrimeCustomer primeCustomer = new PrimeCustomer(basicCustomer.CustomerId)
                {
                    FirstName = basicCustomer.FirstName,
                    LastName = basicCustomer.LastName,
                    ContactNumber = basicCustomer.ContactNumber,
                    Address = basicCustomer.Address,
                    DateOfRegistry = basicCustomer.DateOfRegistry,
                    BonusPoints = 0 // I was thinking of somehow tweaking this so you could on the view set an initial amount of bonus points, could be nice for the Rent Company to implement special offers like ''Subscribe now and get 100 bonus points!''
                }; // An potentially better option is to just make an Add Points class

                primeCustomers.Add(primeCustomer);
                basicCustomers.Remove(basicCustomer);

                SaveBasicCustomersToJson(basicCustomers);
                SavePrimeCustomersToJson(primeCustomers);

            }
            else
            {
               // I'd normally put an error message here, but im leaving that for the view
            }
        }
        public void ConvertPrimeToBasic(int customerId)
        {
            PrimeCustomer primeCustomer = primeCustomers.Find(cust => cust.CustomerId == customerId);

            if (primeCustomer != null)
            {
                BasicCustomer basicCustomer = new BasicCustomer(primeCustomer.CustomerId)
                {
                    FirstName = primeCustomer.FirstName,
                    LastName = primeCustomer.LastName,
                    ContactNumber = primeCustomer.ContactNumber,
                    Address = primeCustomer.Address,
                    DateOfRegistry = primeCustomer.DateOfRegistry,
                    RemainingDiscounts = 1 // Like for prime, it feels possible to make this tweakable based on how long a customer was Prime if we wanna implement the option to make an special deal
                }; // If an Add points class is made, an Add Discounts class should be for consistency and logic

                basicCustomers.Add(basicCustomer);
                primeCustomers.Remove(primeCustomer);

                SaveBasicCustomersToJson(basicCustomers);
                SavePrimeCustomersToJson(primeCustomers);
            }
            else
            {
                // Error message can go here
            }
        }


    }
}

