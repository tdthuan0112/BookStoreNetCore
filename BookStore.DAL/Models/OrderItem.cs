using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
    public class OrderItem
    {
        public OrderItem() { }

        [Key]
        public Guid OrderItemId { get; set; }
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public Guid OrderId { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public bool IsDiscountPercent { get; set; }
        public decimal FinalPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
    }
}
