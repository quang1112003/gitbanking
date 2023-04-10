﻿namespace BankingSystemWeb.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string ?TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountId { get; set; }
        public Account ?Account { get; set; }
    }

}
