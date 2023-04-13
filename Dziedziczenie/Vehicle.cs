namespace Dziedziczenie
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public Guid SerialNumber { get; set; }
        protected static string DriveSource;
        public int Age => (int)(DateTime.Now - ProductionDate).TotalDays / 365;
    }
}
