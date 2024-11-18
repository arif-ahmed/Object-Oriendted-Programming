

namespace CarRentalSystem.Contracts
{
    public interface IReservationService
    {
        void CreateReservation();
        void UpdateReservation();
        void CancelReservation();
    }
}
