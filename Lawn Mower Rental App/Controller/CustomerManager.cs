using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using System.Text.Json;

namespace Lawn_Mower_Rental_App.Controller
{
    public enum CustomerType
    {
        Basic,
        Prime
    }
    public class CustomerManager
    {
        private List<BasicCustomer> basicCustomers;
        private List<PrimeCustomer> primeCustomers;
        private List<Rental> rentals;
        string relativePathBasic = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "BasicCustomerData.json");
        string relativePathPrime = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "PrimeCustomerData.json");
        string relativePathRental = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "RentalData.json");

        public CustomerManager()
        {
            basicCustomers = LoadBasicCustomersFromJson();
            primeCustomers = LoadPrimeCustomersFromJson();
            rentals = LoadRentalsFromJson();
            UpdatePrimeCustomerBonusPoints();
            ResetBasicCustomerDiscounts();
        }

        public void RegisterNewCustomer(BasicCustomer basicCustomer)
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

        public int GetCustomerId()
        {
            if(basicCustomers.Count == 0 && primeCustomers.Count == 0)
            {
                return 1;
            }
            else
            {
                int nextId = 1;
                bool idInUse;

                do
                {
                    if (basicCustomers.Any(basicCustomer => basicCustomer.CustomerId == nextId))
                    {
                        idInUse = true;
                        nextId++;
                    }
                    else if (primeCustomers.Any(primeCustomer => primeCustomer.CustomerId == nextId))
                    {
                        idInUse = true;
                        nextId++;
                    }
                    else
                    {
                        idInUse = false;
                    }
                }
                while (idInUse == true);

            return nextId;
            }
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

        public void ViewListOfCustomers()
        {
            CustomerListView.DisplayCustomerList(basicCustomers, primeCustomers);
        }

        private List<BasicCustomer> LoadBasicCustomersFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePathBasic);
                return JsonSerializer.Deserialize<List<BasicCustomer>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.BasicCustomerFileNotFoundException(); }
            return basicCustomers;
        }

        private List<PrimeCustomer> LoadPrimeCustomersFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePathPrime);
                return JsonSerializer.Deserialize<List<PrimeCustomer>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.PrimeCustomerFileNotFoundException(); }
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
            catch { ErrorsExceptions.BasicCustomerFileNotFoundException(); }
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
            catch { ErrorsExceptions.PrimeCustomerFileNotFoundException(); }
        }

        public void FindCustomerById(int customerId)
        {
            BasicCustomer basicCustomer = basicCustomers.Find(customer => customer.CustomerId == customerId);

            if (basicCustomer != null)
            {
                RentLawnMowerForm.RentLawnMowerForm__(basicCustomer);
            }

            else
            {
                PrimeCustomer primeCustomer = primeCustomers.Find(customer => customer.CustomerId == customerId);

                if(primeCustomer != null)
                {
                    RentLawnMowerForm.RentLawnMowerForm__(primeCustomer);
                }

                else
                {
                    RentLawnMowerForm.CustomerNotFoundMessage(customerId);
                }
            }
        }

        public void SearchCustomers(string query)
        {
            query = query.ToLower();

            List<BasicCustomer> basicCustomersSearch = basicCustomers.Where(basicCustomer =>
                basicCustomer.FirstName.ToLower().Contains(query) ||
                basicCustomer.LastName.ToLower().Contains(query) ||
                basicCustomer.CustomerId.ToString().Contains(query) ||
                basicCustomer.Address.ToLower().Contains(query) ||
                basicCustomer.ContactNumber.ToString().Contains(query) ||
                basicCustomer.DateOfRegistry.ToString().Contains(query)
            ).ToList();

            List<PrimeCustomer> primeCustomersSearch = primeCustomers.Where(primeCustomer =>
                primeCustomer.FirstName.ToLower().Contains(query) ||
                primeCustomer.LastName.ToLower().Contains(query) ||
                primeCustomer.CustomerId.ToString().Contains(query) ||
                primeCustomer.Address.ToLower().Contains(query) ||
                primeCustomer.ContactNumber.ToString().Contains(query) ||
                primeCustomer.DateOfRegistry.ToString().Contains(query)
            ).ToList();

            CustomerSearchView.DisplaySearchResult(basicCustomersSearch, primeCustomersSearch);
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
                    BonusPoints = 0 
                }; 

                primeCustomers.Add(primeCustomer);
                basicCustomers.Remove(basicCustomer);

                SaveBasicCustomersToJson(basicCustomers);
                SavePrimeCustomersToJson(primeCustomers);

            }
            else
            {
                ErrorsExceptions.BasicCustomerNotFoundException();
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
                    RemainingDiscounts = 1 
                }; 

                basicCustomers.Add(basicCustomer);
                primeCustomers.Remove(primeCustomer);

                SaveBasicCustomersToJson(basicCustomers);
                SavePrimeCustomersToJson(primeCustomers);
            }
            else
            {
                ErrorsExceptions.PrimeCustomerNotFoundException();
            }
        }

        public void AddBonusPointsToPrimeCustomer(int customerId, int bonusPointsToAdd)
        {
            PrimeCustomer primeCustomer = primeCustomers.Find(cust => cust.CustomerId == customerId);

            if (primeCustomer != null)
            {
                primeCustomer.BonusPoints += bonusPointsToAdd;
                SavePrimeCustomersToJson(primeCustomers);
            }
        }

        public void AddDiscountsToBasicCustomer(int customerId, int discountsToAdd)
        {
            BasicCustomer basicCustomer = basicCustomers.Find(cust => cust.CustomerId == customerId);

            if (basicCustomer != null)
            {
                basicCustomer.RemainingDiscounts += discountsToAdd;
                SaveBasicCustomersToJson(basicCustomers);
            }
        }

        private List<Rental> LoadRentalsFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePathRental);
                return JsonSerializer.Deserialize<List<Rental>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.RentalsFileNotFoundException(); }
            return new List<Rental>();
        }

        public void UpdatePrimeCustomerBonusPoints()
        {
            foreach (PrimeCustomer primeCustomer in primeCustomers)
            {
                decimal customerSpending = CalculateCustomerSpending(primeCustomer.CustomerId);
                int bonusPointsToAdd = (int)(customerSpending / 1); // 1 Point for Every 1 SEK
                primeCustomer.BonusPoints = bonusPointsToAdd;
            }
            SavePrimeCustomersToJson(primeCustomers);
        }

        private decimal CalculateCustomerSpending(int customerId)
        {
            return rentals
                .Where(rental => rental.Customer.CustomerId == customerId)
                .Sum(rental => rental.TotalPrice);
        }

        public bool TryFindCustomerById(int customerId, out Customer customer)
        {
            BasicCustomer basicCustomer = basicCustomers.Find(customer => customer.CustomerId == customerId);
            if (basicCustomer != null)
            {
                customer = basicCustomer;
                return true;
            }

            PrimeCustomer primeCustomer = primeCustomers.Find(customer => customer.CustomerId == customerId);
            if (primeCustomer != null)
            {
                customer = primeCustomer;
                return true;
            }

            customer = null;
            return false;
        }
        public void ChangeCustomerTypeById(int customerId)
        {
            ChangeCustomerView changeCustomerView = new ChangeCustomerView();

            BasicCustomer basicCustomer = basicCustomers.Find(customer => customer.CustomerId == customerId);

            if (basicCustomer != null)
            {
                changeCustomerView.UpgradeBasicToPrime(customerId);
            }

            else
            {
                PrimeCustomer primeCustomer = primeCustomers.Find(customer => customer.CustomerId == customerId);

                if (primeCustomer != null)
                {
                    changeCustomerView.DowngradePrimeToBasic(customerId);
                }

                else
                {
                    changeCustomerView.CustomerNotFound(customerId);
                }
            }
        }

        public void ResetBasicCustomerDiscounts()
        {
            if (DateTime.Today.Month == 1 && DateTime.Today.Day == 1)
            {
                foreach (BasicCustomer basicCustomer in basicCustomers)
                {
                    if (basicCustomer.RemainingDiscounts == 0)
                    {
                        basicCustomer.RemainingDiscounts = 1;
                    }
                }
            }
        }
        public void WithdrawCustomerBonusPoints(int customerId, int bonusPointsToWithdraw)
        {
            PrimeCustomer primeCustomer = primeCustomers.Find(cust => cust.CustomerId == customerId);

            if (primeCustomer != null)
            {
                if (primeCustomer.BonusPoints >= bonusPointsToWithdraw)
                {
                    primeCustomer.BonusPoints -= bonusPointsToWithdraw;
                    SavePrimeCustomersToJson(primeCustomers);
                }
            }
        }
    }
}

