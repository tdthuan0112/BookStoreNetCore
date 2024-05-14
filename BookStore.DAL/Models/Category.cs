using System.ComponentModel.DataAnnotations;

namespace BookStore.DAL.Models
{
    public class Category
    {
        public Category() { }

        [Key, Required]
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Book> ListBooks { get; set; }
    }
}
