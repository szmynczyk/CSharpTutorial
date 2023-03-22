using System;

namespace SecondProject
{
    internal class Person
    {
        //nowy sposób zapisu
        public string Imie { get; set; }

        //stary sposób zapisu
        private string nazwisko;
        public string Nazwisko 
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        //tylko do odczytu
        public int Wiek => (int)(DateTime.Now - DataUrodzenia).TotalDays/365;

        //tylko do odczytu - stary sposób
        //public string Inicjały 
        //{
        //    get { return string.Concat(Imie[0], ".", Nazwisko[0], "."); }
        //}

        public string Inicjały
        {
            get => string.Concat(Imie[0], ".", Nazwisko[0], ".");
        }

        //public string Inicjały
        //{
        //    get 
        //    {
        //        return Rozwiazania.Inicjaly(Imie, Nazwisko);
        //    }
        //}

        //przypisanie wartości domyślnej
        public DateTime DataUrodzenia { get; set; } = DateTime.Now - TimeSpan.FromDays(365 * 20);
        public char Płeć { get; init; } = 'm'; //tylko przy tworzeniu
        public string Obywatelstwo { get; private set; } //przypisywanie tylko wewnątrz klasu

        public void PrzedstawSie()
        {
            Console.WriteLine($"Nazywam się {Imie} {Nazwisko}, moje inicjały to: {Inicjały}");
            Console.WriteLine($"Urodziłem się {DataUrodzenia.ToShortDateString()} więc mam {Wiek} lat(a)");
            string plec = Płeć == 'm' ? "mężczyzna" : "kobieta";
            Console.WriteLine($"Moja płeć biologiczna to: {plec}");
        }
    }
}
