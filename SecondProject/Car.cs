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
                return (int)(PojemnoscBaku / Spalanie * _modyfikator);
            }
        }

        public double ObliczSredniZasieg()
        {
            return Zasieg;
        }

        public string Marka { get; set; }

        public string Model { get; set; }

        public int LiczbaDrzwi { get; set; } = 5;

        public int MaksymalnaPredkosc { get; set; }

        public string[] Wyposazenie { get; set; }


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
