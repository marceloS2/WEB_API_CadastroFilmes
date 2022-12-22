using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {   //Aqui é um HTTP GET
        public IActionResult Index()
        {
            return View();
        } 
         public IActionResult WelCome(string name, int numTimes = 1) //este é o método de ação chama na url
         {
            ViewData["Message"] = "Oi " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
         }
    
    
    }
}