using CarBook.Dto.StatisticDtos;
using CarBook.WebApi.ViewModels;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;

namespace CarBook.WebApi.Hubs
{
    public class CarHub : Hub
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarHub(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task SendCarCount()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7263/api/Statistic/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetCarCountViewModel>(jsonData);
                await Clients.All.SendAsync("ReceiveCarCount", values.CarCount);
            }
            else { await Clients.All.SendAsync("ReceiveCarCount", 0); }
        }
    }
}
