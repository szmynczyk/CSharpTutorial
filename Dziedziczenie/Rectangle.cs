using System;

namespace Dziedziczenie
{
    internal class Rectangle : Polygon
    {
        public override string Name => "Prostokąt";

        public Rectangle(string nazwa, params int[] dlugosciBokow) : base(nazwa, dlugosciBokow)
        {
        }

        public override int CalculateArea()
        {
            //base.CalculateArea();

            int area = SidesLengths[0] * SidesLengths[1];
            Console.WriteLine($"{area}");
            return area;
        }
    }
}
