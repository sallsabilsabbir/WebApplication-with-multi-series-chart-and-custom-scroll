using Microsoft.AspNetCore.Mvc;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class CumulativeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var cumulativePoaAvgResponse = await client.GetAsync("http://192.168.68.35:8082/api/CumulativePoaAvg");
            var cumulativePoaAvgData = await cumulativePoaAvgResponse.Content.ReadAsAsync<List<CumulativePoaAvg>>();

            var cumulatuivePrResponse = await client.GetAsync("http://192.168.68.35:8082/api/CumulatuivePr");
            var cumulatuivePrData = await cumulatuivePrResponse.Content.ReadAsAsync<List<CumulatuivePr>>();

            var viewModel = new CumulatuiveModels
            {
                CumulativePoaAvgs = cumulativePoaAvgData,
                CumulatuivePrs = cumulatuivePrData
            };

            return View(viewModel);
        }
    }
}
