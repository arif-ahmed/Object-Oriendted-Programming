using ParkingLotManagement.Infrastructure;

namespace ParkingLotManagement
{
    public class ParkingLot
    {
        private IList<ParkingFloor> _parkingFloors = new List<ParkingFloor>();

        [AdminOnly]
        public void AddParkingFloor()
        {
            
        }
    }
}
