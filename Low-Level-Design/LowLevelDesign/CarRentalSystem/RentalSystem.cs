
using CarRentalSystem.Contracts;

namespace CarRentalSystem
{
    public class RentalSystem
    {
        private IList<Car> cars = new List<Car>();
        private IList<Customer> customers = new List<Customer>();
        private IList<Reservation> reservations = new List<Reservation>();

        public IReservationService ReservationService { get; set; }

        public RentalSystem(IReservationService ReservationService)
        {
            this.ReservationService = ReservationService;
        }
    }
}
