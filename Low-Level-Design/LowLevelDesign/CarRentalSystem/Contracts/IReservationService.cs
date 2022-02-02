

namespace CarRentalSystem.Contracts
{
    public interface IReservationService
    {
        void CreateReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
        void CancelReservation(Reservation reservation);
    }
}
