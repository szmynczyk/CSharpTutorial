﻿using System;

namespace SecondProject
{
    public static class Calculator
    {
        public static int Dodaj(int liczba1, int liczba2 = 5)
        {
            int wynik = liczba1 + liczba2;
            Console.WriteLine($"Wynik dodawania liczb {liczba1} i {liczba2} to: {wynik}");
            return wynik;
        }

        //public static int Dodaj(int[] liczby)
        //{
        //    int result = 0;

        //    foreach (int liczba in liczby)
        //    {
        //        result += liczba;
        //    }

        //    return result;
        //}

        //metoda skrócona do wyrażenia
        public static double Dodaj(double liczba1, double liczba2) => liczba1 + liczba2;


        public static decimal Dodaj(decimal liczba1, decimal liczba2)
        {
            decimal wynik = liczba1 + liczba2;
            Console.WriteLine($"Wynik dodawania liczb {liczba1} i {liczba2} to: {wynik}");
            return wynik;
        }

        //public static float Dodaj(params float[] liczby)
        //{
        //    float result = 0f;
        //    foreach(float liczba in liczby)
        //    {
        //        result += liczba;
        //    }

        //    Console.WriteLine($"Wynik dodawania {liczby.Length} liczb typu float to: {result}");

        //    return result;
        //}
    }
}
