using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.Request;
using BookStore.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookStoreEcommerce.Server.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class OrderController : BaseController
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("GetAllUserOrders")]
        public IActionResult GetAllUserOrders([Required] Guid userId)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _orderService.GetAllUserOrders(userId, baseResponseErrorModel);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpPost("SubmitOrder")]
        public IActionResult SubmitOrder(RequestSubmitOrder request)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _orderService.SubmitOrder(request, baseResponseErrorModel);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpGet("GetOrderDetailByOrderId")]
        public IActionResult GetOrderDetailByOrderId([Required] Guid orderId)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _orderService.GetOrderDetailByOrderId(orderId, baseResponseErrorModel);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }
    }
}
