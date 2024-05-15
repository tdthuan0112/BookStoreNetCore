using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
    public class BookCategory
    {
        [ForeignKey("BookId")]
        public Guid BookId { get; set; }
        [ForeignKey("CategoryId")]
        public Guid CategoryId { get; set; }
    }
}
