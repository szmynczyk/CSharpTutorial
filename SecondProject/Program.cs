using CSharpTutorial.Models;
using SecondProject;
using System;

namespace CSharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Klasy
            //zapis klasy
            //modyfikator/atrybut nazwa typu
            //public/internal
            #endregion

            Car car1 = new Car();
            car1.Marka = "Toyota";
            car1.Model = "Corolla";
            //Console.WriteLine("Spalanie car1 to: " + car1.Spalanie);
            //car1.jakasZmienna = 5;


            car1.Wyposazenie = new string[] { "Poduszki powietrzne", "lewarek", "apteczka" };
            //Console.WriteLine("Wyposażenie przed zmianą:");

            //foreach (string s in car1.Wyposazenie)
            //{
            //    Console.WriteLine(s);
            //}

            //car1.Wyposazenie[2] = "trójkąt";

            //Console.WriteLine("Wyposażenie po zmianie:");

            //foreach (string s in car1.Wyposazenie)
            //{ 
            //    Console.WriteLine(s); 
            //}


            //Console.WriteLine($"Marka samochodu to { car1.Marka} { car1.Model }");

            Car renalutClio = new Car(model: "Clio", marka: "Renault");
            //renalutClio.Marka = "Renault";
            //renalutClio.Model = "Clio";
            Console.WriteLine($"Mój samochód jest marki {renalutClio.Marka} i ma model {renalutClio.Model}");


            //car1.UzyjKlaksonu();
            //renalutClio.UzyjKlaksonu();


            Car someOtherCar = new Car(60);
            //someOtherCar.PojemnoscBaku = 55;
            Console.WriteLine("Pojemnosc baku to: " + someOtherCar.PojemnoscBaku);

            Car ciezarowka = new Car();
            ciezarowka.LiczbaDrzwi = 4;
            Console.WriteLine($"Liczba drzwi dla naszego auta to: {ciezarowka.LiczbaDrzwi}");
            
            //string marka1 = "Toyota";
            //string model1 = "Corolla";
            //int liczbaDrzwi1 = 3;

            //string marka2 = "Renault";
            //string model2 = "Clio";
            //int liczbaDrzwi2 = 5;

            //Zadanie - nowa klasa
            //Stwórz klasę person, która będzie przechowywać informacje o osobie
            //Imię
            //Nazwisko
            //Wiek
            //Tablica z listą zainteresowań
            //stałą publiczną z wartością podatku (np 32)
            //zmienną prywatną
            //w klasie Program stwórz nowy obiekt stworzonej klasy
            //i przypisz konkretne wartości do pól (do tych, do których się da)


        }
    }
}
