using System.Runtime.CompilerServices;

namespace BookStore.BLL.Models.Request
{
    public class RequestModelUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
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
        public int DistrictId { get; set; } = -1;
        public string DistrictName { get; set; } = string.Empty;
        public int WardId { get; set; } = -1;
        public string WardName { get; set; } = string.Empty;
        public int ProvinceId { get; set; } = -1;
        public string ProvinceName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }

    public class RequestModelAddUser : RequestModelUser { }
    public class RequestModelUpdateUser : RequestModelUser
    {
        public Guid UserId { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string Password { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }
}
