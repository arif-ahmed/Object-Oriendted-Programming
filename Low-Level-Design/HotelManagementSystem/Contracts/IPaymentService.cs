using HotelManagementSystem.Models.Enums;

namespace HotelManagementSystem.Contracts;

public interface IPaymentService
{
    Task ProcessPaymentAsync(PaymentMethod paymentMethod, int bookingId, decimal amount, string remarks);
    Task RefundPaymentAsync(int bookingId, decimal amount);
    Task<decimal> GetPaymentStatusAsync(int bookingId);
}
