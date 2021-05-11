using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Trabajo.EF.MVC.Models;

namespace Trabajo.EF.MVC.Controllers
{
    public class DigiController : Controller
    {
        // GET: Poke
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var digiJson = await httpClient.GetStringAsync("https://digimon-api.vercel.app/api/digimon");
            List<DigiView> digiList = JsonConvert.DeserializeObject<List<DigiView>>(digiJson);

            return View(digiList);
        }
    }
}