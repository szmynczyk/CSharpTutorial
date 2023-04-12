using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    public class Samochod
    {
        //pola (prywatne)
        private double stopienZuzyciaBieznika;
        //pola statyczne
        public static int LiczbaWyprodukowanychSamochodow;
        //stałe
        public const int LiczbaKol = 4;
        private const double modyfikatorSpalania = 0.9;

        //właściwości/property
        public string Marka { get; set; }
        public string Model { get; set; }
        public double SrednieSpalanie { get; set; }
        public DateTime Rocznik { get; set; }
        //właściwość z możliwością ustawiania tylko podczas tworzenia obiektu
        public Guid Vin { get; init; } = Guid.NewGuid();
        public ushort PojemnoscBaku { get; init; }
        //właściwość możliwa do zmiany tylko wewnątrz klasy (np jakąś metodą)
        public uint Przebieg { get; private set; } = 0;
        //właściwość tylko do odczytu
        //public int Zasieg => ObliczZasieg();
        public int Zasieg
        {
            get
            {
                return ObliczZasieg();
            }
        }

        public int Wiek => (int)(DateTime.Now - Rocznik).TotalDays / 365;
        //konstruktory
        public Samochod() 
        {
            LiczbaWyprodukowanychSamochodow++;
        } //konstruktor domyślny, który nic nie robi oprócz stworzenia instncji klasy

        public Samochod(string marka, string model, DateTime rocznik, ushort pojemnoscBaku, double srednieSpalanie, Guid vin, uint przebieg) 
            : this(marka, model, rocznik, pojemnoscBaku)
        {
            Vin = vin;
            Przebieg = przebieg;
            SrednieSpalanie = srednieSpalanie;
        }

        public Samochod(string marka, string model, DateTime rocznik, ushort pojemnoscBaku) : this()
        {
            Marka = marka;
            Model = model;
            Rocznik = rocznik;
            PojemnoscBaku = pojemnoscBaku;
        }

        //metody
        private int ObliczZasieg()
        {
            return (int)(PojemnoscBaku / SrednieSpalanie * modyfikatorSpalania);
        }

        public void PokazDanePojazdu(bool pokazSpalanie, bool pokazPrzebieg = false)
        {
            Console.WriteLine($"{Marka} {Model}");
            Console.WriteLine($"Rocznik: {Rocznik.ToShortDateString()} ({Wiek} lat)");
            
            if(pokazSpalanie)
            {
                Console.WriteLine($"Srednie spalanie: {SrednieSpalanie}");
            }
            if(pokazPrzebieg)
            {
                Console.WriteLine($"Przebieg: {Przebieg}");
            }
        }

        public static void PokazDefinicjeSamochodu()
        {
            Console.WriteLine("Samochód, automobil – rodzaj pojazdu silnikowego, służący do przewozu osób lub ładunków.");
            Console.WriteLine("Samochody są jednocześnie:");
            Console.WriteLine("* drogowe, co je odróżnia od lokomotyw;");
            Console.WriteLine("dwuśladowe, co je odróżnia od motocykli.");
            Console.WriteLine("Do samochodów nie zalicza się ciągników.");
        }

        public void Skasuj(string przyczyna)
        {
            Console.WriteLine("Jedziemyyy, dawaj malinaaaaa! Firmowy samochóóóód!");
            Console.WriteLine($"W dniu {DateTime.Now.ToShortDateString()} miał miejsce wypadek samochodowy");
            Console.WriteLine($"Przyczyną był(a/o) {przyczyna}");
        }

        public void Skasuj(string firmaKasacyjna, DateTime dataKasacji)
        {
            int wiekSamochoduWMomencieKasacji = Convert.ToInt16((dataKasacji - Rocznik).TotalDays / 365);
            Console.WriteLine($"Po {wiekSamochoduWMomencieKasacji} odszedł od nas samochodzik.");
            Console.WriteLine($"Uroczystość pogrzebowa zostanie przeprowadzona przez firmę {firmaKasacyjna}");
        }

        public void PrzejedzTrase(uint dystans, params string[] przystanki)
        {
            Console.WriteLine($"Wyruszamy naszym samochodem {Marka} {Model} w podróż.");
            Console.WriteLine($"Startujemy z {przystanki[0]} i mijamy kolejno:");
            for (int i = 1; i < przystanki.Length; i++)
            {
                Console.WriteLine(przystanki[i]);
            }
            Console.WriteLine($"Żeby ostatecznie dotrzeć do {przystanki[^1]}");

            Przebieg += dystans;
        }
    }
}
