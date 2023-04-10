using BankingSystemModels;

namespace BankingSystemWeb.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string ?AccountNumber { get; set; }
        public string ?AccountType { get; set; }
        public decimal Balance { get; set; }
        public bool IsLocked { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Transfer> Transfers { get; set; } // updated property

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}
