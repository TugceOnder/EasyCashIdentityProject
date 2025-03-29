using EasyCashIdentityProject.PresantationLayer.Controllers.Dovizler;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class ExchangeController : Controller
    {
        private readonly string apiKey = "a07df5be6fc937a6f35a8743"; // Kendi API Key'inizi buraya yazın

        public async Task<IActionResult> Index()
        {
            string apiUrl = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var exchangeData = JsonConvert.DeserializeObject<API_Obj>(json);

                    if (exchangeData != null && exchangeData.conversion_rates != null)
                    {
                        ViewBag.UsdToTry = exchangeData.conversion_rates.TRY;
                        ViewBag.EurToTry = exchangeData.conversion_rates.EUR * exchangeData.conversion_rates.TRY;
                        ViewBag.GbpToTry = exchangeData.conversion_rates.GBP * exchangeData.conversion_rates.TRY;
                        ViewBag.UsdToEur = exchangeData.conversion_rates.EUR;
                      
                    }
                }
            }
            return View();
        }
    }

 
}
