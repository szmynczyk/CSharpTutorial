using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class Zadania
    {

        //Zadanie 1 - czy liczba n jest podzielna przez liczby x i y
        //Użytkownik wprowadza 3 liczby: n, x i y
        //Sprawdź czy liczba n jest podzielna jednocześnie przez liczby x i y
        //np. 24, 3, 4 -> podzielne
        //25, 5, 3 -> niepodzielne (bo podzielne przez 5, ale nie przez 3)

        //Zadanie 2 - liczenie krów
        //jest podana tabela wartości bool, która reprezentuje stanowiska dla krów
        //każda wartość true oznacza, że stoi tam krowa, false - że krowy tam nie ma
        //napisz program, który zlicza wszystkie krowy, które stoją na stanowiskach
        //bool[] obora1 = { true, true, false, true, false, true, false };
        //bool[] obora2 = { false, false, false, false };
        //bool[] obora3 = { false, true, false, false, true, false, true, true, true, true, false, false, false };

        //Zadanie 3 - liczenie krów (medium)
        //jest podana tabela wartości bool, która reprezentuje stanowiska dla krów
        //to samo co wyżej ALE TABLICA REPREZENTUJĄCA KROWY JEST TABLICĄ 2 WYMIAROWĄ POSZARPANĄ
        //bool[][] obora1 = new bool[5][]
        //{
        //    new bool[] { true },
        //    new bool[] { true, true, false, true, false, false},
        //    new bool[] { true, true, true, true },
        //    new bool[] { false, false, false },
        //    new bool[] { false, false, false, true }
        //};

        //Zadanie 4 - największa i najmniejsza wartość w tablicy
        //napisz program, który znajdzie najmniejszą i największą wartość tablicy decimal
        //oraz indexy, na których znajdują się te wartości
        //jeśli max/min występują kilka razy w tabeli zwróć najmniejszy index dla max i min
        //double[] tab1 = { 3.14, 1.0, 2.0, -7.3, 234.5, 234.6, 11.0, -.2 };
        //min = -7.3, minIndex = 3; max = 234.6, maxIndex = 5
        //double[] tab2 = { 3.145, -17.5, 23.46, 1.3, 2.0, -7.3, 512.5, -17.5, 234.6, 13.0, -.2, 512.5 };
        //min = -17.5, minIndex = 1; max = 512.5, maxIndex = 6

        //Zadanie 5 - średnia wartość elementów w tablicy
        //oblicz średnią wartość elementów w tablicy
        //wynik podaj jako double
        //np.
        //int[] tab1 = { 1, 2, 3, 4, 5, 6 };
        //int[] tab2 = { -5, 2, -3, 2889, 10000, 50000, -20, -12345 };
        //int[] tab3 = { 1, 2, 0, 3, 4, 4, 11, -300, 213, -17 };
        //int[] tab4 = { -2, -7, -18, 11, 10000, 12, 123, -9, 0 };

        //Zadanie 6 - mediana
        //oblicz medianę dla tabeli z zadania 5
        //dla zbioru o nieparzystej liczbie elementów mediana to element środkowy (tyle samo jest elementów większych ile mniejszych)
        //Jeżeli mamy parzystą liczbę liczb w zbiorze, to mediana jest równa średniej arytmetycznej dwóch środkowych liczb. 


        //Zadanie - metody
        //Napisz klasę do przechowywania informacji o samochodzie
        //Niech ma pola marka, model, datę produkcji, pojemność baku, średnie spalanie, przebieg (o wartości domyślnej 0, wartość można przypisać tylko wewnątrz klasy)
        //stwórz metodę, która będzie obliczała i zwracała średni zasięg samochodu
        //stwórz metodę, która wypisze dane pojazdu Markę, model, rocznik, pojemność baku, średnie spalanie, niech użytkownik będzie w stanie decydować (przekazując odpowiedni parametr) czy wypisywać pojemność baku i rocznik
        //Napisz metodę, która zwiększa przebieg samochodu, jeśli przebieg się zmniejszy wypisz komunikat z ostrzeżeniem o kręceniu licznika
    }
}
