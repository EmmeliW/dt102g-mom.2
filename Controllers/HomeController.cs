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
        [HttpGet("/Hem")]
        public IActionResult Index([FromQuery]string name) 
        {
            if(name == null)
            {
                return View("WrongPage");
            }

            HttpContext.Session.SetString("name", name);
            ViewBag.output = "Välkommen " + name + ", till min sida!";

            ViewData["images"] = new List<string>{
                "flower.jpg",
                "rock.jpg", 
                "tree.jpg",
                "grass.jpg",
                "hill.jpg",
                "water.jpg"
            };
            return View();

        }
        public IActionResult WrongPage() 
        {
            ViewBag.Greeting  = "Men nu hamnade du fel....";

            return View();
        }
    }    
}