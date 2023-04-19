using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class LifetimeGenerationController : Controller
    {
        string baseUrl = "http://192.168.68.35:8082/api/";
        public async Task<ActionResult> Index()
        {
            List<LifetimeGeneration> LifetimeGenerationData = new List<LifetimeGeneration>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource LifetimeGeneration using HttpClient
                HttpResponseMessage getData = await client.GetAsync("LifetimeGeneration");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    LifetimeGenerationData = JsonConvert.DeserializeObject<List<LifetimeGeneration>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(LifetimeGenerationData);
        }


        private readonly HttpClient _httpClient;

        public LifetimeGenerationController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> GetChartsData()
        {
            var response = await _httpClient.GetAsync("http://192.168.68.35:8082/api/LifetimeGeneration");
            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<LifetimeGeneration>>(json);

            return Json(data);
        }
    }
}
