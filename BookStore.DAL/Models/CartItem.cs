using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
    public class CartItem
    {
        public CartItem() { }

        [Key]
        public Guid CartItemId { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        [ForeignKey("BookId")]
        public Guid BookId { get; set; }
        public bool IsActive { get; set; }
    }
}
