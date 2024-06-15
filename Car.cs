namespace program
{

    public class Car
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }

        public Car(string name, string country, int year)
        {
            Name = name;
            Country = country;
            Year = year;
        }
        
        public string TurnedOn()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan; 
            return $"Car brand {Name}\nManufacturer country {Country}\nYear of the vehicle {Year} is turned on!";
            Console.ResetColor();
        }

        public string TurnedOff()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan; 
            return $"Car brand {Name}\nManufacturer country {Country}\nYear of the vehicle {Year} is turned off!";
            Console.ResetColor();
        }

        public string Rides()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan; 
            return $"Car brand {Name}\nManufacturer country {Country}\nYear of the vehicle {Year} rides!";
            Console.ResetColor();
            ;
        }
        
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan; 
            return $"Car brand {Name}\nManufacturer country {Country}\nYear of the vehicle {Year}\n";
            Console.ResetColor();
        }
    }
}