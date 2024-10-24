using CarBook.Dto.StatisticDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.DashboardComponents
{
    public class _AdminDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7263/api/Statistic/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int carCountRandom = random.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.carCount = values.CarCount;
                ViewBag.carCountRandom = carCountRandom;

            }

            var responseMessage2 = await client.GetAsync("https://localhost:7263/api/Statistic/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int locationCountRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData2);
                ViewBag.locationCount = values2.LocationCount;
                ViewBag.locationCountRandom = locationCountRandom;

            }

            var responseMessage3 = await client.GetAsync("https://localhost:7263/api/Statistic/GetBrandCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int brandCountRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData3);
                ViewBag.brandCount = values3.BrandCount;
                ViewBag.brandCountRandom = brandCountRandom;

            }

            var responseMessage4 = await client.GetAsync("https://localhost:7263/api/Statistic/GetAvgRentPriceForDaily");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int avgPriceDailyRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData4);
                ViewBag.avgPriceDaily = values4.AvgPriceDaily;
                ViewBag.avgPriceDailyRandom = avgPriceDailyRandom;

            }
            return View();
        }
    }
}
