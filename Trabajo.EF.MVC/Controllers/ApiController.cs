using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Trabajo.EF.MVC.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public async Task<ActionResult> Poke()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon");


            return View();
        }
    }
}