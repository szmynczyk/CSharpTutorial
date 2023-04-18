namespace Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car newCar = new Car
            //{
            //    Model = "Yaris",
            //    Brand = "Toyota",
            //    FuelConsuption = 7.3,
            //    TankCapacity = 40
            //};

            //Motorcycle motorcycle = new Motorcycle
            //{
            //    Brand = "Yamaha",
            //    Model = "Dt 125",
            //    FuelConsuption = 5,
            //    TankCapacity = 10
            //};

            Polygon wielkokąt = new Polygon("trójkąt", 4, 4, 4);
            wielkokąt.CalculateArea();
            //Square kwadrat = new Square("kwadrat", 4, 4, 4, 4);
            //kwadrat.CalculateArea();
            Rectangle prostokąt = new Rectangle("prostokąt", 2, 4, 2, 4);
            prostokąt.CalculateArea();

            Console.WriteLine("Zmiany do pokazania na repo");
        }
    }
}