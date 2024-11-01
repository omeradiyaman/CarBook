using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminDashboardController : AdminBaseController
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminDashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
