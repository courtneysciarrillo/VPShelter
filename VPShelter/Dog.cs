using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Dog : VirtualPet
    {
        // Inherited 
        //public string PetType { get; set; }
        //public string PetDiet { get; set; }

        // Constructors

        public Dog()
        {
            // Default Constructor
        }

        public Dog(string name, string description, int hunger, int thirst, int boredom)
        {
            // Loaded Constructor - Accepts Values for Pet's Attributes

            this.Name = name;
            this.Description = description;
            this.Hunger = hunger;
            this.Thirst = thirst;
            this.Boredom = boredom;
        }

    }
}
