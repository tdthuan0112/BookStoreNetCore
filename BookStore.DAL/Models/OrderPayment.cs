using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
    public class OrderPayment
    {
        public OrderPayment() { }

        [Key]
        public Guid OrderPaymentId { get; set; }
        [ForeignKey("OrderId")]
        public Guid OrderId { get; set; }
        public PaymentType PaymentType { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public DateTime Expiry { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
