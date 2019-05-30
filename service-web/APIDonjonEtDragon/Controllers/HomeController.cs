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
                    //Passing service base url  
                    client.BaseAddress = new Uri(Baseurl);

                    client.DefaultRequestHeaders.Clear();
                    //Define request data format  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                    HttpResponseMessage Res = await client.GetAsync("api/damage-types");

                    //Checking the response is successful or not which is sent using HttpClient  
                    if (Res.IsSuccessStatusCode)
                    {
                        //Storing the response details recieved from web api   
                        var DMGResponse = Res.Content.ReadAsStringAsync().Result;

                        //Deserializing the response recieved from web api and storing into the Employee list  
                        DMG = JsonConvert.DeserializeObject<List<Damage_types>>(DMGResponse);

                    }
                    //returning the employee list to view  
                    return View(DMG);
                }
            }
        
    }
}