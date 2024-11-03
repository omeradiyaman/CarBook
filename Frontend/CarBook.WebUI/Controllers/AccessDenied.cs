using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    [Route("AccessDenied")]
    public class AccessDenied : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
