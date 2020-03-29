
namespace SRP.InvoicingSystem.After.Contracts
{
    public interface ISender
    {
        void SendEmail(string from, string to, string subject, string body);
    }
}
