using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiclerentalmanagementsystem
{

    public class RentalAgency
    {
        // Array to store fleet of vehicles
        private Vehicle[] Fleet;
        private int numOfVehicles;
        public double TotalRevenue { get; private set; }

        // Constructor
        public RentalAgency(int capacity)
        {
            Fleet = new Vehicle[capacity];
            numOfVehicles = 0;
            TotalRevenue = 0;
        }

        // Method to add vehicles to the fleet
        public void AddVehicle(Vehicle vehicle)
        {
            if (numOfVehicles < Fleet.Length)
            {
                Fleet[numOfVehicles] = vehicle;
                numOfVehicles++;
            }
            else
            {
                Console.WriteLine("Fleet is full. Cannot add more vehicles.");
            }
        }

        // Method to remove vehicles from the fleet
        public void RemoveVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < numOfVehicles; i++)
            {
                if (Fleet[i] == vehicle)
                {
                    for (int j = i; j < numOfVehicles - 1; j++)
                    {
                        Fleet[j] = Fleet[j + 1];
                    }
                    numOfVehicles--;
                    Console.WriteLine("Vehicle removed from the fleet.");
                    return;
                }
            }
            Console.WriteLine("Vehicle not found in the fleet.");
        }

        // Method to rent a vehicle
        public void RentVehicle(Vehicle vehicle, int days)
        {
            if (numOfVehicles == 0)
            {
                Console.WriteLine("No vehicles available for rent.");
                return;
            }

            for (int i = 0; i < numOfVehicles; i++)
            {
                if (Fleet[i] == vehicle)
                {
                    double rentalCost = days * Fleet[i].RentalPrice;
                    TotalRevenue += rentalCost;
                    Console.WriteLine($"Vehicle rented for {days} days. Total cost: {rentalCost:C}");
                    RemoveVehicle(vehicle);
                    return;
                }
            }
            Console.WriteLine("Vehicle not found in the fleet.");
        }
    }
}
