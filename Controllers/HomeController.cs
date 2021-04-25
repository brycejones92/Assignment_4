using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        HttpClient httpClient;

        //need to find specific base url
        static string BASE_URL = "https://developer.nrel.gov/api/alt-fuel-stations/v1/";
        static string API_KEY = "g1BPXcKFyJ2clYeVg6Ux6lFbGyuMU8I3xqPaa4pb";
        public IActionResult Index()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")); ;
            
            // need rest of URL
            
            return View();
        }
    }
}
