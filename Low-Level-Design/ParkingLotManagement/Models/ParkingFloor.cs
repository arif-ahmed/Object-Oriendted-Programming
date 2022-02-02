using ParkingLotManagement.Interfaces;
using ParkingLotManagement.Models.ControlPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotManagement.Models
{
    public class ParkingFloor
    {
        public IList<EntryPoint> EntryPoints { get; set; }
        public IList<ExitPoint> ExitPoints { get; set; }
        public IDisplayBoard DisplayBoard { get; set; }
        public IList<IParkingSpot> ParkingSpots { get; set; }
        public ParkingFloor(IList<EntryPoint> entryPoints, IList<ExitPoint> exitPoints, IDisplayBoard displayBoard, IList<IParkingSpot> parkingSpots)
        {
            EntryPoints = entryPoints;
            ExitPoints = exitPoints;
            DisplayBoard = displayBoard;
            ParkingSpots = parkingSpots;
        }
    }
}
