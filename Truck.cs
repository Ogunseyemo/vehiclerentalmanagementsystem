using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiclerentalmanagementsystem
{
    using System;

    public class Truck : Vehicle
    {
        // Additional properties for trucks
        public double Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        // Constructor
        public Truck(string model, string manufacturer, int year, double rentalPrice, double capacity, string truckType, bool fourWheelDrive) : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        // Override method to display truck details
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {Capacity} tons\nTruck Type: {TruckType}\nFour-Wheel Drive: {FourWheelDrive}");
        }
    }
}
