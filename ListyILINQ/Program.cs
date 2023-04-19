using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyILINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person("Marcin", "Szymczyk", new DateTime(1990, 3, 15), Sex.Male, 726444555),
                new Person("Katarzyna", "Orzoł", new DateTime(1987, 11, 12), Sex.Female, 503123456),
                new Person("Joanna", "Nowak", new DateTime(2015, 7, 20), Sex.Female, 987654321),
                new Person("Tadeusz", "Drozda", new DateTime(1960, 1, 2), Sex.Male, 123456789),
                new Person("Katarzya", "Figura", new DateTime(1962, 3, 22), Sex.Female, 888999888),
                new Person("Kacper", "Saganek", new DateTime(1992, 7, 26), Sex.Male, 666555999),
                new Person("Oliwia", "Szymczyk", new DateTime(2019, 2, 26), Sex.Female, 605654789),
                new Person("Emma", "Watson", new DateTime(2005, 6, 12), Sex.Female, 512654789),
                new Person("Karolina", "Szymczyk", new DateTime(1986, 8, 7), Sex.Female, 887123508),
                new Person("Teresa", "z Kalkuty", new DateTime(1935, 11, 11), Sex.Female, 887123508)
            };

            string[] pets = new string[] { "kot", "pies", "chomik", "papuga", "lama" };
        }
    }
}
