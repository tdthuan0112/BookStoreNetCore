using BookStore.BLL.Models.Request;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Interfaces
{
    public interface IAuthenticationService
    {
        string EncryptPlainText(string plainText);
        string DecryptPlainText(string plainText);
        string HashPassword(string passWord);
        bool VerifyPassword(string password, string passwordHash);
        LoginDTO Login(RequestModelLogin requestModel, BaseResponseErrorModel baseResponseErrorModel);
        string ValidateToken(string token, BaseResponseErrorModel baseResponseErrorModel);
    }
}
