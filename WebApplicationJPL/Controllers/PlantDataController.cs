using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class PlantDataController : Controller
    {

        private readonly HttpClient _httpClient;

        public PlantDataController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        string baseUrl = "http://192.168.68.35:8082/api/";
        public async Task<ActionResult> Index()
        {
            List<PlantDatum> PlantData = new List<PlantDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource PlantDatum using HttpClient
                HttpResponseMessage getData = await client.GetAsync("PlantDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PlantData = JsonConvert.DeserializeObject<List<PlantDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PlantData);
        }
        public async Task<ActionResult> PlantNetGeneration()
        {
            List<PlantDatum> PlantData = new List<PlantDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource PlantDatum using HttpClient
                HttpResponseMessage getData = await client.GetAsync("PlantDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PlantData = JsonConvert.DeserializeObject<List<PlantDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PlantData);
        }
        public async Task<ActionResult> Import()
        {
            List<PlantDatum> PlantData = new List<PlantDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource PlantDatum using HttpClient
                HttpResponseMessage getData = await client.GetAsync("PlantDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PlantData = JsonConvert.DeserializeObject<List<PlantDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PlantData);
        }
        public async Task<ActionResult> Export()
        {
            List<PlantDatum> PlantData = new List<PlantDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource PlantDatum using HttpClient
                HttpResponseMessage getData = await client.GetAsync("PlantDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PlantData = JsonConvert.DeserializeObject<List<PlantDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PlantData);
        }
        public async Task<ActionResult> TodayNetGeneration()
        {
            List<PlantDatum> PlantData = new List<PlantDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource PlantDatum using HttpClient
                HttpResponseMessage getData = await client.GetAsync("PlantDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PlantData = JsonConvert.DeserializeObject<List<PlantDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PlantData);
        }
        public async Task<ActionResult> TodayImport()
        {
            List<PlantDatum> PlantData = new List<PlantDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource PlantDatum using HttpClient
                HttpResponseMessage getData = await client.GetAsync("PlantDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PlantData = JsonConvert.DeserializeObject<List<PlantDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PlantData);
        }
        public async Task<ActionResult> TodayExport()
        {
            List<PlantDatum> PlantData = new List<PlantDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource PlantDatum using HttpClient
                HttpResponseMessage getData = await client.GetAsync("PlantDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PlantData = JsonConvert.DeserializeObject<List<PlantDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PlantData);
        }

    }
}
