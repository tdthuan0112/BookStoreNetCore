namespace BookStore.BLL.Models.Response
{
    public class JwtModel { }

    public class JwtCreateModel
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }

    public class JwtResponseUserModel
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phome { get; set; }
        public string RoleName { get; set; }
    }
}
