using BookStore.BLL.Models;
using BookStore.BLL.Models.Response;

namespace BookStore.BLL.Interfaces
{
    public interface IJwtService
    {
        JwtCreateModel GenerateJWTSecurityToken(Guid userId, string userName = "", string email = "", string roleName = "");
        JwtResponseUserModel ValidateJWTSercurityToken(string jwtToken, BaseResponseErrorModel responseErrorModel);
    }
}
