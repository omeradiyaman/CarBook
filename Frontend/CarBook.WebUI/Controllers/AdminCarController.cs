﻿using CarBook.Dto.BrandDtos;
using CarBook.Dto.CarDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace CarBook.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminCarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
    
        public async Task<IActionResult> Index()
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "carbooktoken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var responseMessage = await client.GetAsync("https://localhost:7263/api/Car/GetCarWithBrand");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultCarWithBrandDto>>(jsonData);
                    return View(values);
                }
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateCar()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7263/api/Brand");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultBrandDto>>(jsonData);

            //Query syntax, daha karmaşık olan işlemlerde kullan. Burada landa olanı kullanmak daha mantıklıdır. Ayrıca select işlemini karşıya atmak için Http.DropDownListFor yerine asp-for tag helperlarını kullandık çok daha sağlıklıdır.
            //List<SelectListItem> brandValues = (from x in values
            //                                    select new SelectListItem
            //                                    {
            //                                        Text = x.Name,
            //                                        Value = x.BrandId.ToString()
            //                                    }).ToList();

            List<SelectListItem> brandValues = values.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.BrandId.ToString()
            }).ToList();

            ViewBag.brandValues = brandValues;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarDto createCarDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCarDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7263/api/Car", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteCar(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7263/api/Car/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCar(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage1 = await client.GetAsync("https://localhost:7263/api/Brand");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            var values1 = JsonConvert.DeserializeObject<List<ResultBrandDto>>(jsonData1);
            List<SelectListItem> brandValues = values1.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.BrandId.ToString()
            }).ToList();

            ViewBag.brandValues = brandValues;


            var responseMessage = await client.GetAsync($"https://localhost:7263/api/Car/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCarDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCar(UpdateCarDto updateCarDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCarDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7263/api/Car/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}
