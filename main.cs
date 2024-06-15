
namespace program
{

    public class Program
    {
        public static void Main()
        {
            Vehicle vehicle = new Vehicle();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nLibrary menu:");
                Console.WriteLine("1. Add car");
                Console.WriteLine("2. Edit car");
                Console.WriteLine("3. Search car");
                Console.WriteLine("4. List of cars");
                Console.WriteLine("5. Choose car for an action");
                Console.WriteLine("6. Exit!");
                Console.ResetColor();

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            AddCar(vehicle);
                            break;
                        case 2:
                            EditCar(vehicle);
                            break;
                        case 3:
                            SearchChoose(vehicle);
                            break;
                        case 4:
                            ListCars(vehicle);
                            break;
                        case 5:
                            ChooseCarAction(vehicle);
                            break;
                        case 6:
                            return;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid option! Please try again!");
                            break;
                    }
                }

            }
        }

        static void AddCar(Vehicle vehicle)
        {
            Console.WriteLine("Enter a mark of a car:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a manufacturer country:");
            string country = Console.ReadLine();
            Console.WriteLine("Enter a year of the vehicle");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                Car car = new Car(name, country, year);
                Vehicle.AddCar(car);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input!");
            }
            
            Console.ResetColor();
        }

        static void EditCar(Vehicle vehicle)
        {
            Console.WriteLine("Enter a mark of a car: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a new mark of a car");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter a new manufacturer country");
            string newCountry = Console.ReadLine();
            Console.WriteLine("Enter a year of the car");
            if (int.TryParse(Console.ReadLine(), out int newYear))
            {
                Vehicle.EditCar(name, newName, newCountry, newYear);
                int milliseconds = 5000;
                Thread.Sleep(milliseconds);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid input! Please enter a number");
                
                Console.ResetColor();
            }

            
        }

        static void SearchChoose(Vehicle vehicle)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose the parameters by which you will search for a car!\n1. Mark\n2. Country manufacturer.\n3. Year\n4. Back to the menu");
            Console.ResetColor();
            if (int.TryParse(Console.ReadLine(), out int UserChoice))
            {
                switch (UserChoice)
                {
                    case 1:
                        SearchCarByName(vehicle);
                        break;
                    case 2:
                        SearchCarByCountry(vehicle);
                        break;
                    case 3:
                        SearchCarByYear(vehicle);
                        break;
                    case 4:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid option! Please try again!");
                        break;
                        Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please. enter a number");
                Console.ResetColor();
            }
        }
        
        static void SearchCarByName(Vehicle vehicle)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter a mark of a car");
            Console.ResetColor();
            string name = Console.ReadLine();
            
            Vehicle.SearchCarByName(name);
            int milliseconds = 5000;
            Thread.Sleep(milliseconds);
        }

        static void SearchCarByCountry(Vehicle vehicle)
        {
            Console.WriteLine("Enter a country manufacturer of the car");
            string country = Console.ReadLine();
            
            Vehicle.SearchCarByCountry(country);
            int ms = 5000;
            Thread.Sleep(ms);
        }

        static void SearchCarByYear(Vehicle vehicle)
        {
            Console.WriteLine("Enter a year of the car: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                Vehicle.SearchCarByYear(year);
                int ms = 5000;
                Thread.Sleep(ms);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid input! Please, enter a number! ");
                Console.ResetColor();
            }
        }
        
        static void ListCars(Vehicle vehicle)
        {
            Vehicle.ListCars();
            int milliseconds = 5000;
            Thread.Sleep(milliseconds);
        }

        static void ChooseCarAction(Vehicle vehicle)
        {
            Console.WriteLine("1. Car turned on");
            Console.WriteLine("2. Car rides");
            Console.WriteLine("3. Car turned off");
            
            if (int.TryParse(Console.ReadLine(), out int action))
            {
                Console.WriteLine("Enter the name of the car:");
                Vehicle.ListCars();
                string name = Console.ReadLine();
                
                switch (action)
                {
                    case 1:
                        Vehicle.CarTurnedOn(name);
                        break;
                    case 2:
                        Vehicle.CarRides(name);
                        break;
                    case 3:
                        Vehicle.CarTurnedOff(name);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid action! Please try again!");
                        Console.ResetColor();
                        break;
                }
                int milliseconds = 5000;
                Thread.Sleep(milliseconds);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid input! Please enter a number.");
                Console.ResetColor();
                
            }
        }
        
        static void CarTurnedOn(Vehicle vehicle)
        {
            Console.WriteLine("Enter a mark of a car for an action: ");
            string name = Console.ReadLine();
            
            Vehicle.CarTurnedOn(name);
            int milliseconds = 5000;
            Thread.Sleep(milliseconds);
        }

        static void CarTurnedOff(Vehicle vehicle)
        {
            Console.WriteLine("Enter a mark of a car for an action: ");
            string name = Console.ReadLine();
            
            Vehicle.CarTurnedOff(name);
            int milliseconds = 5000;
            Thread.Sleep(milliseconds);
        }

        static void CarRides(Vehicle vehicle)
        {
            Console.WriteLine("Enter a mark of a car for an action: ");
            string name = Console.ReadLine();

            Vehicle.CarRides(name);
            int milliseconds = 5000;
            Thread.Sleep(milliseconds);
        }
    }
}