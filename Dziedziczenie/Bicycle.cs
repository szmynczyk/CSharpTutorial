namespace Dziedziczenie
{
    internal class Bicycle : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public Guid SerialNumber { get; set; }
    }
}