using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Trabajo.EF.Entities;

namespace Trabajo.EF.Data
{
    public class DigiData : Controller
    {
        public async Task<string> DigiLista()
        {
            var httpClient = new HttpClient();
            var digiJson = await httpClient.GetStringAsync("https://digimon-api.vercel.app/api/digimon");
            return digiJson;
        }
    }
}