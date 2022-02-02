using HotelManagementSystem.Contracts;

namespace HotelManagementSystem.Services;

public class PushNotificationService : INotificationService
{
    public async Task SendNotificationAsync(string subject, string body)
    {
        await Task.CompletedTask;
    }
}
