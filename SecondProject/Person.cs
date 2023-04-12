using System;

namespace SecondProject
{
    internal class Person
    {
        private static ulong liczbaLudnosci = 0;
        public const int liczbaRąk = 2;
        //nowy sposób zapisu
        public string Imie { get; set; }

        //stary sposób zapisu
        private string nazwisko;
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        //public string Nazwisko { get; set; }

        //tylko do odczytu
        public int Wiek => (int)(DateTime.Now - DataUrodzenia).TotalDays/365;

        //tylko do odczytu - stary sposób
        public string Inicjały
        {
            get { return string.Concat(Imie[0], ".", Nazwisko[0], "."); }
        }

        //public string Inicjały
        //{
        //    get => string.Concat(Imie[0], ".", Nazwisko[0], ".");
        //}

        //public string Inicjały
        //{
        //    get 
        //    {
        //        return Rozwiazania.Inicjaly(Imie, Nazwisko);
        //    }
        //}

        //przypisanie wartości domyślnej
        public DateTime DataUrodzenia { get; set; }// = new DateTime(month: 3, year: 2003, day: 15);

        public char Płeć { get; init; } = 'm'; //tylko przy tworzeniu

        public string Obywatelstwo { get; private set; } //przypisywanie tylko wewnątrz klasu

        public void PrzeprowadzSieDoInnegoKraju(string nazwaKraju = "Szwajcaria")
        {
            Obywatelstwo = nazwaKraju;
        }

        public void PrzedstawSie(bool wypiszPłeć, bool pokazObywatelstwo = true)
        {
            Console.WriteLine($"Nazywam się {Imie} {Nazwisko}, moje inicjały to: {Inicjały}");
            Console.WriteLine($"Urodziłem się {DataUrodzenia.ToShortDateString()} więc mam {Wiek} lat(a)");
            
            if(wypiszPłeć)
            {
                string plec = Płeć == 'm' ? "mężczyzna" : "kobieta";
                Console.WriteLine($"Moja płeć biologiczna to: {plec}");
            }

            if(pokazObywatelstwo)
            {
                Console.WriteLine($"Moje obywatelstwo to: {Obywatelstwo}");
            }
        }

        public static void PokazLiczbeLudnosci()
        {
            Console.WriteLine($"Liczba ludności to: {liczbaLudnosci}");
        }

        public Person()
        {
            //++liczbaLudnosci;
            Console.WriteLine("Konstruktor bezparametrowy");
        }

        public Person(string imie, string nazwisko, DateTime dataUrodzenia) : this()
        {
            //this odnosi się konkretnie do składowych tego obiektu
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
            Console.WriteLine("Konstruktor z parametrami: imie, nazwisko, data urodzenia");
        }

        //wywołanie jednego konstruktora przez drugi
        public Person(string imie, string nazwisko, DateTime dataUrodzenia, char plec) : this(imie, nazwisko, dataUrodzenia)
        {
            Płeć = plec;
            Console.WriteLine("Konstruktor z parametrami: imie, nazwisko, data urodzenia, plec");
        }

        static Person()
        {
            Console.WriteLine("Wywołanie konstruktora statycznego");
        }
    }
}
