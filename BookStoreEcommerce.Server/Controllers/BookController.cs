using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreEcommerce.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : BaseController
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _bookService.GetAllBooks(baseResponseErrorModel);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpGet("GetBestSellerBooks")]
        public IActionResult GetBestSellerBooks()
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _bookService.GetBestSellerBooks(baseResponseErrorModel);
            responseModel.SetResponseError(baseResponseErrorModel);
            responseModel.Data = result;
            return ReturnData(responseModel);
        }

        [HttpGet("GetBooksByCategoryUrl/{categoryUrl}")]
        public IActionResult GetBooksByCategoryUrl(string categoryUrl)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _bookService.GetBooksByCategoryUrl(categoryUrl, baseResponseErrorModel);
            responseModel.SetResponseError(baseResponseErrorModel);

            responseModel.Data = result;
            return ReturnData(responseModel);
        }

        [HttpGet("GetBookDetailByUrl/{bookUrl}")]
        public IActionResult GetBookDetailByUrl(string bookUrl)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _bookService.GetBookDetailByUrl(bookUrl, baseResponseErrorModel);
            responseModel.SetResponseError(baseResponseErrorModel);
            responseModel.Data = result;
            return ReturnData(responseModel);
        }

        [HttpGet("GetBookDetailByBookId/{bookId}")]
        public IActionResult GetBookDetailByBookId(Guid bookId)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _bookService.GetBookDetailByBookId(bookId, baseResponseErrorModel);
            responseModel.SetResponseError(baseResponseErrorModel);
            responseModel.Data = result;
            return ReturnData(responseModel);
        }

        [HttpPost("UpdateBookDetail")]
        public IActionResult UpdateBookDetail([FromBody] RequestModelUpdateBook requestModel)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _bookService.UpdateBookDetail(requestModel, baseResponseErrorModel);
            responseModel.SetResponseError(baseResponseErrorModel);
            responseModel.Data = result;
            return ReturnData(responseModel);
        }

        [HttpPost("AddNewBook")]
        public IActionResult AddNewBook([FromBody] RequestModelAddNewBook requestModel)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _bookService.AddNewBook(requestModel, baseResponseErrorModel);
            responseModel.SetResponseError(baseResponseErrorModel);
            responseModel.Data = result;
            return ReturnData(responseModel);
        }

        [HttpDelete("DeleteBook")]
        public IActionResult AddNewBook([FromBody] Guid bookId)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _bookService.DeleteBook(bookId, baseResponseErrorModel);
            responseModel.SetResponseError(baseResponseErrorModel);
            responseModel.Data = result;
            return ReturnData(responseModel);
        }
    }
}
