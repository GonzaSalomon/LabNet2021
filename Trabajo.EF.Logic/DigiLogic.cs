using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Data;
using Trabajo.EF.Entities;

namespace Trabajo.EF.Logic
{
    public class DigiLogic
    {
        public async Task<List<Digimon>> GetAll()
        {
            var digidata = new DigiData();
            try
            {
                var digiJson = await digidata.DigiLista();
                List<Digimon> digiList = JsonConvert.DeserializeObject<List<Digimon>>(digiJson);
                return digiList;
            }
            catch (Exception)
            {
                List<Digimon> digiList = new List<Digimon>();
                return digiList;
            }
        }
    }
}
