using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPet
    {
        // Properties

        public string Name { get; set; }
        public string Description { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }
        public string PetType { get; set; }
        public string PetDiet { get; set; }

        // Constructors

        public VirtualPet()
        {
            // Default Constructor
        }

        public VirtualPet(string name, string description)
        {
            // Loaded Constructor - Name and Description Only

            this.Name = name;
            this.Description = description;
        }

        public VirtualPet(string name, string description, int hunger, int thirst, int boredom)
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
