using BankingSystemModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankingSystemWeb.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string ?ApplicationUserId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsRead { get; set; }
        public virtual ApplicationUser ?ApplicationUser { get; set; }
    }
}
