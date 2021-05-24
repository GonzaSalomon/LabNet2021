using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Trabajo.EF.Logic;
using Trabajo.EF.MVC.Models;

namespace Trabajo.EF.MVC.Controllers
{
    public class DigiController : Controller
    {
        public async Task<ActionResult> Index()
        {
            try
            {
                DigiLogic digiLogic = new DigiLogic();
                var prevista = await digiLogic.GetAll();
                List<DigiView> digimonApi = prevista.Select(d => new DigiView
                {
                    Img = d.Img,
                    Level = d.Level,
                    Name = d.Name
                }).ToList();
                return View(digimonApi);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return RedirectToAction("Index", "Error", ex);
            }
            catch (NullReferenceException ex)
            {
                return RedirectToAction("Index", "Error", ex);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", ex);
            }

        }
    }
}