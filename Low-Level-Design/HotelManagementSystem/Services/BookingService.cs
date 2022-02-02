using HotelManagementSystem.Contracts;
using HotelManagementSystem.Models;
using HotelManagementSystem.Models.Enums;
using HotelManagementSystem.Repositories;

namespace HotelManagementSystem.Services;
public class BookingService
{
    private readonly IRepository<Booking> _bookingRepository = new BookingRepository();
    private readonly IPaymentService _paymentService;

    public BookingService(IPaymentService paymentService)
    {
        _paymentService = paymentService ?? throw new ArgumentNullException(nameof(paymentService));
    }

    public async Task<Booking> GetBookingById(int id)
    {
        var booking = await _bookingRepository.GetByIdAsync(id);
        return booking;
    }

    public async Task<IEnumerable<Booking>> Search(DateOnly checkInDate, DateOnly checkOutDate, RoomStyle? roomStyle)
    {
       
        var bookings = await _bookingRepository.Filter(
            b => b.CheckInDate >= checkInDate && b.CheckOutDate <= checkOutDate,
            "CheckInDate",
            "asc"
        );

        return bookings.AsEnumerable();
    }

    public async Task BookRoom(int roomId, DateOnly checkInDate, DateOnly checkOutDate)
    {
        var booking = await _bookingRepository.GetByIdAsync(roomId);

        if (booking == null)
        {
            throw new ArgumentException($"No room found with ID {roomId}.");
        }

        await _bookingRepository.AddAsync(new Booking
        {
            RoomId = roomId,
            CheckInDate = checkInDate,
            CheckOutDate = checkOutDate
        });

        await _bookingRepository.SaveChangesAsync();

        await Task.CompletedTask;
    }

    public async Task UpdateBookingAsync(Booking booking)
    {
        if (booking == null)
        {
            throw new ArgumentNullException(nameof(booking));
        }
        await _bookingRepository.UpdateAsync(booking);
        await _bookingRepository.SaveChangesAsync();
    }
}
