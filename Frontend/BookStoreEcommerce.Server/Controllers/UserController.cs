using BookStore.BLL.Extensions;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookStoreEcommerce.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IJwtService _jwtService;

        public UserController(IUserService userService, IJwtService jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _userService.GetAllUsers(baseResponseErrorModel);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }


        [HttpGet("GetUserDetailById")]
        public IActionResult GetUserDetailById([Required] Guid userId)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _userService.GetUserDetailById(userId, baseResponseErrorModel);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser([Required] RequestModelAddUser requestModel)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _userService.CreateUser(requestModel, baseResponseErrorModel);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpGet("GetUserDetail")]
        public IActionResult GetUserDetail()
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            Request.Headers.TryGetValue("Authorization", out var authToken);
            string[] words = authToken.ToString().Split(' ');
            string token = words[1];
            var authResult = _jwtService.ValidateJWTSercurityToken(token, baseResponseErrorModel);
            UserDTO result = new();
            if (authResult != null && !baseResponseErrorModel.HasError() && authResult.UserId != Guid.Empty) 
            {
                result = _userService.GetUserDetailById(authResult.UserId, baseResponseErrorModel);
            }
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpDelete("DeleteUserByUserId")]
        public IActionResult DeleteUserByUserId([Required] [FromBody] Guid userId)
        { 
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _userService.DeleteUserByUserId(userId, baseResponseErrorModel);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }
    }
}
