using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.DAL;
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
        public async Task<IActionResult> Index()
        {
            var responseModel = new BaseResponseModel();
            var result = await _bookService.GetAllBooks();
            responseModel.Data = result;
            return ReturnData(responseModel);
        }
    }
}
