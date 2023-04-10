namespace BankingSystemWeb.Models
{
    public class Transfer
    {
        public int TransferId { get; set; }
        public int SenderAccountId { get; set; }
        public int ReceiverAccountId { get; set; }
        public string ?Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransferDate { get; set; }
        public Account ?SenderAccount { get; set; }
        public Account ?ReceiverAccount { get; set; }
    }
}
