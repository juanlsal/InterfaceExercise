using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle
    {
        public bool HasTrunk { get; set; }

        public int MaxMPHSpeed { get; set; }
        public int NumOfWheels { get ; set ; }
        public bool HasAC { get ; set ; }
        public string HornSound { get ; set ; }
        public string Color { get ; set ; }
        public string Name { get; set; }
        public int Employees { get; set; }

        public void VehicleDetails()
        {
            Console.WriteLine($"The car that just entered has the following descrtions:\ncolor:{Color}\nhorn sound:{HornSound}\nnumber of wheels: {NumOfWheels}\nhas trunk: {HasTrunk}\nmax mph: {MaxMPHSpeed}\nhas AC: {HasAC}");
        }
    }
}
