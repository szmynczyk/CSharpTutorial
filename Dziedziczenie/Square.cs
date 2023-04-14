using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    internal class Square : Polygon
    {
        public Square(string nazwa, params int[] dlugosciBokow) : base(nazwa, dlugosciBokow)
        {
        }

        public int CalculateArea()
        {
            int area = SidesLengths[0] * SidesLengths[0];
            Console.WriteLine($"W naszym kwadracie pole to: {area}");
            return area;
        }
    }
}
