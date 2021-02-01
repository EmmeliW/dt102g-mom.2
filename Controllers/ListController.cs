using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MVC.Models;

namespace MVC.Controllers 
{
    public class ListController : Controller
    {
        [HttpGet("/Komplimanger")]
        public IActionResult Index()  
        {            
            // Read in JSON an parse
            var JsonStr = System.IO.File.ReadAllText("KindThings.json");
            var JsonObj = JsonConvert.DeserializeObject<List<KindThings>>(JsonStr) ?? new List<KindThings>();
            return View(JsonObj);
        }

        
        [HttpGet("/LäggTill")]
        public IActionResult Add()  
        {           
            // Read in JSON an parse 
            var JsonStr = System.IO.File.ReadAllText("KindThings.json");
            var JsonThings = JsonConvert.DeserializeObject<List<KindThings>>(JsonStr);
            // Send it with viewbag
            ViewBag.Kindness = JsonThings;
            return View();
        }
 
        
        [HttpPost("/LäggTill")]
        public IActionResult Add(KindThings model) 
        {
            if(ModelState.IsValid)
            {
                // Reas in JSON
                var jsonStr = System.IO.File.ReadAllText("KindThings.json");
                var JsonObj = JsonConvert.DeserializeObject<List<KindThings>>(jsonStr);
                // Add the new
                JsonObj.Add(model);
                // Serialise
                System.IO.File.WriteAllText("KindThings.json" , JsonConvert.SerializeObject(JsonObj, Formatting.Indented));
                //Clean form
                ModelState.Clear();
            }

            // Read in JSON an parse 
            var JsonStr = System.IO.File.ReadAllText("KindThings.json");
            var JsonThings = JsonConvert.DeserializeObject<List<KindThings>>(JsonStr);
            ViewBag.Kindness = JsonThings;
            
            return View();
        }
    }    
} 