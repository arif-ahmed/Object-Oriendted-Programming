using HotelManagementSystem.Contracts;
using HotelManagementSystem.Models;
using HotelManagementSystem.Models.Enums;
using HotelManagementSystem.Services;

namespace HotelManagementSystem;
public class App
{
    private readonly BookingService _bookingService;
    private readonly UserService _userService;
    private readonly IPaymentService _paymentService;

    private readonly IList<INotificationService> _notificationServices = new List<INotificationService>();

    public App()
    {

    }

    //public App(BookingService bookingService, UserService userService, IPaymentService paymentService, IList<INotificationService> notificationServices)
    //{
    //    // Initialization code can go here if needed
    //    _bookingService = bookingService ?? throw new ArgumentNullException(nameof(bookingService));
    //    _userService = userService ?? throw new ArgumentNullException(nameof(userService));
    //    _paymentService = paymentService ?? throw new ArgumentNullException(nameof(paymentService));
    //    _notificationServices = notificationServices;
    //}

    public async Task RunAsync()
    {
        bool exitRequested = false;

        while (!exitRequested)
        {
            ShowMenu();
            Console.Write("Select an option (1-4): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    OptionOne();
                    break;
                case "2":
                    OptionTwo();
                    break;
                case "3":
                    OptionThree();
                    break;
                case "4":
                    exitRequested = true;
                    Console.WriteLine("Exiting application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    break;
            }

            if (!exitRequested)
            {
                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("===== My Console App Menu =====");
        Console.WriteLine("1. Option One");
        Console.WriteLine("2. Option Two");
        Console.WriteLine("3. Option Three");
        Console.WriteLine("4. Exit");
        Console.WriteLine("================================");
    }

    static void OptionOne()
    {
        Console.WriteLine("You selected Option One.");
        // Add your business logic here
    }

    static void OptionTwo()
    {
        Console.WriteLine("You selected Option Two.");
        // Add your business logic here
    }

    static void OptionThree()
    {
        Console.WriteLine("You selected Option Three.");
        // Add your business logic here
    }

    private async Task BookRoomByReceptionist()
    {
        // 1. search room for booking
        // 2. request booking
        // 3. make payment
        // 4. confirm booking

        var checkInDate = new DateOnly(2023, 10, 1);
        var checkOutDate = new DateOnly(2023, 10, 5);
        var roomStyle = RoomStyle.Standard;
        var bookings = await _bookingService.Search(checkInDate, checkOutDate, roomStyle);

        if(!bookings.Any())
        {
            Console.WriteLine("No bookings found for the specified dates and room style.");
            return;
        }

        var userExist = await _userService.GetUserByEmailAsync("john.doe@gmail.com");

        if (userExist != null) 
        {
            await _userService.AddUserAsync(new User("John", "Doe", "john.doe@gmail.com", "123456"));
        }

        await _paymentService.ProcessPaymentAsync(PaymentMethod.CreditCard, 1, 100.00m, "Booking payment for room");

        await _bookingService.BookRoom(1, checkInDate, checkOutDate);

        _notificationServices.ToList().ForEach(async ns => await ns.SendNotificationAsync("Booking confirmed", "Your booking has been successfully confirmed."));

    }
    private async Task ConfirmChekcInByReceptionist()
    {
        var booking = await _bookingService.GetBookingById(1);
        booking.BookingStatus = BookingStatus.CheckedIn;
        await _bookingService.UpdateBookingAsync(booking);
        _notificationServices.ToList().ForEach(async ns => await ns.SendNotificationAsync("Check-in confirmed", "You have successfully checked in to your room."));
    }
    private async Task ConfirmCheckOutByReceptionist()
    {
        var booking = await _bookingService.GetBookingById(1);
        booking.BookingStatus = BookingStatus.CheckedOut;
        await _bookingService.UpdateBookingAsync(booking);
        _notificationServices.ToList().ForEach(async ns => await ns.SendNotificationAsync("Check-out confirmed", "You have successfully checked out of your room."));
    }
}
