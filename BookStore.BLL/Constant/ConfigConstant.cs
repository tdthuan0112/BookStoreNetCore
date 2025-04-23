namespace BookStore.BLL.Constant
{
    public class ConfigConstant
    {

    }
    public class ConfigAuthentication
    {
        public const string Authentication = "Authentication";

        public string SecretKey { get; set; } = String.Empty;
        //public const string SecretKey "a1c3f5d2b4876e93c0ab2d7f39e8bc41";
    }

    public class ConfigJwt
    {
        public const string JWT = "Jwt";
        public string SecretKey = "e4d9f1a77b3a4873b19fa67d9c5f8c3d";
        public string Issuer { get; set; } = String.Empty;
        public string Audience = "ThuanTran";
        public int ExpiresInMinutes = 30;
    }
}
