using ParkingLotManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotManagement
{
    public class ParkingFloor
    {
        public IDisplayBoard DisplayBoard { get; set; }
        public IList<IParkingSpot> ParkingSpots { get; set; }
        public ParkingFloor(IDisplayBoard displayBoard, IList<IParkingSpot> parkingSpots) 
        {
            DisplayBoard = displayBoard;
            ParkingSpots = parkingSpots;
        }
    }
}
