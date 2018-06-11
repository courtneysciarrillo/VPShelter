using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        // Properties

        public string VolunteerType { get; set; }

        // Constructors

        public Volunteer()
        {
            // Default Constructor
        }

        public Volunteer(string name)
        {
            // Loaded Constructor 

            this.Name = Name;
        }

        // Methods

        public string GiveWater(VirtualPet x)
        {
            x.Thirst -= 5;
            return x.Name + " has been given water.";
        }

        // Override Method

        public override string Feed(VirtualPet x)
        {
            x.Hunger -= 5;
            x.Thirst += 2;
            return x.Name + " has been fed.";
        }

        // Abstract Override Methods

        public override void ClockIn()
        {
            throw new NotImplementedException();
        }

        public override void ShowID()
        {
            throw new NotImplementedException();
        }

    }
}
