using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Services;
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
        public async Task<IActionResult> Index()
        {
            var responseModel = new BaseResponseModel();
            var result = await _userService.GetAllUsers();
            responseModel.Data = result;
            return ReturnData(responseModel);
        }
    }
}
