using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net.Http.Headers;

namespace CarBook.WebUI.Controllers
{
    public class TokenController : Controller
    {
        protected readonly IHttpClientFactory _httpClientFactory; // IHttpClientFactory

        protected string _token;

        // Constructor
        public TokenController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Token'i oluştur ve sakla
            _token = User.Claims.FirstOrDefault(x => x.Type == "carbooktoken")?.Value;
            base.OnActionExecuting(context);
        }

        protected HttpClient CreateHttpClient()
        {
            var client = _httpClientFactory.CreateClient();
            if (!string.IsNullOrEmpty(_token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            }
            return client;
        }
    }
}
