using Microsoft.AspNetCore.Mvc;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class GenerationController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var todaysGenerationResponse = await client.GetAsync("http://192.168.68.35:8082/api/TodaysGeneration");
            var todaysGenerationData = await todaysGenerationResponse.Content.ReadAsAsync<List<TodaysGeneration>>();

            var yesterdaysGenerationResponse = await client.GetAsync("http://192.168.68.35:8082/api/YesterdaysGeneration");
            var yesterdaysGenerationData = await yesterdaysGenerationResponse.Content.ReadAsAsync<List<YesterdaysGeneration>>();

            var viewModel = new GenerationModels
            {
                TodaysGenerations = todaysGenerationData,
                YesterdaysGenerations = yesterdaysGenerationData
            };

            return View(viewModel);
        }
    }
}
