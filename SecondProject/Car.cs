using System;

namespace SecondProject
{
    internal class Car
    {
        public const int LiczbaKol = 4;

        public decimal Spalanie { get; set; }

        public readonly int PojemnoscBaku;

        //public int Zasieg => PojemnoscBaku / (int)Spalanie;

        private decimal _modyfikator = 0.9M;
        
        public int Zasieg
        {
            get
            {
                return (int)(PojemnoscBaku / (int)Spalanie * _modyfikator);
            }
        }

        public string Marka { get; set; }
        //model
        public string Model { get; set; }
        //liczba drzwi
        public int LiczbaDrzwi { get; set; } = 5;
        //prędkość maksymalna
        public int MaksymalnaPredkosc { get; set; }
        //tablica wyposażenie dodatkowe
        public string[] Wyposazenie { get; set; }
        //dźwięk

        public void UzyjKlaksonu()
        {
            Console.WriteLine($"{Marka} {Model} robi Beep beep");
        }

        public Car(int jakasSeLiczba)
        {
            PojemnoscBaku = jakasSeLiczba;
        }

        public Car(decimal spalanie)
        {
            Spalanie = spalanie;
        }

        public Car(string marka, string model)
        {
            Marka = marka;
            Model = model;
        }

        public Car(string marka, string model, decimal spalanie, int liczbaDrzwi)
        {
            Marka = marka;
            Model = model;
        }

        public Car()
        {
        }
    }
}
