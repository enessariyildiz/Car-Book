using CarBook.Dto.CarDTOs;
using CarBook.Dto.TestimonialDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultLast5CarsWithBrandComponenetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultLast5CarsWithBrandComponenetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7194/api/Cars/GetLast5CarsWithBrandQueryHandler");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast5CarsWithBrandDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
