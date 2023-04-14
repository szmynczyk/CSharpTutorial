using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    internal class Polygon
    {
        public virtual string Name { get; set; }

        public int LiczbaBoków => SidesLengths.Length;

        public int[] SidesLengths { get; set; }

        public int ObliczObwód()
        {
            int obwód = 0;

            foreach(var bok in SidesLengths)
            {
                obwód += bok;
            }

            return obwód;
        }

        public Polygon(string nazwa, params int[] dlugosciBokow)
        {
            Name = nazwa;
            SidesLengths = dlugosciBokow;
        }

        public virtual int CalculateArea()
        {
            Console.WriteLine($"Pole figury {Name} to:");
            return 0;
        }
    }
}
