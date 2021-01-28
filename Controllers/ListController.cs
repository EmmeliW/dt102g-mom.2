using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MVC.Models;

namespace MVC.Controllers 
{
    public class ListController : Controller
    {
        [Route ("/SnällaSaker")]
        public IActionResult Index()  
        {            
            // Läs in JSON-fil och parsa
            var JsonStr = System.IO.File.ReadAllText("KindThings.json");
            var JsonObj = JsonConvert.DeserializeObject<List<KindThings>>(JsonStr) ?? new List<KindThings>();
            return View(JsonObj);
        }

        public IActionResult Add()  
        {            
            return View();
        }

        [HttpPost]
        public IActionResult Add(KindThings model) 
        {
            if(ModelState.IsValid)
            {
                //Läs in den jsom fil som finns
                var jsonStr = System.IO.File.ReadAllText("KindThings.json");
                var JsonObj = JsonConvert.DeserializeObject<List<KindThings>>(jsonStr);
                //lägg till den nya till den befintliga
                JsonObj.Add(model);
                //serialisera den igen
                System.IO.File.WriteAllText("KindThings.json" , JsonConvert.SerializeObject(JsonObj, Formatting.Indented));
                //rensa formuläret
                ModelState.Clear();
            }
            return View();
        }
    }    
} 