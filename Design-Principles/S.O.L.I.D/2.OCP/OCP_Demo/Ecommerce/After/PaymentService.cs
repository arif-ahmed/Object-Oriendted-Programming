﻿namespace Ecommerce.After
{
    using System;
    public class PaymentService
    {
        public string CardNumber { get; set; }
        public string Credentials { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string NameOnCard { get; set; }
        public decimal AmountToCharge { get; set; }
    }
}
