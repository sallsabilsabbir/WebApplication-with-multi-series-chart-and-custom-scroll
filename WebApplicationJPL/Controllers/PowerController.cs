using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class PowerController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            //var LivePowerResponse = await client.GetAsync("http://192.168.68.35:8082/api/LivePower");
            //var LivePowerData = await LivePowerResponse.Content.ReadAsAsync<List<LivePower>>();

            var MaxAcPowerResponse = await client.GetAsync("http://192.168.68.35:8082/api/MaxAcPower");
            var MaxAcPowerData = await MaxAcPowerResponse.Content.ReadAsAsync<List<MaxAcPower>>();

            var MaxDcPowerResponse = await client.GetAsync("http://192.168.68.35:8082/api/MaxDcPower");
            var MaxDcPowerData = await MaxDcPowerResponse.Content.ReadAsAsync<List<MaxDcPower>>();

            var viewModel = new PowerModels
            {
                //LivePowers = LivePowerData,
                MaxAcPowers = MaxAcPowerData,
                MaxDcPowers = MaxDcPowerData
            };
            return View(viewModel);
        }
        
    }
}
