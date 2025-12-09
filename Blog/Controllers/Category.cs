using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
