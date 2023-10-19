﻿using Lawn_Mower_Rental_App.Model;
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
                if (File.Exists(relativePath))
                {
                    string jsonData = File.ReadAllText(relativePath);
                    return JsonSerializer.Deserialize<List<Rental>>(jsonData);
                }
            }
            catch (Exception) { ErrorsExceptions.CustomerFileNotFoundException(); }    //Create a specific RentalFileNotFoundException view
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
            catch { ErrorsExceptions.CustomerFileNotFoundException(); } //Create a specific RentalFileNotFoundException view

        }

        public Rental RentLawnMower(Customer customer, DateTime rentalDate, DateTime returnDate)
        {
            LawnMowerManager lawnMowerManager = new LawnMowerManager();

            Rental rental = new Rental(GetRentalId());
            rental.Customer = customer;
            rental.RentalDate = rentalDate;
            rental.ReturnDate = returnDate;
            rental.LawnMower = lawnMowerManager.FindLawnMowerById();

            decimal pricePerDay = rental.LawnMower.PricePerDay;
            TimeSpan rentalPeriod = returnDate - rentalDate;
            decimal totalPrice = pricePerDay * (decimal)rentalPeriod.TotalDays;
            rental.TotalPrice = totalPrice;
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
    }
}

