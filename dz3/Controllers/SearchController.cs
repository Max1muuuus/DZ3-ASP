using Microsoft.AspNetCore.Mvc;

namespace dz3.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        public IActionResult Index(string query)
        {
            ViewBag.Query = query;

            return View();
        }
    }
}
