using CarBook.Dto.CarFeatureDtos;
using CarBook.Dto.FeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminCarFeatureDetailController : AdminBaseController
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public int id;

        public AdminCarFeatureDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.carId = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7263/api/CarFeature?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarFeatureByCarIdDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(List<ResultCarFeatureByCarIdDto> resultCarFeatureByCarIdDtos)
        {
            foreach (var item in resultCarFeatureByCarIdDtos)
            {
                if (item.Available)
                {
                    var client = _httpClientFactory.CreateClient();
                    var responseMessage = await client.GetAsync($"https://localhost:7263/api/CarFeature/CarFeatureChangeAvailableToTrue?id={item.CarFeatureId}");
                }
                else
                {
                    var client = _httpClientFactory.CreateClient();
                    var responseMessage = await client.GetAsync($"https://localhost:7263/api/CarFeature/CarFeatureChangeAvailableToFalse?id={item.CarFeatureId}");
                }
                id = item.CarId;
            }

            return RedirectToAction("Index", "AdminCar");
        }

        [HttpGet]
        public async Task<IActionResult> CreateFeatureByCarId(int carId)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7263/api/Feature");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
