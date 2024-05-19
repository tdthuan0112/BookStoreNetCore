using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
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
            ResponseError responseError = ResponseError.NoError;
            var result = _bookService.GetAllBooks(ref responseError);
            responseModel.Data = result;
            responseModel.SetResponseError(responseError);
            return ReturnData(responseModel);
        }

        [HttpGet("GetBestSellerBooks")]
        public async Task<IActionResult> GetBestSellerBooks()
        {
            var responseModel = new BaseResponseModel();
            var result = await _bookService.GetBestSellerBooks();
            responseModel.Data = result;
            return ReturnData(responseModel);
        }

        [HttpGet("GetBooksByCategoryUrl/{categoryUrl}")]
        public async Task<IActionResult> GetBooksByCategoryUrl(string categoryUrl)
        {
            var responseModel = new BaseResponseModel();
            var result = await _bookService.GetBooksByCategoryUrl(categoryUrl);
            responseModel.Data = result;
            return ReturnData(responseModel);
        }

        [HttpGet("GetBookDetailByUrl/{bookUrl}")]
        public IActionResult GetBookDetailByUrl(string bookUrl)
        {
            var responseModel = new BaseResponseModel();
            var result = _bookService.GetBookDetailByUrl(bookUrl);
            responseModel.Data = result;
            return ReturnData(responseModel);
        }
    }
}
