using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPetShelter vpshelter = new VirtualPetShelter();
            Manager manager = new Manager();
            Volunteer volunteer = new Volunteer();

            vpshelter.Pets = new List<VirtualPet>();
            vpshelter.Employees = new List<Employee>();

            Dog jack = new Dog("Jack", "Dog", 83, 34, 23);
            Dog john = new Dog("John", "Dog", 69, 49, 02);
            Cat paul = new Cat("Paul", "Cat", 39, 18, 88);
            Cat glen = new Cat("Glen", "Cat", 59, 19, 37);

            vpshelter.SetPets(vpshelter.Pets, jack);
            vpshelter.SetPets(vpshelter.Pets, john);
            vpshelter.SetPets(vpshelter.Pets, paul);
            vpshelter.SetPets(vpshelter.Pets, glen);

            Manager courtney = new Manager("Courtney");
            Manager pete = new Manager("Pete");
            Volunteer heidi = new Volunteer("Heidi");
            Volunteer mark = new Volunteer("Mark");

            vpshelter.SetEmployees(vpshelter.Employees, courtney);
            vpshelter.SetEmployees(vpshelter.Employees, pete);
            vpshelter.SetEmployees(vpshelter.Employees, heidi);
            vpshelter.SetEmployees(vpshelter.Employees, mark);

            Console.WriteLine("Would you like to play Virtual Pet Shelter?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.WriteLine();

            Console.Write("> ");
            string userResp = Console.ReadLine();
            Console.Clear();

            while (userResp == "1") // Setting a Game Loop
            {
                Console.WriteLine("Welcome to Courtney's Virtual Pet Shelter. What employee type are you?");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Volunteer");
                Console.WriteLine("3. Quit");
                Console.WriteLine();

                Console.Write("> ");
                string employeeResp = Console.ReadLine();

                Console.WriteLine("\nThank you for working at Courtney's Virtual Pet Shelter!\n");

                if (employeeResp == "3")
                {
                    Console.Clear();
                    userResp = "0";
                }

                while (employeeResp == "1") // Manager Menu
                {
                    Console.WriteLine("Which manager are you?");
                    Console.WriteLine("1. Courtney");
                    Console.WriteLine("2. Pete");
                    Console.WriteLine("3. Switch employee type");
                    Console.WriteLine("4. Quit");
                    Console.WriteLine();

                    Console.Write("> ");
                    string userMgr = Console.ReadLine();

                    if(userMgr == "3")
                    {
                        Console.Clear();
                        employeeResp = "0";
                    }
                    if (userMgr == "4")
                    {
                        Console.Clear();
                        employeeResp = "0";
                        userResp = "2";
                    }

                    while (userMgr == "1" || userMgr == "2")
                    {
                        Console.WriteLine("\nWhat would you like to do?");
                        Console.WriteLine("1. Adopt a pet");
                        Console.WriteLine("2. Feed the pets");
                        Console.WriteLine("3. Play with a pet");
                        Console.WriteLine("4. View status of your pets");
                        Console.WriteLine("5. Switch user");
                        Console.WriteLine("6. Switch employee type");
                        Console.WriteLine("7. Quit");
                        Console.WriteLine();

                        Console.Write("> ");
                        string mgrResp = Console.ReadLine();

                        switch (mgrResp)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Ok, you'd like to adopt a pet. Please choose one:\n");

                                for (int i = 0; i < vpshelter.Pets.Count; i++)
                                {
                                    Console.WriteLine("For [" + vpshelter.Pets[i].Name + "] type " + i);
                                }
                                Console.WriteLine("\nWhich pet would you like to adopt?\n");

                                Console.Write("> ");
                                string adoptResp = Console.ReadLine().ToLower();

                                switch (adoptResp)
                                {
                                    case "0":
                                        Console.Clear();
                                        Console.WriteLine(manager.Adopt(vpshelter.Pets, vpshelter.Pets[0]) + "\n");
                                        break;
                                    case "1":
                                        Console.Clear();
                                        Console.WriteLine(manager.Adopt(vpshelter.Pets, vpshelter.Pets[1]) + "\n");
                                        break;
                                    case "2":
                                        Console.Clear();
                                        Console.WriteLine(manager.Adopt(vpshelter.Pets, vpshelter.Pets[2]) + "\n");
                                        break;
                                    case "3":
                                        Console.Clear();
                                        Console.WriteLine(manager.Adopt(vpshelter.Pets, vpshelter.Pets[3]) + "\n");
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Ok, you'd like to feed a pet. Please choose one:\n");
                                for (int i = 0; i < vpshelter.Pets.Count; i++)
                                {
                                    Console.WriteLine("For [" + vpshelter.Pets[i].Name + "] type " + i);
                                }
                                Console.WriteLine("For [All Pets] type all\n");
                                Console.WriteLine("Which pet would you like to feed?\n");

                                Console.Write("> ");
                                string feedResp = Console.ReadLine().ToLower();
                                Console.Clear();

                                switch (feedResp)
                                {
                                    case "0":
                                        Console.WriteLine(manager.Feed(vpshelter.Pets[0]));
                                        Console.WriteLine("Hunger: " + vpshelter.Pets[0].Hunger + "\n");
                                        break;
                                    case "1":
                                        Console.WriteLine(manager.Feed(vpshelter.Pets[1]));
                                        Console.WriteLine("Hunger: " + vpshelter.Pets[1].Hunger + "\n");
                                        break;
                                    case "2":
                                        Console.WriteLine(manager.Feed(vpshelter.Pets[2]));
                                        Console.WriteLine("Hunger: " + vpshelter.Pets[2].Hunger + "\n");
                                        break;
                                    case "3":
                                        Console.WriteLine(manager.Feed(vpshelter.Pets[3]));
                                        Console.WriteLine("Hunger: " + vpshelter.Pets[3].Hunger + "\n");
                                        break;
                                    case "all":
                                        for (int i = 0; i < vpshelter.Pets.Count; i++)
                                        {
                                            Console.WriteLine(manager.Feed(vpshelter.Pets[i]));
                                            Console.WriteLine("Hunger: " + vpshelter.Pets[i].Hunger + "\n");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Ok, you'd like to play with a pet. Please choose one:\n");
                                for (int i = 0; i < vpshelter.Pets.Count; i++)
                                {
                                    Console.WriteLine("For [" + vpshelter.Pets[i].Name + "] type " + i);
                                }
                                Console.WriteLine("For [All Pets] type all\n");
                                Console.WriteLine("Which pet would you like to play with?\n");

                                Console.Write("> ");
                                string playResp = Console.ReadLine().ToLower();
                                Console.Clear();

                                switch (playResp)
                                {
                                    case "0":
                                        Console.WriteLine(manager.Play(vpshelter.Pets[0]));
                                        Console.WriteLine("Boredom: " + vpshelter.Pets[0].Boredom + "\n");
                                        break;
                                    case "1":
                                        Console.WriteLine(manager.Play(vpshelter.Pets[1]));
                                        Console.WriteLine("Boredom: " + vpshelter.Pets[1].Boredom + "\n");
                                        break;
                                    case "2":
                                        Console.WriteLine(manager.Play(vpshelter.Pets[2]));
                                        Console.WriteLine("Boredom: " + vpshelter.Pets[2].Boredom + "\n");
                                        break;
                                    case "3":
                                        Console.WriteLine(manager.Play(vpshelter.Pets[3]));
                                        Console.WriteLine("Boredom: " + vpshelter.Pets[3].Boredom + "\n");
                                        break;
                                    case "all":
                                        for (int i = 0; i < vpshelter.Pets.Count; i++)
                                        {
                                            Console.WriteLine(manager.Play(vpshelter.Pets[i]));
                                            Console.WriteLine("Boredom: " + vpshelter.Pets[i].Boredom + "\n");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "4":
                                Console.Clear();
                                Console.WriteLine("This is the status of your pets:\n");
                                Console.WriteLine("Name    Desc.   Hunger  Thirst  Boredom");
                                Console.WriteLine("------- ------- ------- ------- -------");

                                for (int i = 0; i < vpshelter.Pets.Count; i++)
                                {
                                    Console.WriteLine("{0}     {1}    {2}      {3}      {4}", vpshelter.Pets[i].Name, vpshelter.Pets[i].Description, vpshelter.Pets[i].Hunger, vpshelter.Pets[i].Thirst, vpshelter.Pets[i].Boredom);
                                }
                                Console.WriteLine();
                                break;
                            case "5":
                                Console.Clear();
                                userMgr = "0";
                                break;
                            case "6":
                                Console.Clear();
                                userMgr = "0";
                                employeeResp = "0";
                                break;
                            case "7":
                                Console.Clear();
                                userMgr = "0";
                                employeeResp = "0";
                                userResp = "2";
                                break;
                            default:
                                break;
                        }
                    }

                }

                while (employeeResp == "2") // Volunteer Menu
                {
                    Console.WriteLine("Which volunteer are you?");
                    Console.WriteLine("1. Heidi");
                    Console.WriteLine("2. Mark");
                    Console.WriteLine("3. Switch employee type");
                    Console.WriteLine("4. Quit");
                    Console.WriteLine();

                    Console.Write("> ");
                    string userVol = Console.ReadLine();

                    if (userVol == "3")
                    {
                        Console.Clear();
                        employeeResp = "0";
                    }
                    if (userVol == "4")
                    {
                        Console.Clear();
                        employeeResp = "0";
                        userResp = "2";
                    }

                    while (userVol == "1" || userVol == "2")
                    {
                        Console.WriteLine("\nWhat would you like to do?");
                        Console.WriteLine("1. Feed the pets");
                        Console.WriteLine("2. Give water to the pets");
                        Console.WriteLine("3. Play with a pet");
                        Console.WriteLine("4. View status of your pets");
                        Console.WriteLine("5. Switch user");
                        Console.WriteLine("6. Switch employee type");
                        Console.WriteLine("7. Quit");
                        Console.WriteLine();

                        Console.Write("> ");
                        string volResp = Console.ReadLine();

                        switch (volResp)
                        {
                            case "1": // Feed the pets
                                Console.Clear();
                                Console.WriteLine("Ok, you'd like to feed a pet. Please choose one:\n");
                                for (int i = 0; i < vpshelter.Pets.Count; i++)
                                {
                                    Console.WriteLine("For [" + vpshelter.Pets[i].Name + "] type " + i);
                                }
                                Console.WriteLine("For [All Pets] type all\n");
                                Console.WriteLine("Which pet would you like to feed?\n");

                                Console.Write("> ");
                                string feedResp = Console.ReadLine().ToLower();
                                Console.Clear();

                                switch (feedResp)
                                {
                                    case "0":
                                        Console.WriteLine(volunteer.Feed(vpshelter.Pets[0]));
                                        Console.WriteLine("Hunger: " + vpshelter.Pets[0].Hunger + "\n");
                                        break;
                                    case "1":
                                        Console.WriteLine(volunteer.Feed(vpshelter.Pets[1]));
                                        Console.WriteLine("Hunger: " + vpshelter.Pets[1].Hunger + "\n");
                                        break;
                                    case "2":
                                        Console.WriteLine(volunteer.Feed(vpshelter.Pets[2]));
                                        Console.WriteLine("Hunger: " + vpshelter.Pets[2].Hunger + "\n");
                                        break;
                                    case "3":
                                        Console.WriteLine(volunteer.Feed(vpshelter.Pets[3]));
                                        Console.WriteLine("Hunger: " + vpshelter.Pets[3].Hunger + "\n");
                                        break;
                                    case "all":
                                        for (int i = 0; i < vpshelter.Pets.Count; i++)
                                        {
                                            Console.WriteLine(volunteer.Feed(vpshelter.Pets[i]));
                                            Console.WriteLine("Hunger: " + vpshelter.Pets[i].Hunger + "\n");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "2": // Give water to the pets
                                Console.Clear();
                                Console.WriteLine("Ok, you'd like to give water to a pet. Please choose one:\n");
                                for (int i = 0; i < vpshelter.Pets.Count; i++)
                                {
                                    Console.WriteLine("For [" + vpshelter.Pets[i].Name + "] type " + i);
                                }
                                Console.WriteLine("For [All Pets] type all\n");
                                Console.WriteLine("Which pet would you like to give water?\n");

                                Console.Write("> ");
                                string waterResp = Console.ReadLine().ToLower();
                                Console.Clear();

                                switch (waterResp)
                                {
                                    case "0":
                                        Console.WriteLine(volunteer.GiveWater(vpshelter.Pets[0]));
                                        Console.WriteLine("Thirst: " + vpshelter.Pets[0].Thirst + "\n");
                                        break;
                                    case "1":
                                        Console.WriteLine(volunteer.GiveWater(vpshelter.Pets[1]));
                                        Console.WriteLine("Thirst: " + vpshelter.Pets[1].Thirst + "\n");
                                        break;
                                    case "2":
                                        Console.WriteLine(volunteer.GiveWater(vpshelter.Pets[2]));
                                        Console.WriteLine("Thirst: " + vpshelter.Pets[2].Thirst + "\n");
                                        break;
                                    case "3":
                                        Console.WriteLine(volunteer.GiveWater(vpshelter.Pets[3]));
                                        Console.WriteLine("Thirst: " + vpshelter.Pets[3].Thirst + "\n");
                                        break;
                                    case "all":
                                        for (int i = 0; i < vpshelter.Pets.Count; i++)
                                        {
                                            Console.WriteLine(volunteer.GiveWater(vpshelter.Pets[i]));
                                            Console.WriteLine("Thirst: " + vpshelter.Pets[i].Thirst + "\n");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "3": // Play with a pet
                                Console.Clear();
                                Console.WriteLine("Ok, you'd like to play with a pet. Please choose one:\n");
                                for (int i = 0; i < vpshelter.Pets.Count; i++)
                                {
                                    Console.WriteLine("For [" + vpshelter.Pets[i].Name + "] type " + i);
                                }
                                Console.WriteLine("For [All Pets] type all\n");
                                Console.WriteLine("Which pet would you like to play with?\n");

                                Console.Write("> ");
                                string playResp = Console.ReadLine().ToLower();
                                Console.Clear();

                                switch (playResp)
                                {
                                    case "0":
                                        Console.WriteLine(volunteer.Play(vpshelter.Pets[0]));
                                        Console.WriteLine("Boredom: " + vpshelter.Pets[0].Boredom + "\n");
                                        break;
                                    case "1":
                                        Console.WriteLine(volunteer.Play(vpshelter.Pets[1]));
                                        Console.WriteLine("Boredom: " + vpshelter.Pets[1].Boredom + "\n");
                                        break;
                                    case "2":
                                        Console.WriteLine(volunteer.Play(vpshelter.Pets[2]));
                                        Console.WriteLine("Boredom: " + vpshelter.Pets[2].Boredom + "\n");
                                        break;
                                    case "3":
                                        Console.WriteLine(volunteer.Play(vpshelter.Pets[3]));
                                        Console.WriteLine("Boredom: " + vpshelter.Pets[3].Boredom + "\n");
                                        break;
                                    case "all":
                                        for (int i = 0; i < vpshelter.Pets.Count; i++)
                                        {
                                            Console.WriteLine(volunteer.Play(vpshelter.Pets[i]));
                                            Console.WriteLine("Boredom: " + vpshelter.Pets[i].Boredom + "\n");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "4": // View the status of your pets
                                Console.Clear();
                                Console.WriteLine("This is the status of your pets:\n");
                                Console.WriteLine("Name    Desc.   Hunger  Thirst  Boredom");
                                Console.WriteLine("------- ------- ------- ------- -------");

                                for (int i = 0; i < vpshelter.Pets.Count; i++)
                                {
                                    Console.WriteLine("{0}     {1}    {2}      {3}      {4}", vpshelter.Pets[i].Name, vpshelter.Pets[i].Description, vpshelter.Pets[i].Hunger, vpshelter.Pets[i].Thirst, vpshelter.Pets[i].Boredom);
                                }
                                Console.WriteLine();
                                break;
                            case "5":
                                Console.Clear();
                                userVol = "0";
                                break;
                            case "6":
                                Console.Clear();
                                userVol = "0";
                                employeeResp = "0";
                                break;
                            case "7": // Quit
                                Console.Clear();
                                userVol = "0";
                                employeeResp = "0";
                                userResp = "2";
                                break;
                            default:
                                break;
                        }

                    }

                }
                
            }

            Console.WriteLine("Thanks for playing!");

        }
    }
}
