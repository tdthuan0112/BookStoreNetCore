using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
    public class User
    {
        public User()
        {
            UserId = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }

        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string Ward { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }
        public Guid DefaultUserPaymentId { get; set; }

        [ForeignKey(("RoleId"))]
        public virtual Role Role { get; set; }
        public virtual ICollection<UserPayment> ListUserPayments { get; set; }
    }
}
