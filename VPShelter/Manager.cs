using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee
    {
        // Properties

        public int YearsEmployed { get; set; }

        // Constructors 

        public Manager()
        {
            // Default Constructor
        }

        public Manager(string name)
        {
            // Loaded Constructor

            this.Name = Name;
        }

        // Methods

        public string Adopt(List<VirtualPet> pets, VirtualPet x)
        {
            pets.Remove(x);
            return "Ok, you adopted " + x.Name + ".";
        }

        // Override Method

        public override string Play(VirtualPet x)
        {
            x.Boredom -= 4;
            return "Ok, you played with " + x.Name + ".";
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
