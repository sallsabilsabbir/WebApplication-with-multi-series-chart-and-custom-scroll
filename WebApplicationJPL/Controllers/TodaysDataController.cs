using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using WebApplicationJPL.Models;

namespace WebApplicationJPL.Controllers
{
    public class TodaysDataController : Controller
    {
        private readonly HttpClient _httpClient;

        public TodaysDataController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        string baseUrl = "http://192.168.68.35:8082/api/";
        public async Task<ActionResult> Index()
        {
            List<TodaysDatum> TodaysData = new List<TodaysDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource Pr using HttpClient
                HttpResponseMessage getData = await client.GetAsync("TodaysDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    TodaysData = JsonConvert.DeserializeObject<List<TodaysDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(TodaysData);
        }
        public async Task<ActionResult> Energy()
        {
            List<TodaysDatum> TodaysData = new List<TodaysDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource Pr using HttpClient
                HttpResponseMessage getData = await client.GetAsync("TodaysDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    TodaysData = JsonConvert.DeserializeObject<List<TodaysDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(TodaysData);
        }
        public async Task<ActionResult> Pr()
        {
            List<TodaysDatum> TodaysData = new List<TodaysDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource Pr using HttpClient
                HttpResponseMessage getData = await client.GetAsync("TodaysDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    TodaysData = JsonConvert.DeserializeObject<List<TodaysDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(TodaysData);
        }
        public async Task<ActionResult> AcMaxPower()
        {
            List<TodaysDatum> TodaysData = new List<TodaysDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource Pr using HttpClient
                HttpResponseMessage getData = await client.GetAsync("TodaysDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    TodaysData = JsonConvert.DeserializeObject<List<TodaysDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(TodaysData);
        }
        public async Task<ActionResult> DcMaxPower()
        {
            List<TodaysDatum> TodaysData = new List<TodaysDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource Pr using HttpClient
                HttpResponseMessage getData = await client.GetAsync("TodaysDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    TodaysData = JsonConvert.DeserializeObject<List<TodaysDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(TodaysData);
        }
        public async Task<ActionResult> SpecificEnergy()
        {
            List<TodaysDatum> TodaysData = new List<TodaysDatum>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Accept.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource Pr using HttpClient
                HttpResponseMessage getData = await client.GetAsync("TodaysDatum");

                //Checking the response is successful or not which is sent using HttpClient  
                if (getData.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    string results = getData.Content.ReadAsStringAsync().Result;

                    TodaysData = JsonConvert.DeserializeObject<List<TodaysDatum>>(results);
                }
                else
                {
                    Console.Error.WriteLine("Error" + Response.StatusCode);
                }


            }
            return View(TodaysData);
        }

    }
}
