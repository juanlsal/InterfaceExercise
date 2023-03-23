using System;
using System.Collections.Generic;
using System.Threading;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car() { HasTrunk = true, MaxMPHSpeed = 130, NumOfWheels = 4, HasAC = true, HornSound = "Hooonk!", Color = "red", Name = "Toyota", Employees = 5000};
            var samsTruck = new Truck() {WheelSize = 20, BedSize = "King" ,NumOfWheels = 4, HasAC = false, HornSound = "HOOONKKK!", Color = "black", Name = "Honda", Employees = 50000 };
            var billsSUV = new SUV() { NumOfWheels = 4, HasAC = true, HornSound = "pppeeppp!", Color = "yellow", Name = "Mazda", Employees = 28000, CargHoldSize = 20, NumberOfPassengers = 8};
            var count = 0;
            var vehicles = new List<IVehicle>();
            vehicles.Add(myCar);
            vehicles.Add(samsTruck);
            vehicles.Add(billsSUV);
            Console.WriteLine("Congrats on your first day working the Tonys Garage, We are going to be taking notes of the vehicles that enter the shop");
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
            Console.Clear();
            foreach(var item in vehicles)
            {
                item.VehicleDetails();
                Console.WriteLine();
                item.CompanyDetails();
                count++;
                Console.WriteLine($"vehicle count: {count}");
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Thanks for helping out! Bye");
        }
    }
}
