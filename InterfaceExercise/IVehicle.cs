using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public int NumOfWheels { get; set; }
        public bool HasAC { get; set; }
        public string HornSound { get; set; }
        public string Color { get; set; }

        public abstract void VehicleDetails();


    }
}
