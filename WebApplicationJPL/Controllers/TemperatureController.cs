using Microsoft.AspNetCore.Mvc;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class TemperatureController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var ambientTemperatureResponse = await client.GetAsync("http://192.168.68.35:8082/api/AmbentTemperature");
            var ambientTemperatureData = await ambientTemperatureResponse.Content.ReadAsAsync<List<AmbentTemperature>>();

            var moduleTemperatureResponse = await client.GetAsync("http://192.168.68.35:8082/api/ModuleTemperature");
            var moduleTemperatureData = await moduleTemperatureResponse.Content.ReadAsAsync<List<ModuleTemperature>>();

            var viewModel = new TemperatureModels
            {
                AmbentTemperatures = ambientTemperatureData,
                ModuleTemperatures = moduleTemperatureData
            };

            return View(viewModel);
        }
    }
}
