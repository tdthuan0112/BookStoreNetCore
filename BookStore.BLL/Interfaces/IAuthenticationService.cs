using BookStore.BLL.Models.Request;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Interfaces
{
    public interface IAuthenticationService
    {
        string EncryptPassWord(string passWord);
        string DecryptPassWord(string passWord);
        LoginDTO Login(RequestModelLogin requestModel, BaseResponseErrorModel baseResponseErrorModel);
        string ValidateToken(string token, BaseResponseErrorModel baseResponseErrorModel);
    }
}
