using HotelManagementSystem.Models.Enums;

namespace HotelManagementSystem.Models;
public class Booking : EntityBase
{
    public int RoomId { get; set; }
    public DateOnly CheckInDate { get; set; }
    public DateOnly CheckOutDate { get; set; }
    public virtual Room? Room { get; set; }
    public BookingStatus BookingStatus { get; set; }
}
