
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MVC.Controllers 
{ 
    public class HomeController : Controller
    {
        [HttpGet("/Hem")]
        public IActionResult Index([FromQuery]string name) 
        {
            //Check if name is set, if not redirect to WronPage
            if(name == null)
            {
                return View("WrongPage");
            }

            //Get session variable
            HttpContext.Session.SetString("name", name);
            ViewBag.output = "Välkommen " + name + ", till min sida!";

            // List with the images names sent with viewdata
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