using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
    public class CartItem
    {
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        [ForeignKey("BookId")]
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
    }
}
