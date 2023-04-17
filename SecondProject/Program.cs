using CSharpTutorial.Models;
using SecondProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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


            //Car someOtherCar = new Car(60);
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

            //Person ja = new Person();
            //ja.Imie = "Marcin";
            //ja.Nazwisko = "Szymczyk";
            //Console.WriteLine($"Inicjały to: {ja.Inicjały}");
            //ja.DataUrodzenia = new DateTime(1990, 03, 15);

            //Console.WriteLine($"Urodziłem się: {ja.DataUrodzenia.ToShortDateString()}");
            //Console.WriteLine($"Mam {ja.Wiek} lat(a)");

            //var kacper = new Person();
            //kacper.Imie = "Kacper";

            //var kamil = new Person
            //{
            //    Imie = "Kamil",
            //    Nazwisko = "Getler",
            //    //Obywatelstwo = "Polska"
            //    //Płeć = 'm'
            //};

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
            //ja.PrzeprowadzSieDoInnegoKraju();
            //ja.PrzedstawSie(false, false);

            //Console.WriteLine($"Nowe obywatelstwo to: {ja.Obywatelstwo}");
            //Console.WriteLine($"Nazywam się {ja.Imie} {ja.Nazwisko}, moje inicjały to: {ja.Inicjały}");
            //Console.WriteLine($"Urodziłem się {ja.DataUrodzenia.ToShortDateString()} więc mam {ja.Wiek} lat(a)");
            //string plec = ja.Płeć == 'm' ? "mężczyzna" : "kobieta";
            //Console.WriteLine($"Moja płeć biologiczna to: {plec}");

            //można zastąpić metodą:
            //ja.PrzedstawSie();

            //Console.WriteLine("----------------------");

            //Person kacper = new Person();
            //kacper.Imie = "Kacper";
            //kacper.Nazwisko = "Saganek";
            //kacper.DataUrodzenia = new DateTime(year: 1992, month: 7, day: 26);
            //kacper.PrzeprowadzSieDoInnegoKraju("Polska");

            //kacper.PrzedstawSie();

            //Person kacper = new Person("Kacper", "Saganek", new DateTime(year: 1992, month: 7, day: 26));
            //Person kacper = new Person("Kacper", "Saganek", new DateTime(1992, 26, 7));
            //kacper.PrzedstawSie();

            //Calculator.Dodaj(5);

            //decimal decimal1 = 4.6M;
            //decimal decimal2 = 5.1M;

            //Console.WriteLine($"Wynik dodawania 5 i 8 to: {wynikDodawania}");
            //Console.WriteLine($"Wynik dodawania 5 i 8 to: {Calculator.Dodaj(5, 8)}");

            //klasa statyczna - nie można utworzyć instancji, wszystkie składowe statyczne

            //parametry domyślne
            //parametry nazwane

            //metoda z parametrami
            //metoda z param

            //przeciążenie metody
            //nie ma znaczenia typ zwracany, tylko nazwa i parametry
            //metoda statyczna
            //Person.PokazLiczbeLudnosci();

            //Car samochod = new Car();
            //samochod.ObliczSredniZasieg();

            //float f1 = 1.0f;
            //float f2 = 3.14f;
            //float f3 = 5.0f;
            //float f4 = 17.123f;

            //Calculator.Dodaj(f1, f2);
            //Calculator.Dodaj(f1, f2, f3);
            //Calculator.Dodaj(f1, f2, f3, f4);

            #endregion

            #region Typy referencyjne i wartościowe
            //Console.WriteLine("-----Typy referencyjne-----");

            //Person os1 = new Person();
            //os1.Imie = "Marcin";

            //Console.WriteLine("Os1 na początku: " + os1.Imie);

            //Person os2 = os1;
            //os2.Imie = "Kamil";

            //Console.WriteLine($"Os1 zmiana os2: {os1.Imie}");
            //Console.WriteLine("Os2 zmiana os2: " + os2.Imie);

            //os1.Imie = "Kacper";
            //Console.WriteLine("Os1 po zmianie os1: " + os1.Imie);
            //Console.WriteLine("Os2 poz zmianie os1: " + os2.Imie);

            //Console.WriteLine("-----Typy wartościowe-----");

            //int int1 = 3;

            //Console.WriteLine($"Int1 przed zmianą: {int1}");

            //int int2 = int1;
            //Console.WriteLine($"Int1 po przypisaniu do Int2: {int1}");
            //Console.WriteLine($"Int2 po przypisaniu do Int2: {int2}");

            //int2 = 700;

            //Console.WriteLine($"Int1 po zmianie Int2: {int1}");
            //Console.WriteLine($"Int2 po zmianie Int2: {int2}");

            //int1 = 3456;
            //Console.WriteLine($"Int1 po zmianie Int1: {int1}");
            //Console.WriteLine($"Int2 po zmianie Int1: {int2}");

            //Console.WriteLine("-------------------------");

            //string string1 = "String 1";

            //Console.WriteLine($"String1 przed zmianą: {string1}");

            //string string2 = string1;
            //string2 = "Another string";

            //Console.WriteLine($"string1 po zmianie: {string1}");
            //Console.WriteLine($"string2 po zmianie: {string2}");
            #endregion

            #region Konstruktory

            //var osoba1 = new Person("Kacper", "Saganek", new DateTime(1992, 10, 26));
            //domyślny konstruktor
            //Person domyślnyPerson = new Person();
            //dodanie konstruktora jakiegokolwiek konstruktora powoduje, że nie mamy już konstruktora domyślnego
            //konstruktor z parametrami
            //wywoływanie jednego konstruktora z drugiego
            //Person osobaZWielomaDanymi = new Person("Lord", "Voldermort", new DateTime(1975, 11, 3));
            //osobaZWielomaDanymi.PrzedstawSie(false);

            //var dataUrodzeniaGandalfa = DateTime.MinValue + TimeSpan.FromDays(1);

            //var osobaZPelnymKonstruktorem = new Person(imie: "Gandalf", nazwisko: "Szary", dataUrodzeniaGandalfa, 'm');
            //osobaZPelnymKonstruktorem.PrzedstawSie(wypiszPłeć: true, pokazObywatelstwo: false);
            //Console.WriteLine($"Inicjały to: {osobaZPelnymKonstruktorem.Inicjały}");


            //inicjalizacja obiektu w prosty sposób:
            //Person anotherPerson = new Person
            //{
            //    Imie = "Gracjan",
            //    Nazwisko = "Roztocki",
            //    Płeć = 'm'
            //};

            //Console.WriteLine($"Data urodzenia {anotherPerson.Nazwisko}");
            //konstruktor statyczny


            //Console.WriteLine("Samochód: ");
            //Samochod samochod = new Samochod("Volkswagen", "Polo", new DateTime(2004, 10, 01), pojemnoscBaku: 50, vin: Guid.NewGuid(), przebieg: 25459, srednieSpalanie: 7.5);
            //Console.WriteLine("Samochód bez parametrów: ");
            //Samochod drugiSamochod = new Samochod();
            //Console.WriteLine("Samochód z 4 parametrami");
            //Samochod samochodZ4Parametrami = new Samochod("Renault", "Clio", DateTime.Now, 45);
            //Samochod innySamochod = new Samochod();

            //Samochod.PokazDefinicjeSamochodu();

            //Console.WriteLine("Liczba wyprodukowanych samochodow: " + Samochod.LiczbaWyprodukowanychSamochodow);

            //samochod.PrzejedzTrase(10, "Centrum handlowe", "Stacja paliw", "Aquaparku");
            //samochod.PrzejedzTrase(20, "ul. Postępowa", "ul. Grabiszyńską");

            //samochod.PokazDanePojazdu(true);
            //Console.WriteLine("----------------------");
            //samochod.PokazDanePojazdu(true, true);

            //samochod.Skasuj("jakaś przyczyna");
            #endregion

            #region Obsługa wyjątków

            int a = 5;
            int b = 0;

            //Console.WriteLine(a/b);

            //try
            //{
            //    Console.WriteLine("Wynik dzielenia to: " + a / b);
            //    //throw new IndexOutOfRangeException("Straszliwy wyjątek do rzucenia");
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("Nie wolno dzielić przez zero");
            //    throw new DivideByZeroException();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Treść błędu: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Ten kod wykona się niezależnie czy wyjątek wystąpi czy nie");
            //}

            //Console.WriteLine("Kod do wykonania dalej");

            //Zadanie - napisz program który przyjmuje od użytkownika numer opcji z menu:,
            //1. Dodawanie
            //2. Odejmowanie
            //3. Mnożenie
            //4. Dzielenie
            //5. Reszta z dzielenia
            //6. Koniec programu
            //Po czym program przyjmuje od użytkownika i wykonuje (jeśli można) na nich żądaną operację i wypisuje wynik
            //Przy wybraniu opcji 6. Program się wyłącza
            //Zabezpiecz program przed sytuacjami:
            //- kiedy użytkownik wpisze opcję menu, która nie jest liczbą
            //- kiedy podane liczby do działania nie są liczbą całkowitą
            //- kiedy wynik działania może być nieprawidłowy (dzielenie przez 0)
            //Stwórz klasę statyczną do wyświetlania i wybierania opcji z menu
            //Do obliczeń matematycznych stwórz klasę kalkulator, w której będą metody to wykonywania obliczeń
            //Dla wszystkich poprawnych opcji oprócz opcji 6 niech program będzie zapętlony - przyjmuje opcję z menu i liczby od nowa

            #endregion

            #region Listy

            string[] petArray = new string[] { "rybka", "żółw", "chomik"};

            var zwierzaczki = new List<string>
            {
                "kura",
                "kaczka",
                "słoń w karafce",
                "kot"
            };

            //Console.WriteLine(zwierzaczki.Count);

            //Console.WriteLine(zwierzaczki[0]);

            //foreach (string zwierzak in zwierzaczki)
            //{
            //    Console.WriteLine(zwierzak);
            //}

            zwierzaczki.AddRange(petArray);

            //Console.WriteLine("Po dodaniu zestawu danych:");
            //foreach (string zwierzak in zwierzaczki)
            //{
            //    Console.WriteLine(zwierzak);
            //}

            zwierzaczki.Remove("kot");
            //Console.WriteLine("Po usuwaniu kota lista wygląda tak: ");
            //foreach (string zwierzak in zwierzaczki)
            //{
            //    Console.WriteLine(zwierzak);
            //}

            //zwierzaczki.RemoveRange(2, 1);

            //Console.WriteLine("Po usuwaniu zakresu lista to:");
            //foreach (string zwierzak in zwierzaczki)
            //{
            //    Console.WriteLine(zwierzak);
            //}

            //Console.WriteLine("Wrzucanie insertem do środka");
            //zwierzaczki.Insert(2, "skolopendromorf");
            //foreach (string zwierzak in zwierzaczki)
            //{
            //    Console.WriteLine(zwierzak);
            //}

            //zwierzaczki.Sort();
            //Console.WriteLine("Posortowane zwierzaczki");
            //foreach (string zwierzak in zwierzaczki)
            //{
            //    Console.WriteLine(zwierzak);
            //}

            //zwierzaczki.Reverse();
            //Console.WriteLine("Odwrócone zwierzaczki");
            //foreach (string zwierzak in zwierzaczki)
            //{
            //    Console.WriteLine(zwierzak);
            //}

            //zwierzaczki.Clear();
            //Console.WriteLine("Pusta lista");
            //foreach (string zwierzak in zwierzaczki)
            //{
            //    Console.WriteLine(zwierzak);
            //}

            #endregion

            #region Dictionary

            Dictionary<string, Samochod> carsDictionary = new Dictionary<string, Samochod>();
            carsDictionary.Add("Toyota", new Samochod("Toyota", "Yaris", new DateTime(1999, 10, 15), 40));

            Console.WriteLine("Wartość dla klucza Toyota:" + carsDictionary["Toyota"].Marka);

            var ifToyotaExists = carsDictionary.ContainsKey("Toyota");
            Console.WriteLine("Czy TOYOTA istnieje w słowniku: " + ifToyotaExists);

            var currencies = new Dictionary<string, string>
            {
                { "PL", "Złotówka" },
                { "", "" },
                { "DE", "Euro" },
                { "IT", "Euro" }
            };

            foreach ( var c in currencies )
            {
                Console.WriteLine($"Klucz: {c.Key}, wartość: {c.Value}");
            }

            Console.WriteLine("Czy słownik posiada wartość 'Euro'?");
            Console.WriteLine(currencies.ContainsValue("Euro"));

            currencies.Remove("");
            Console.WriteLine("Wartości słownika po usunięciu pustego klucza");
            foreach (var c in currencies)
            {
                Console.WriteLine($"Klucz: {c.Key}, wartość: {c.Value}");
            }

            currencies.Add("DE", "Marki niemieckie");

            #endregion
        }

        enum Przegladarka
        {
            Firefox,
            Chrome,
            Safari,
            Edge
        }

        enum Operacja
        {
            Dodawanie = 1,
            Odejmowanie = 2,
            Mnożenie = 4,
            Dzielenie = 8
        }
    }
}
