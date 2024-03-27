using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiclerentalmanagementsystem
{
 
    public class Vehicle
    {
        // Properties
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }

        // Constructor
        public Vehicle(string model, string manufacturer, int year, double rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }

        // Method to display vehicle details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}\nManufacturer: {Manufacturer}\nYear: {Year}\nRental Price: {RentalPrice:C}");
        }
    }
}
