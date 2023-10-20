using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Controller
{
    public class RentalManager
    {
        private List<Rental> rentals;
        string relativePath = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "RentalData.json");

        public RentalManager() 
        {
            rentals = LoadRentalsFromJson();
            UpdateLawnMowerAvailability();
        }

        public int GetRentalId()
        {
            if (rentals.Count == 0)
            {
                return 1;
            }

            int highestID = rentals.Max(rental => rental.RentalId);

            for (int i = 1; i <= highestID + 1; i++)
            {
                if (!rentals.Any(rental => rental.RentalId == i))
                {
                    return i;
                }
            }

            return highestID + 1;
        }

        private List<Rental> LoadRentalsFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePath);
                return JsonSerializer.Deserialize<List<Rental>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.RentalsFileNotFoundException(); }
            return rentals;
        }

        private void SaveRentalsToJson(List<Rental> rentals)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(rentals, typeof(List<Rental>), new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(relativePath, jsonData);
            }
            catch { ErrorsExceptions.RentalsFileNotFoundException(); }
        }

        public Rental RentLawnMower(Customer customer, DateTime rentalDate, DateTime returnDate)
        {
            LawnMowerManager lawnMowerManager = new LawnMowerManager();

            LawnMower lawnMower = lawnMowerManager.FindLawnMowerById();
            Rental rental = new Rental(GetRentalId());
            rental.Customer = customer;
            rental.RentalDate = rentalDate;
            rental.ReturnDate = returnDate;
            rental.LawnMower = lawnMower;

            // Calculate TotalPrice using PricePerDay
            decimal pricePerDay = rental.LawnMower.PricePerDay;
            TimeSpan rentalPeriod = returnDate - rentalDate;
            decimal totalPrice = pricePerDay * (decimal)rentalPeriod.TotalDays;
            rental.TotalPrice = totalPrice;

            // Calculate TotalCost using CostPerDay
            decimal costPerDay = rental.LawnMower.CostPerDay;
            decimal totalCost =costPerDay * (decimal)rentalPeriod.TotalDays;
            rental.TotalCost = totalCost;

            return rental;
        }

        public void AddRentalToList(Rental rental)
        {
            rentals.Add(rental);
            SaveRentalsToJson(rentals);
        }

        public List<Rental> GetActiveRentals()
        {
            List<Rental> activeRentals = rentals
                .Where(rental=> rental.IsActive == true)
                .ToList();

            return activeRentals;
        }

        public List<Rental> GetRentalHistory()
        {
            List<Rental> rentalHistory = rentals
                .Where(rental => rental.IsActive == false)
                .ToList();

            return rentalHistory;
        }
        public void UpdateLawnMowerAvailability()
        {
            foreach (Rental rental in rentals)
            {
                if (DateTime.Today >= rental.RentalDate && DateTime.Today <= rental.ReturnDate)
                {
                    rental.LawnMower.IsAvailable = false;
                }
                else if (DateTime.Today !>= rental.RentalDate && DateTime.Today !<= rental.ReturnDate)
                {
                    rental.LawnMower.IsAvailable = true;
                }
            }
            SaveRentalsToJson(rentals);
        }

        public void ViewReturnsToday()
        {
            List<Rental> returnsToday = rentals
                .Where(rental => rental.ReturnDate == DateTime.Today)
                .ToList();

            ViewReturnToday.ViewReturnToday_(returnsToday);
        }
        public void GetDelayedRentals()
        {
            DateTime today = DateTime.Today;
            List<Rental> delayedRentals = rentals
                .Where(rental => rental.ReturnDate < today && rental.IsActive)
                .ToList();

            ViewDelayedRentals.ViewDelayedRentals_(delayedRentals);
        }

        public int ReturnLawnMower(int rentalId)
        {
            Rental rentalToUpdate = rentals.Find(m => m.RentalId == rentalId);
            
            if(rentalToUpdate != null)
            {
                rentalToUpdate.IsActive = false;
                SaveRentalsToJson(rentals);
                ReturnLawnMowerForm.LawnMowerReturnedSuccessfullyMessage(rentalId);

            }
            else
            {
                ReturnLawnMowerForm.LawnMowerReturnedFailMessage(rentalId);
            }

            return rentalToUpdate.LawnMower.LawnMowerId;
        }
        public decimal CalculateTotalEarnings()
        {
            return rentals.Where(rental => !rental.IsActive).Sum(rental => rental.TotalPrice);
        }

        public decimal CalculateTotalCosts()
        {
            return rentals.Where(rental => !rental.IsActive).Sum(rental => rental.TotalCost);
        }

        public decimal CalculateTotalProfit()
        {
            return rentals.Where(rental => !rental.IsActive).Sum(rental => rental.TotalPrice - rental.TotalCost);
        }


    }
}

