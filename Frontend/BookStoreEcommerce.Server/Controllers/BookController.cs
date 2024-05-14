using Microsoft.AspNetCore.Mvc;

namespace BookStoreEcommerce.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
