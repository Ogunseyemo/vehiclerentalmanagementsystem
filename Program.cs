// See https://aka.ms/new-console-template for more information
using vehiclerentalmanagementsystem;


class Program
{
    static void Main(string[] args)
    {
        // Creating instances of vehicles
        Vehicle car = new Car("Camry", "Toyota", 2021, 50.00, 5, "V6", "Automatic", false);
        Vehicle truck = new Truck("SF90", "Ferrari", 2022, 800.00, 2.5, "Pickup", true);
        Vehicle motorcycle = new Motorcycle("Benz", "Mercedes", 2023, 40.00, 1000, "Petrol", true);

        // Creating rental agency
        RentalAgency agency = new RentalAgency(10);

        // Adding vehicles to the fleet
        agency.AddVehicle(car);
        agency.AddVehicle(truck);
        agency.AddVehicle(motorcycle);

        // Displaying details of each vehicle in the fleet
        Console.WriteLine("Details of vehicles in the fleet:");
        car.DisplayDetails();
        Console.WriteLine();
        truck.DisplayDetails();
        Console.WriteLine();
        motorcycle.DisplayDetails();
        Console.WriteLine();

        // Renting a vehicle
        Console.WriteLine("Renting a vehicle:");
        agency.RentVehicle(truck, 7);

        // Displaying total revenue
        Console.WriteLine($"Total revenue: {agency.TotalRevenue:C}");
    }
}