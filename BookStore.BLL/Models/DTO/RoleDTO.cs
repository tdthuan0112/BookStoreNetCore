namespace BookStore.BLL.Models.DTO
{
    public class RoleDTO
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }
    }
}
