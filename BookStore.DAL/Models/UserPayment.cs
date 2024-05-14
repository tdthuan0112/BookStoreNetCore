using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
    public class UserPayment
    {
        [Key, Required]
        public Guid UserPaymentId { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public string PaymentPassword { get; set; } = string.Empty;
        [ForeignKey("PaymentTypeId")]
        public PaymentType PaymentType { get; set; }
        public string AccountName { get; set; }
        public int AccountNumber { get; set; }
        public DateTime Expiry { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
    }
}
