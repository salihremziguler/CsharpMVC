using HayvanBarinagiCalisma.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HayvanBarinagiCalisma.Controllers
{
    public class CallArabaApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Araba> araclar = new List<Araba>();
           
            var hhtc = new HttpClient();
            var response = await hhtc.GetAsync("https://localhost:44393/api/ArabaApiController1");
            string resString = await response.Content.ReadAsStringAsync();
            araclar = JsonConvert.DeserializeObject<List<Araba>>(resString);
            return View(araclar);
        }
    }
}
