using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class Rozwiazania
    {
        public void KonwersjaDaty()
        {
            string todaysDate = "13.03.2023";
            Console.WriteLine("Podaj datę urodzenia w formacie YYYY-MM-DD:");
            string birthDate = Console.ReadLine(); //1990-03-15
            string yearOfBirth = birthDate.Substring(0, 4);
            string monthOfBirth = birthDate.Substring(5, 2);
            string dayOfBirth = birthDate.Substring(8, 2);

            if (int.Parse(yearOfBirth) < 1900 || int.Parse(yearOfBirth) > 2022)
            {
                Console.WriteLine("Niepoprawny rok urodzenia. Rok urodzenia musi być w zakresie 1900-2022!");
            }
            else if (int.Parse(monthOfBirth) < 1 || int.Parse(monthOfBirth) > 12)
            {
                Console.WriteLine("Niepoprawny miesiąc urodzenia. Miesiąc urodzenia musi być w zakresie 1-12!");
            }
            else if (int.Parse(dayOfBirth) < 1 || int.Parse(dayOfBirth) > 30)
            {
                Console.WriteLine("Niepoprawny dzień urodzenia. Dzień urodzenia powinien być w zakresie 1-30");
            }
            else
            {
                string formattedDate = string.Join(".", dayOfBirth, monthOfBirth);
                if (todaysDate.Substring(0, 5) == formattedDate)
                {
                    Console.WriteLine("Masz dzisiaj urodziny, wszystkiego najlepszego!");
                }
                else
                {
                    Console.WriteLine("Nie masz dzisiaj urodzin");
                }
            }
        }

        public void SortowanieTablicy()
        {
            int[] arrayToSort = { 73, 57, 49, 99, 133, 20, 1 };
            Console.WriteLine("Tabela oryginalna:");
            Console.Write("[");
            int counter = 0;
            int changeCounter = 0;
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i]);
                if (i < arrayToSort.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = i + 1; j < arrayToSort.Length; j++)
                {
                    if (arrayToSort[i] > arrayToSort[j])
                    {
                        int tmp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[j];
                        arrayToSort[j] = tmp;
                        changeCounter++;
                    }

                    counter++;
                }
            }

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = 0; j < arrayToSort.Length - 1; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        int tmp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = tmp;
                        changeCounter++;
                    }

                    counter++;
                }
            }

            Console.WriteLine("\nTabela posortowana:");
            Console.Write("[");

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i]);
                if (i < arrayToSort.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");

            Console.WriteLine($"\nLicznik = {counter}");
            Console.WriteLine($"Liczba zmian = {changeCounter}");
        }

        public void Statki()
        {
            int[,] plansza = new int[10, 10]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 0, 1, 1, 1, 1, 0, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 1, 0, 0, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 1, 1, 0 },
                { 0, 1, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };             
            
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write($" {plansza[i, j]}");
                }
                Console.WriteLine();
            }             
            //4x1
            //3x2
            //2x3
            //1x4
            //lacznie 20 pól ze statkami            
            int licznikTrafien = 0;
            bool trafiony;
            do
            {
                Console.WriteLine("Podaj współrzędne pola ([A-J][1-10], np A10):");
                string result = Console.ReadLine();
                int row = result.ToUpper()[0] - 65;
                int column = int.Parse(result.Substring(1)) - 1;
                //A=65
                if (row < 0 || row > 9 || column < 0 || column > 9)
                {
                    Console.WriteLine("Niepoprawne współrzędne, spróbuj jeszcze raz");
                    trafiony = true;
                }
                else if (plansza[row, column] == 1)
                {
                    Console.WriteLine("Trafiony!");
                    plansza[row, column] = 2;
                    trafiony = true;
                    Console.WriteLine($"Trafiłeś już {++licznikTrafien}/20 pól zajętych przez statki");
                    if(licznikTrafien == 20)
                    {
                        Console.WriteLine("Wygrałeś grę!");
                    }                     Console.WriteLine("Aktualna plansza: ");
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write($" {plansza[i, j]}");
                        }
                        Console.WriteLine();
                    }
                }
                else if (plansza[row, column] == 2)
                {
                    Console.WriteLine("Szczelałeś już tutaj!");
                    trafiony = true;
                }
                else
                {
                    Console.WriteLine("Pudło!");
                    trafiony = false;
                }
            } while (trafiony && licznikTrafien < 20);
        }

        public void Silnia()
        {
            Console.WriteLine("Podaj liczbę całkowitą do obliczenia silni");
            int liczba = int.Parse(Console.ReadLine());
            int silnia = 1;
            for (int i = 2; i <= liczba; i++)
            {
                silnia *= i;
            }

            Console.WriteLine($"Silnia z {liczba} to {silnia}");
        }

        public void OdwrocTekst()
        {
            Console.WriteLine("Podaj tekst do odwrócenia: ");
            string textToRevert = Console.ReadLine();
            Console.WriteLine("Odwrócony tekst: ");
            for (int i = textToRevert.Length - 1; i >= 0; i--)
            {
                Console.Write(textToRevert[i]);
            }
        }
    }
}
