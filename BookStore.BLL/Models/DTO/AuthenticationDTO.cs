namespace BookStore.BLL.Models.DTO
{
    public class LoginDTO
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Token {  get; set; } = string.Empty;
        public DateTime Expiration { get; set; }
    }
}
