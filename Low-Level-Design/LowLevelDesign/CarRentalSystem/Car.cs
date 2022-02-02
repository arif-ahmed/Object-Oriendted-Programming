namespace CarRentalSystem
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public double RentalPricePerDay { get; set; }
        public bool Available { get; set; }
    }
}
