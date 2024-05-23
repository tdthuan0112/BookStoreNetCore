using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreEcommerce.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseController
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
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
    }
}
