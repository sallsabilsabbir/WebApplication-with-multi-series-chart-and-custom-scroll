using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class ShedWiseGenerationGraphController : Controller
    {
        private readonly HttpClient _httpClient;

        public ShedWiseGenerationGraphController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        string baseUrl = "http://192.168.68.35:8082/api/";
        public async Task<ActionResult> Index()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
        public async Task<ActionResult> Shed1()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
        public async Task<ActionResult> Shed2()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
        public async Task<ActionResult> Shed3and4()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
        public async Task<ActionResult> Shed5()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
        public async Task<ActionResult> Shed6()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
        public async Task<ActionResult> Shed7()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
        public async Task<ActionResult> Shed8()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
        public async Task<ActionResult> Shed10()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
        public async Task<ActionResult> Shed11()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
        public async Task<ActionResult> Shed12()
        {
            List<ShedWiseGenerationGraph> PrData = new List<ShedWiseGenerationGraph>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource ShedWiseGenerationGraph using HttpClient
                HttpResponseMessage getData = await client.GetAsync("ShedWiseGenerationGraph");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    PrData = JsonConvert.DeserializeObject<List<ShedWiseGenerationGraph>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(PrData);
        }
    }
}
