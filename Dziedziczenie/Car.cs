namespace Dziedziczenie
{
    internal class Car : FuelVehicle
    {
        public const int DoorNumber = 4;

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public Car() { }
    }
}