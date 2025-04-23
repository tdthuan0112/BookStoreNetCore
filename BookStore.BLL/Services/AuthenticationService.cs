using BCrypt.Net;
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
        private readonly ILoggingConsoleService _loggingConsoleService;
        private const int WORK_FACTOR = 13;

        public AuthenticationService(IOptions<ConfigAuthentication> configAuthOptions, IUserService userService, IJwtService jwtService, ILoggingConsoleService loggingConsoleService)
        {
            _configAuth = configAuthOptions.Value;
            _userService = userService;
            _jwtService = jwtService;
            _loggingConsoleService = loggingConsoleService;
        }

        public string EncryptPlainText(string plainText)
        {
            var result = CryptoExt.Encrypt(plainText, _configAuth.SecretKey);
            return result;
        }

        public string DecryptPlainText(string plainText)
        {
            var result = CryptoExt.Decrypt(plainText, _configAuth.SecretKey);
            return result;
        }

        public string HashPassword(string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, WORK_FACTOR);
            return passwordHash;
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, passwordHash);
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
                    if (VerifyPassword(requestModel.Password, user.UserPassword))
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
