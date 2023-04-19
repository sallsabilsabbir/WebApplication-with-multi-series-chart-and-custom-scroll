using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{

    public class LivePowerController : Controller
    {
        //public async Task<IActionResult> Index()
        //{
        //    using var client = new HttpClient();
        //    var response = await client.GetAsync("http://192.168.68.35:8082/api/LivePower");
        //    var content = await response.Content.ReadAsStringAsync();
        //    var livePowerList = JsonConvert.DeserializeObject<List<LivePower>>(content);

        //    // Select the last value from the list
        //    var lastLivePower = livePowerList.LastOrDefault();

        //    // Create a new instance of the view model and populate it with the data
        //    var viewModel = new LivePower
        //    {
        //        Time = lastLivePower?.Time,
        //        LivePower1 = lastLivePower?.LivePower1
        //    };

        //    // Pass the view model to the view
        //    return View(viewModel);
        //}

        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("http://192.168.68.35:8082/api/LivePower");
            var content = await response.Content.ReadAsStringAsync();
            var livePowerData = JsonConvert.DeserializeObject<List<LivePower>>(content);


            var lastLivePower = livePowerData.LastOrDefault();

            ViewBag.LastLivePower = lastLivePower;

            return View(livePowerData);
        }

        //private readonly HttpClient _httpClient;

        //public LivePowerController(HttpClient httpClient)
        //{
        //    _httpClient = httpClient;
        //    _httpClient.BaseAddress = new System.Uri("http://192.168.68.35:8082/api/");
        //}

        //public async Task<IActionResult> Index()
        //{
        //    // Make a GET request to the LivePower API to retrieve all the data
        //    var response = await _httpClient.GetAsync("LivePower");
        //    response.EnsureSuccessStatusCode();
        //    var livePowerData = await response.Content.ReadAsAsync<List<LivePower>>();

        //    // Order the data by Time
        //    livePowerData.Sort((x, y) => Nullable.Compare(x.Time, y.Time));

        //    // Select the last value
        //    var lastValue = livePowerData[livePowerData.Count - 1];

        //    // Pass the data to the view
        //    ViewBag.LivePowerData = livePowerData;
        //    ViewBag.LastValue = lastValue;

        //    return View();
        //}
    }

}

