using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace BookStoreEcommerce.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : BaseController
    {
        private IAuthenticationService _authService;

        public AuthenticationController(IAuthenticationService authService)
        {
            _authService = authService;
        }


        [HttpPost("EncryptPlainText")]
        public IActionResult EncryptPlainText([FromBody]string plainText)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _authService.EncryptPlainText(plainText);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpPost("DecryptPlainText")]
        public IActionResult DecryptPlainText([FromBody] string plainText)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _authService.DecryptPlainText(plainText);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpPost("HashPassword")]
        public IActionResult HashPassword([FromBody] string password)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _authService.HashPassword(password);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpPost("VerifyPassword")]
        public IActionResult VerifyPassword(string password, string passwordHash)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _authService.VerifyPassword(password, passwordHash);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] RequestModelLogin requestModel) 
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _authService.Login(requestModel, baseResponseErrorModel);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpPost("ValidateToken")]
        public IActionResult ValidateToken([FromBody] string token)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _authService.ValidateToken(token, baseResponseErrorModel);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }
    }
}
