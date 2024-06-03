namespace BookStore.BLL.Models.Request
{
    public class RequestModelAuthentication
    {
    }

    public class RequestModelLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
