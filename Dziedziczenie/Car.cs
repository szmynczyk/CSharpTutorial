using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    internal class Car : Vehicle
    {
        public static int TotalCarNumber;
        //stałe
        public const int LiczbaKol = 4;
        private const double modyfikatorSpalania = 0.9;

        public string Brand { get; set; }
        public string Model { get; set; }
        public double AvgFuelConsumption { get; set; }
        public DateTime ProductionDate { get; set; }
        public Guid SerialNumber { get; init; } = Guid.NewGuid();
        public ushort TankCapacity { get; init; }
        public uint Mileage { get; private set; } = 0;
        public int Range => CalculateRange();
        public int Age => (int)(DateTime.Now - ProductionDate).TotalDays / 365;

        //konstruktory
        public Car()
        {
            TotalCarNumber++;
        } //konstruktor domyślny, który nic nie robi oprócz stworzenia instncji klasy

        public Car(string brand, string model, DateTime productionDate, ushort tankCapacity, double fuelConsumption, Guid vin, uint mileage)
            : this(brand, model, productionDate, tankCapacity)
        {
            SerialNumber = vin;
            Mileage = mileage;
            AvgFuelConsumption = fuelConsumption;
        }

        public Car(string brand, string model, DateTime productionDate, ushort tankCapacity) : this()
        {
            Brand = brand;
            Model = model;
            ProductionDate = productionDate;
            TankCapacity = tankCapacity;
        }

        //metody
        private int CalculateRange()
        {
            return (int)(TankCapacity / AvgFuelConsumption * modyfikatorSpalania);
        }

        public void ShowCarData(bool showFuelConsumption, bool showMileage = false)
        {
            Console.WriteLine($"{Brand} {Model}");
            Console.WriteLine($"Rocznik: {ProductionDate.ToShortDateString()} ({Age} lat)");

            if (showFuelConsumption)
            {
                Console.WriteLine($"Srednie spalanie: {AvgFuelConsumption}");
            }
            if (showMileage)
            {
                Console.WriteLine($"Przebieg: {Mileage}");
            }
        }

        public static void ShowCarDefinition()
        {
            Console.WriteLine("Samochód, automobil – rodzaj pojazdu silnikowego, służący do przewozu osób lub ładunków.");
            Console.WriteLine("Samochody są jednocześnie:");
            Console.WriteLine("* drogowe, co je odróżnia od lokomotyw;");
            Console.WriteLine("dwuśladowe, co je odróżnia od motocykli.");
            Console.WriteLine("Do samochodów nie zalicza się ciągników.");
        }

        public void Scrap(string reason)
        {
            Console.WriteLine("Jedziemyyy, dawaj malinaaaaa! Firmowy samochóóóód!");
            Console.WriteLine($"W dniu {DateTime.Now.ToShortDateString()} miał miejsce wypadek samochodowy");
            Console.WriteLine($"Przyczyną był(a/o) {reason}");
        }

        public void Scrap(string scrappingCompany, DateTime dateOfScrapping)
        {
            int carAgeWhenScrapping = Convert.ToInt16((dateOfScrapping - ProductionDate).TotalDays / 365);
            Console.WriteLine($"Po {carAgeWhenScrapping} odszedł od nas samochodzik.");
            Console.WriteLine($"Uroczystość pogrzebowa zostanie przeprowadzona przez firmę {scrappingCompany}");
        }

        public void TravelTheRoute(uint distance, params string[] stops)
        {
            Console.WriteLine($"Wyruszamy naszym samochodem {Brand} {Model} w podróż.");
            Console.WriteLine($"Startujemy z {stops[0]} i mijamy kolejno:");
            for (int i = 1; i < stops.Length - 1; i++)
            {
                Console.WriteLine(stops[i]);
            }
            Console.WriteLine($"Żeby ostatecznie dotrzeć do {stops[^1]}");

            Mileage += distance;
        }
    }
}
