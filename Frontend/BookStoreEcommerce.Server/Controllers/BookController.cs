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
        public async Task<IActionResult> GetAllBooks()
        {
            var responseModel = new BaseResponseModel();
            var result = await _bookService.GetAllBooks();
            responseModel.Data = result;
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

        [HttpGet("GetBookByUrl/{categoryUrl}")]
        public async Task<IActionResult> GetBookByUrl(string categoryUrl)
        {
            var responseModel = new BaseResponseModel();
            var result = await _bookService.GetBookByUrl(categoryUrl);
            responseModel.Data = result;
            return ReturnData(responseModel);
        }
    }
}
