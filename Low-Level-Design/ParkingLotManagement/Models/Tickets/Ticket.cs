using ParkingLotManagement.Interfaces;

namespace ParkingLotManagement.Models.Tickets
{
    public class Ticket : ITicker
    {
        public int TicketId { get; set; }
        public int VechileId { get; set; }
        public DateTime ReservationStartTime { get; set; }
        public DateTime ReservationEndTime { get; set; }

        public decimal GetTotalFare()
        {
            // get the unit price
            // get duration
            // calculate 

            return 0.0M;
        }
    }
}
