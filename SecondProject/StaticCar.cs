using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal static class StaticCar
    {
        private static int WheelNumber = 4;

        public static void ShowCarDefinition()
        {
            Console.WriteLine("Samochód, automobil – rodzaj pojazdu silnikowego, służący do przewozu osób lub ładunków.");
            Console.WriteLine("Samochody są jednocześnie:");
            Console.WriteLine("* drogowe, co je odróżnia od lokomotyw;");
            Console.WriteLine("dwuśladowe, co je odróżnia od motocykli.");
            Console.WriteLine("Do samochodów nie zalicza się ciągników.");
        }

        public static int DoorNumber { get; set; } = 5;
    }
}
