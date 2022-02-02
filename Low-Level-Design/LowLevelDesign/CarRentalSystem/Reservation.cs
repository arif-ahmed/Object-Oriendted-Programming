namespace CarRentalSystem
{
    public class Reservation
    {
        public string ReservationId { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalPrice { get; private set; }

    }
}
