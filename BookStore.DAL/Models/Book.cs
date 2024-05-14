using System.ComponentModel.DataAnnotations;

namespace BookStore.DAL.Models
{
    public class Book
    {
        public Book() {
            BookId = Guid.NewGuid();
        }

        [Key]
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int QuantityInStock { get; set; }
        public int QuantitySold { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public bool IsDiscountPercent { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Category> ListCategories { get; set; }
        public virtual ICollection<Review> ListReviews { get; set; }
    }
}
