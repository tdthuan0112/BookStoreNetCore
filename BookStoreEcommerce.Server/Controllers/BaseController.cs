using BookStore.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreEcommerce.Server.Controllers
{
    public class BaseController : Controller
    {
        protected IActionResult ReturnData(BaseResponseModel model, int statusCode = 200)
        {
            return StatusCode(statusCode, model);
        }
    }
}
