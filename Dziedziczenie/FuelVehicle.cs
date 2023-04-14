namespace Dziedziczenie
{
    internal class FuelVehicle : Vehicle
    {
        public int WheelNumber { get; set; }
        public double FuelConsuption { get; set; }
        public int Mileage { get; private set; } = 0;
        public int TankCapacity { get; set; }
        public int Range => Convert.ToInt32(TankCapacity / FuelConsuption * 100);

        public void Drive(int distance)
        {
            Console.WriteLine($"Jedziemy po zioło, dystans do pokonania to {distance} km");
            Mileage += distance;
            Console.WriteLine($"Podczas podróży spaliliśmy {CalculateFuelUsageOnDistance(distance)} litrów paliwa");
        }

        protected double CalculateFuelUsageOnDistance(int distance)
        {
            return distance / 100 * FuelConsuption;
        }
    }
}
