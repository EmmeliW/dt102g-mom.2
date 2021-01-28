using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MVC.Controllers 
{ 
    public class HomeController : Controller
    {
        public IActionResult Index([FromQuery]string name) 
        {

            ViewBag.Greeting  = "Välkommen till min trevliga sida!";

            ViewData["images"] = new List<string>{
                "flower.jpg",
                "rock.jpg", 
                "tree.jpg",
                "grass.jpg",
                "hill.jpg",
                "water.jpg"
            };

            HttpContext.Session.SetString("name", name);
            ViewBag.output = "Välkommen, " + name + " till denna trevliga sida!";
            return View();

        }
        public IActionResult WrongPage() 
        {
            ViewBag.Greeting  = "Men nu hamnade du fel....";

            return View();
        }
    }    
}