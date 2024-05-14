using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
    public class Order
    {
        public Order() { }

        [Key]
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public int OrderNumber { get; set; }
        public string UserNote { get; set; }
        public decimal TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalDiscountPrice { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string OrderStatus { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }
        public virtual OrderPayment OrderPayment { get; set; }
        public virtual ICollection<OrderItem> ListOrderItems { get; set; }
    }
}
