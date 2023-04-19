using Microsoft.AspNetCore.Mvc;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class EnergyController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();

            var todaysDatasResponse = await client.GetAsync("http://192.168.68.35:8082/api/TodaysDatum");
            var todaysData = await todaysDatasResponse.Content.ReadAsAsync<List<TodaysDatum>>();

            var todayPlantTotalEnergyResponse = await client.GetAsync("http://192.168.68.35:8082/api/TodayPlantTotalEnergy");
            var todayPlantTotalEnergyData = await todayPlantTotalEnergyResponse.Content.ReadAsAsync<List<TodayPlantTotalEnergy>>();

            var yesterdaysDatasResponse = await client.GetAsync("http://192.168.68.35:8082/api/YesterdaysDatum");
            var yesterdaysData = await yesterdaysDatasResponse.Content.ReadAsAsync<List<YesterdaysDatum>>();

            var yesterdayPlantTotalEnergyResponse = await client.GetAsync("http://192.168.68.35:8082/api/YesterdayPlantTotalEnergy");
            var yesterdayPlantTotalEnergyData = await yesterdayPlantTotalEnergyResponse.Content.ReadAsAsync<List<YesterdayPlantTotalEnergy>>();


            var viewModel = new EnergyModels
            {
                TodaysDatas = todaysData,
                TodayPlantTotalEnergies = todayPlantTotalEnergyData,
                YesterdaysDatas = yesterdaysData,
                YesterdayPlantTotalEnergies = yesterdayPlantTotalEnergyData
            };

            return View(viewModel);
        }
    }
}
