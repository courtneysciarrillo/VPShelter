using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPetShelter
    {
        // Properties

        public List<VirtualPet> Pets { get; set; }
        public List<Employee> Employees { get; set; }

        // Constructors

        public VirtualPetShelter()
        {
            // Default Constructor
        }

        public void SetPets(List<VirtualPet> pets, VirtualPet x)
        {
            pets.Add(x);
        }

        public void SetEmployees(List<Employee> employees, Employee x)
        {
            employees.Add(x);
        }

    }
}
