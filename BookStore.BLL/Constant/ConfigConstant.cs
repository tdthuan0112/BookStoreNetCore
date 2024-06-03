namespace BookStore.BLL.Constant
{
    public class ConfigConstant
    {

    }
    public class ConfigAuthentication
    {
        public const string Authentication = "Authentication";

        public string SecretKey { get; set; } = String.Empty;
    }

    public class ConfigJwt
    {
        public const string JWT = "Jwt";
        public string SecretKey { get; set; } = String.Empty;
        public string Issuer { get; set; } = String.Empty;
        public string Audience { get; set; } = String.Empty;
        public int ExpiresInMinutes { get; set; }
    }
}
