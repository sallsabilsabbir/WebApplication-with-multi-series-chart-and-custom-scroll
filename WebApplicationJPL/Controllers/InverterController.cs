using Microsoft.AspNetCore.Mvc;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class InverterController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var InverterAcPowerResponse = await client.GetAsync("http://192.168.68.35:8082/api/InverterAcPower");
            var InverterAcPowerData = await InverterAcPowerResponse.Content.ReadAsAsync<List<InverterAcPower>>();

            var InverterDcPowerResponse = await client.GetAsync("http://192.168.68.35:8082/api/InverterDcPower");
            var InverterDcPowerData = await InverterDcPowerResponse.Content.ReadAsAsync<List<InverterDcPower>>();

            var InverterEfficiencyResponse = await client.GetAsync("http://192.168.68.35:8082/api/InverterEfficiency");
            var InverterEfficiencyData = await InverterEfficiencyResponse.Content.ReadAsAsync<List<InverterEfficiency>>();

            var InverterTotalAcPowerResponse = await client.GetAsync("http://192.168.68.35:8082/api/InverterTotalAcPower");
            var InverterTotalAcPowerData = await InverterTotalAcPowerResponse.Content.ReadAsAsync<List<InverterTotalAcPower>>();

            var InverterTotalDcPowerResponse = await client.GetAsync("http://192.168.68.35:8082/api/InverterTotalDcPower");
            var InverterTotalDcPowerData = await InverterTotalDcPowerResponse.Content.ReadAsAsync<List<InverterTotalDcPower>>();

            
            var viewModel = new InverterModels
            {
                InverterAcPowers = InverterAcPowerData,
                InverterDcPowers = InverterDcPowerData,
                InverterEfficiencys = InverterEfficiencyData,
                InverterTotalAcPowers = InverterTotalAcPowerData,
                InverterTotalDcPowers = InverterTotalDcPowerData,
               
            };

            return View(viewModel);
        }
    }
}
