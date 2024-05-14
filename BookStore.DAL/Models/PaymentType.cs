using System.ComponentModel.DataAnnotations;

namespace BookStore.DAL.Models
{
    public class PaymentType
    {
        public PaymentType() { }

        [Key]
        public Guid PaymentTypeId { get; set; }
        public string BankName { get; set; }
        public string PaymentMethod { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }
    }
}
