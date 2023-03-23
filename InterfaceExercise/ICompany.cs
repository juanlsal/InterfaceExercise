using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string Name { get; set; }
        public int Employees { get; set; }

        public void CompanyDetails()
        {
            Console.WriteLine($"Looks like this vehicle is from {Name}, also did you know they have over {Employees} employees hired!");
        }
    }
}
