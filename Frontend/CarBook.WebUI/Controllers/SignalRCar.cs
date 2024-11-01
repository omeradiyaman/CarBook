using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class SignalRCar : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
