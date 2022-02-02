namespace HotelManagementSystem.Contracts;
public interface INotificationService
{
    Task SendNotificationAsync(string subject, string body);
}
