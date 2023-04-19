using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class PoaAvgController : Controller
    {
        string baseUrl = "http://192.168.68.35:8082/api/";
        public async Task<ActionResult> Index()
        {
            List< PoaAvg> PoaAvgData = new List<PoaAvg>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource  PoaAvg using HttpClient
                HttpResponseMessage getData = await client.GetAsync("PoaAvg");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PoaAvgData = JsonConvert.DeserializeObject<List< PoaAvg>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PoaAvgData);
        }


        private readonly HttpClient _httpClient;

        public PoaAvgController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> GetChartsData()
        {
            var response = await _httpClient.GetAsync("http://192.168.68.35:8082/api/ PoaAvg");
            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List< PoaAvg>>(json);

            return Json(data);
        }
    }
}
