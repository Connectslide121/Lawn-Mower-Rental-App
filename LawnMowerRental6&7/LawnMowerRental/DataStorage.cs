

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

static class DataStorage
{
    public static List<Customer> customers = new List<Customer>();
    public static List<LawnMower> lawnMowers = new List<LawnMower>();
    public static List<Rental> rentals = new List<Rental>();
    const string dataFile = "data.json";

    public static void LoadDataFromJson()
    {
        // Implementation of LoadDataFromJson method
    }

    public static void SaveDataToJson()
    {
        // Implementation of SaveDataToJson method
    }
}
