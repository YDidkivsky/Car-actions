namespace program
{

    public class Vehicle
    {
        private static List<Car> cars = new List<Car>();

        public static void AddCar(Car car)
        {
            cars.Add(car);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void EditCar(string name, string newName, string newCountry, int newYear)
        {
            Car car = null;

            foreach (Car c in cars)
            {
                if (c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    car = c;
                    break;
                }
            }

            if (car != null)
            {
                car.Name = newName;
                car.Year = newYear;
                car.Country = newCountry;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congrats! Car is updated!");
            }
        }

        public static void SearchCarByName(string name)
        {
            Car car = null;

            foreach (Car c in cars)
            {
                if (c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    car = c;
                    break;
                }
            }

            if (car != null)
            {
                Console.WriteLine(car);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Car not found!");
                Console.ResetColor();
            }
        }
        
        public static void SearchCarByCountry(string country)
        {
            Car car = null;

            foreach (Car c in cars)
            {
                if (c.Country.Equals(country, StringComparison.OrdinalIgnoreCase))
                {
                    car = c;
                    break;
                }
            }

            if (car != null)
            {
                Console.WriteLine(car);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Car not found!");
                Console.ResetColor();
            }
        }

        public static void SearchCarByYear(int year)
        {
            Car car = null;

            foreach (Car c in cars)
            {
                if (c.Year == year)
                {
                    car = c;
                }
            }

            if (car != null)
            {
                Console.WriteLine(car);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Car not found!");
                Console.ResetColor();
            }
        }

        
        
        public static void ListCars()
        {
            foreach (var car in cars)
            {
              Console.WriteLine(car);  
              
            }
        }
        
        public static void CarRides(string name)
        {
            Car car = null;
            
            foreach (Car c in cars)
            {
                if (c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    car = c;
                    break;
                }
            }

            if (car != null)
            {
                Console.WriteLine(car.Rides());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Car not found!");
                Console.ResetColor();
            }

        }

        public static void CarTurnedOff(string name)
        {
            Car car = null;
            
            foreach (Car c in cars)
            {
                if (c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    car = c;
                    break;
                }
            }

            if (car != null)
            {
                Console.WriteLine(car.TurnedOff());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Car not found!");
                Console.ResetColor();
            }
        }
        public static void CarTurnedOn(string name)
        {
            Car car = null;
            
            foreach (Car c in cars)
            {
                if (c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    car = c;
                    break;
                }
            }

            if (car != null)
            {
                Console.WriteLine(car.TurnedOn());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Car not found!");
                Console.ResetColor();
            }
        }
    }
}