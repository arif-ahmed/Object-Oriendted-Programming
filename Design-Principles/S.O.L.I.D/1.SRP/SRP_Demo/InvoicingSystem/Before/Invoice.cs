namespace SRP.InvoicingSystem.Before
{
    using System;
    using System.IO;
    using System.Net.Mail;
    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        public void AddInvoice()
        {
            try
            {
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                MailMessage mailMessage = new MailMessage("invoice@xyz.com", "abc@xyz.com", "EMail Subject", "EMail Body");
                SendInvoiceEmail(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
                Console.WriteLine("Deleting Invoice");
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                Console.WriteLine($"Sending Email to {mailMessage.To}");
                // Here we need to write the Code for Email setting and sending the invoice mail
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }
}
