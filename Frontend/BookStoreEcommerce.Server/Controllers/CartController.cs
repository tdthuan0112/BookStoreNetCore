using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.Request;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookStoreEcommerce.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : BaseController
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpGet("GetCart")]
        public IActionResult GetCart([Required] Guid userId)
        {
            var responseModel = new BaseResponseModel();
            ResponseError responseError = ResponseError.NoError;
            var result = _cartService.GetCart(userId, ref responseError);
            responseModel.Data = result;
            responseModel.SetResponseError(responseError);
            return ReturnData(responseModel);
        }

        [HttpPost("AddToCart")]
        public IActionResult AddToCart([FromBody] RequestModelAddToCart requestModel)
        {
            var responseModel = new BaseResponseModel();
            ResponseError responseError = ResponseError.NoError;
            var result = _cartService.AddToCart(requestModel, ref responseError);
            responseModel.Data = result;
            responseModel.SetResponseError(responseError);
            return ReturnData(responseModel);
        }

        [HttpPost("UpdateCart")]
        public IActionResult UpdateCart([FromBody] RequestModelAddToCart requestModel)
        {
            var responseModel = new BaseResponseModel();
            ResponseError responseError = ResponseError.NoError;
            var result = _cartService.UpdateCart(requestModel, ref responseError);
            responseModel.Data = result;
            responseModel.SetResponseError(responseError);
            return ReturnData(responseModel);
        }

        [HttpDelete("DeleteCart")]
        public IActionResult UpdateCart([FromBody] RequestModelCart requestModel)
        {
            var responseModel = new BaseResponseModel();
            ResponseError responseError = ResponseError.NoError;
            var result = _cartService.DeleteCart(requestModel, ref responseError);
            responseModel.Data = result;
            responseModel.SetResponseError(responseError);
            return ReturnData(responseModel);
        }
    }
}
