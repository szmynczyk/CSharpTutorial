using CSharpTutorial.Models;
using SecondProject;
using System;

namespace CSharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Klasy - wstęp
            //zapis klasy
            //modyfikator/atrybut nazwa typu
            //public/internal

            //Car car1 = new Car();
            //car1.Marka = "Toyota";
            //car1.Model = "Corolla";
            //Console.WriteLine("Spalanie car1 to: " + car1.Spalanie);
            //car1.jakasZmienna = 5;


            //car1.Wyposazenie = new string[] { "Poduszki powietrzne", "lewarek", "apteczka" };
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

            //Car renalutClio = new Car(model: "Clio", marka: "Renault");
            //renalutClio.Marka = "Renault";
            //renalutClio.Model = "Clio";
            //Console.WriteLine($"Mój samochód jest marki {renalutClio.Marka} i ma model {renalutClio.Model}");


            //car1.UzyjKlaksonu();
            //renalutClio.UzyjKlaksonu();


            Car someOtherCar = new Car(60);
            //someOtherCar.PojemnoscBaku = 55;
            //Console.WriteLine("Pojemnosc baku to: " + someOtherCar.PojemnoscBaku);

            //Car ciezarowka = new Car();
            //ciezarowka.LiczbaDrzwi = 4;
            //Console.WriteLine($"Liczba drzwi dla naszego auta to: {ciezarowka.LiczbaDrzwi}");

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

            #endregion

            #region Właściwości

            Person ja = new Person();
            ja.Imie = "Marcin";
            ja.Nazwisko = "Szymczyk";
            Console.WriteLine($"Inicjały to: {ja.Inicjały}");
            ja.DataUrodzenia = new DateTime(1990, 03, 15);
            
            Console.WriteLine($"Urodziłem się: {ja.DataUrodzenia.ToShortDateString()}");
            Console.WriteLine($"Mam {ja.Wiek} lat(a)");

            var kacper = new Person();
            kacper.Imie = "Kacper";

            var kamil = new Person
            {
                Imie = "Kamil",
                Nazwisko = "Getler",
                //Obywatelstwo = "Polska"
                //Płeć = 'm'
            };

            //Console.WriteLine($"Płeć Kamila to: {kamil.Płeć}");
            //kamil.PrzeprowadzSieDoInnegoKraju("Palestyna");

            //Console.WriteLine($"Obywatelstwo Kamila to: {kamil.Obywatelstwo}");

            //ja.Nazwisko = "Szymczyk";
            //ja.DataUrodzenia = new DateTime(year: 1990, month: 3, day: 15); //wykomentować - data domyślna

            //Console.WriteLine($"Mój wiek to: {ja.Wiek} lat(a)");
            //Console.WriteLine($"Inicjaly to: {ja.Inicjały}");

            //pola i właściwości statyczne - liczba populacji: Person
            //var someOtherPerson = new Person(); //zwiększy się licznik

            //Zadanie - klasa Samochod
            //Stworz kladę na przechowywanie informacji o samochodzie
            //Niech klasa ma:
            //właściwości publiczne do przechowywania takich informacji jak marka, model, liczba kół, spalanie itp
            //przynajmniej jedno pole statyczne
            //Jedno pole (właściwość publiczną) tylko do odczytu, z wartością obliczaną z innych pól (np maksymalny zasięg na podstawie pojemności baku i średniego spalania)
            //Jedno pole/właściwość, które jest stałą
            //Jedno pole prywatne
            //Jedno pole z wartością domyślną

            //Zadanie - właściwość readonly do zwracania inicjałów
            //W klasie Person stwórz właściwość, która zwróci inicjały osoby
            //Wygenerowane na podstawie imienia i nazwiska
            //Inicjały mają być w formacie X.Y.
            //Jeśli pierwszymi literami imienia lub nazwiska są "cz", "sz", "dz", "rz", "dż", "dź", "ch"
            //To takie inicjały mają być z pierwszych 2 liter
            //np. Kacper Saganek -> K.S.
            //Marcin Szymczyk -> M.Sz.
            //Szczepan Chór -> Sz.Ch.

            #endregion

            #region Metody

            //Person ja = new Person();
            //ja.Imie = "Marcin";
            //ja.Nazwisko = "Szymczyk";
            //ja.DataUrodzenia = new DateTime(year: 1990, month: 3, day: 15);

            //Console.WriteLine($"Nazywam się {ja.Imie} {ja.Nazwisko}, moje inicjały to: {ja.Inicjały}");
            //Console.WriteLine($"Urodziłem się {ja.DataUrodzenia.ToShortDateString()} więc mam {ja.Wiek} lat(a)");
            //string plec = ja.Płeć == 'm' ? "mężczyzna" : "kobieta";
            //Console.WriteLine($"Moja płeć biologiczna to: {plec}");
            
            ////można zastąpić metodą:
            //ja.PrzedstawSie();


            //klasa statyczna - nie można utworzyć instancji, wszystkie składowe statyczne

            //parametry domyślne
            //parametry nazwane

            //metoda z parametrami
            //metoda z param

            //przeciążenie metody
            //nie ma znaczenia typ zwracany, tylko nazwa i parametry
            //metoda statyczna
            //Person.PokazLiczbeLudnosci();

            //pola statyczne

            //konstruktory
            var osoba1 = new Person("Kacper", "Saganek", new DateTime(1992, 10, 26));
            //domyślny konstruktor
            //dodanie konstruktora jakiegokolwiek konstruktora powoduje, że nie mamy już konstruktora domyślnego
            //konstruktor z parametrami
            //wywoływanie jednego konstruktora z drugiego

            //float f1 = 1.0f;
            //float f2 = 3.14f;
            //float f3 = 5.0f;
            //float f4 = 17.123f;

            //Calculator.Dodaj(f1, f2);
            //Calculator.Dodaj(f1, f2, f3);
            //Calculator.Dodaj(f1, f2, f3, f4);

            #endregion
        }
    }
}
