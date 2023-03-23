using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle
    {
        public int WheelSize { get; set; }
        public string BedSize { get; set; }
        public int NumOfWheels { get; set; }
        public bool HasAC { get; set; }
        public string HornSound { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public int Employees { get; set; }

        public void VehicleDetails()
        {
            Console.WriteLine($"The car that just entered has the following descrtions:\ncolor:{Color}\nhorn sound:{HornSound}\nnumber of wheels: {NumOfWheels}\nbed size: {BedSize}\nwheel size: {WheelSize}\nhas AC: {HasAC}");
        }
    }
}
