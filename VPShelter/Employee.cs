using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    abstract class Employee
    {
        // Properties

        public int EmployeeID { get; set; }
        public string Name { get; set; }

        // Constructors 

        public Employee()
        {
            // Default Constructor
        }

        // Methods
        
        public virtual string Play(VirtualPet x)
        {
            x.Boredom -= 5;
            return "Ok, you played with " + x.Name + ".";
        }

        public virtual string Feed(VirtualPet x)
        {
            x.Hunger -= 4;
            x.Thirst += 1;
            return x.Name + " has been fed.";
        }

        // Abstract Methods 

        public abstract void ClockIn();

        public abstract void ShowID();

    }
}
