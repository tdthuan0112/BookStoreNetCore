using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
    public class Review
    {
        public Review() { }
        [Key]
        public Guid ReviewId { get; set; }
        [ForeignKey("BookId")]
        public Guid BookId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }
    }
}
