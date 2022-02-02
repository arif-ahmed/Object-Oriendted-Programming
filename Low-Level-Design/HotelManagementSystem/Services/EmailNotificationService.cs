using HotelManagementSystem.Contracts;

namespace HotelManagementSystem.Services;
public class EmailNotificationService : INotificationService
{
    public Task SendNotificationAsync(string subject, string body)
    {
        // Here you would implement the logic to send an email notification.
        // For demonstration purposes, we will just simulate it with a completed task.
        return Task.CompletedTask;
    }
}

