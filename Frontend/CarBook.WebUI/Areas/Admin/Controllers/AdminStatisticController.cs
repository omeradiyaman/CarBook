using CarBook.Dto.StatisticDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminStatisticController : AdminBaseController
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
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

            var responseMessage3 = await client.GetAsync("https://localhost:7263/api/Statistic/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int authorCountRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData3);
                ViewBag.authorCount = values3.AuthorCount;
                ViewBag.authorCountRandom = authorCountRandom;
            }

            var responseMessage4 = await client.GetAsync("https://localhost:7263/api/Statistic/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int blogCountRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData4);
                ViewBag.blogCount = values4.BlogCount;
                ViewBag.blogCountRandom = blogCountRandom;
            }

            var responseMessage5 = await client.GetAsync("https://localhost:7263/api/Statistic/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int brandCountRandom = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData5);
                ViewBag.brandCount = values5.BrandCount;
                ViewBag.brandCountRandom = brandCountRandom;

            }

            var responseMessage6 = await client.GetAsync("https://localhost:7263/api/Statistic/GetAvgRentPriceForDaily\r\n");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int avgPriceDailyRandom = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData6);
                ViewBag.avgPriceDaily = values6.AvgPriceDaily;
                ViewBag.avgPriceDailyRandom = avgPriceDailyRandom;

            }
            var responseMessage7 = await client.GetAsync("https://localhost:7263/api/Statistic/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int avgPriceWeeklyRandom = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData7);
                ViewBag.avgPriceWeekly = values7.AvgPriceWeekly;
                ViewBag.avgPriceWeeklyRandom = avgPriceWeeklyRandom;

            }

            var responseMessage8 = await client.GetAsync("https://localhost:7263/api/Statistic/GetAvgRentPriceForHourly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int avgPricehourlyRandom = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData8);
                ViewBag.avgPriceHourly = values8.AvgPriceHourly;
                ViewBag.avgPriceHourlyRandom = avgPricehourlyRandom;
            }

            var responseMessage9 = await client.GetAsync("https://localhost:7263/api/Statistic/GetCarCountByTransmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int autoTransmissionCarCountRandom = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData9);
                ViewBag.autoTransmissionCarCount = values9.AutoTransmissionCarCount;
                ViewBag.autoTransmissionCarCountRandom = autoTransmissionCarCountRandom;

            }
            var responseMessage10 = await client.GetAsync("https://localhost:7263/api/Statistic/GetBrandNameByMaxCar");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int brandNameRandom = random.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData10);
                ViewBag.brandName = values10.BrandName;
                ViewBag.brandNameRandom = brandNameRandom;

            }

            var responseMessage11 = await client.GetAsync("https://localhost:7263/api/Statistic/GetBlogTitleByMaxBlogComment");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int blogTitleRandom = random.Next(0, 101);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData11);
                ViewBag.blogTitle = values11.BlogTitle;
                ViewBag.blogTitleRandom = blogTitleRandom;

            }

            var responseMessage12 = await client.GetAsync("https://localhost:7263/api/Statistic/GetCarCountByKmLessThanAThousand");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int carCountByLessThanAThousandKmRandom = random.Next(0, 101);
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData12);
                ViewBag.carCountByLessThanAThousandKm = values12.CarCountByLessThanAThousandKm;
                ViewBag.carCountByLessThanAThousandKmRandom = carCountByLessThanAThousandKmRandom;

            }

            var responseMessage13 = await client.GetAsync("https://localhost:7263/api/Statistic/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int fuelGasolineOrDieselCarCountRandom = random.Next(0, 101);
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData13);
                ViewBag.fuelGasolineOrDieselCarCount = values13.FuelGasolineOrDieselCarCount;
                ViewBag.fuelGasolineOrDieselCarCountRandom = fuelGasolineOrDieselCarCountRandom;

            }

            var responseMessage14 = await client.GetAsync("https://localhost:7263/api/Statistic/GetCarCountByFuelElectric");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int fuelElectricCountRandom = random.Next(0, 101);
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData14);
                ViewBag.fuelElectricCarCount = values14.FuelElectricCarCount;
                ViewBag.fuelElectricCountRandom = fuelElectricCountRandom;

            }

            var responseMessage15 = await client.GetAsync("https://localhost:7263/api/Statistic/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage15.IsSuccessStatusCode)
            {
                int maxPriceCarBrandAndModelRandom = random.Next(0, 101);
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData15);
                ViewBag.maxPriceCarBrandAndModel = values15.MaxPriceCarBrandAndModel;
                ViewBag.maxPriceCarBrandAndModelRandom = maxPriceCarBrandAndModelRandom;

            }

            var responseMessage16 = await client.GetAsync("https://localhost:7263/api/Statistic/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage16.IsSuccessStatusCode)
            {
                int minPriceCarBrandAndModelRandom = random.Next(0, 101);
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData16);
                ViewBag.minPriceCarBrandAndModel = values16.MinPriceCarBrandAndModel;
                ViewBag.minPriceCarBrandAndModelRandom = minPriceCarBrandAndModelRandom;

            }

            return View();
        }
    }
}
