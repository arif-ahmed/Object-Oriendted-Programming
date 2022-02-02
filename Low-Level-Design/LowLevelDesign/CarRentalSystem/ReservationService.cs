using CarRentalSystem.Contracts;

namespace CarRentalSystem
{
    public class ReservationService : IReservationService
    {
        private readonly PaymentProcessor _paymentProcessor;
        public ReservationService(PaymentProcessor paymentProcessor) => _paymentProcessor = paymentProcessor;
        public void CancelReservation(Reservation reservation) 
        {

        }

        public void CreateReservation(Reservation reservation)
        {

        }

        public void UpdateReservation(Reservation reservation)
        {

        }
    }
}
