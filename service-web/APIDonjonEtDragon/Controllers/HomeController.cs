using APIDonjonEtDragon.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace APIDonjonEtDragon.Controllers
{


    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Armes()
        {
            
            

            return View();
        }

        public ActionResult Armures()
        {
            ViewBag.Message = "La liste des armures";

            return View();
        }

        public ActionResult Sorts()
        {
            ViewBag.Message = "La liste des sorts";

            return View();
        }

        public ActionResult Quizz()
        {
            ViewBag.Message = "Un petit Quizz D&D5";

            return View();
        }

        
            string Baseurl = "http://dnd5eapi.co/";
            public async Task<ActionResult> dmg()
            {
                List<Damage_types> DMG = new List<Damage_types>();

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.GetAsync("api/damage-types");

                   if (Res.IsSuccessStatusCode)
                    {
                         
                        var DMGResponse = Res.Content.ReadAsStringAsync().Result;

                    /** a changer ici : cf Trello */
                    DMGResponse = DMGResponse.Remove(0, 22);
                    DMGResponse = DMGResponse.Remove(899);

                    DMG = JsonConvert.DeserializeObject<List<Damage_types>>(DMGResponse);

                    }
                      
                    return View(DMG);
                }
            }
        
    }
}