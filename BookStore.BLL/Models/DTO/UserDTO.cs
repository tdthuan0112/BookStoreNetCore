using BookStore.DAL.Models;

namespace BookStore.BLL.Models.DTO
{
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        /// <summary>
        /// 0: Female
        /// 1: Male
        /// </summary>
        public int Gender { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; } = string.Empty;
        public int DistrictId { get; set; }
        public string DistrictName { get; set; } = string.Empty;
        public int WardId { get; set; }
        public string WardName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }
        public Guid DefaultUserPaymentId { get; set; }

        public Role Role { get; set; }
    }
}
