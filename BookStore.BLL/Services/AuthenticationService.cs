using BookStore.BLL.Constant;
using BookStore.BLL.Enum;
using BookStore.BLL.Extensions;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;
using Microsoft.Extensions.Options;

namespace BookStore.BLL.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ConfigAuthentication _configAuth;
        private readonly IUserService _userService;
        private readonly IJwtService _jwtService;

        public AuthenticationService(IOptions<ConfigAuthentication> configAuthOptions, IUserService userService, IJwtService jwtService)
        {
            _configAuth = configAuthOptions.Value;
            _userService = userService;
            _jwtService = jwtService;
        }
        public string EncryptPassWord(string passWord)
        {
            var result = CryptoExt.Encrypt(passWord, _configAuth.SecretKey);
            return result;
        }

        public string DecryptPassWord(string passWord)
        {
            var result = CryptoExt.Decrypt(passWord, _configAuth.SecretKey);
            return result;
        }

        public LoginDTO Login(RequestModelLogin requestModel, BaseResponseErrorModel baseResponseErrorModel)
        {
            LoginDTO loginDTO = new();
            try
            {
                var user = _userService.GetUserDetailByUserName(requestModel.UserName, baseResponseErrorModel);
                if (user == null)
                {
                    baseResponseErrorModel.SetErrorModel(ResponseError.CouldNotFindUserByUserName);
                }
                if (!baseResponseErrorModel.HasError() && user != null && user.UserId != Guid.Empty)
                {
                    var userPassword = CryptoExt.Decrypt(user.UserPassword, _configAuth.SecretKey);
                    if (requestModel.Password == userPassword)
                    {
                        var jwtModel = _jwtService.GenerateJWTSecurityToken(user.UserId, user.UserName, user.Email, user.Role.RoleName);
                        loginDTO = new()
                        {
                            UserId = user.UserId,
                            UserName = user.UserName,
                            Email = user.Email,
                            Token = jwtModel.Token,
                            Expiration = jwtModel.Expiration,
                        };
                    }
                    else
                    {
                        baseResponseErrorModel.SetErrorModel(ResponseError.InCorrectPassword);
                    }
                }
            }
            catch (Exception ex)
            {
                baseResponseErrorModel.SetErrorModel(ResponseError.ErrorInLogin, ex.Message);
            }
            return loginDTO;
        }

        public string ValidateToken(string token, BaseResponseErrorModel baseResponseErrorModel)
        {
            var result = _jwtService.ValidateJWTSercurityToken(token, baseResponseErrorModel);
            return "";
        }
    }
}
