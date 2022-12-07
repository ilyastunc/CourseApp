using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            // int saat = DateTime.Now.Hour;

            // ViewBag.Greeting = saat > 12 ? "İyi günler" : "Günaydın";
            // ViewBag.UserName = "Barış";
            return View();
            //return Content("Hello World");  -- Direkt bir content döndürmek için
            //return NotFound();    --Not found sayfası döndürmek için
            //return new EmptyResult(); --boş sayfa döndürmek için
            //return RedirectToAction("List","Course"); -- başka bir Controller'ın bir view'ini döndürmek için
        }

        public IActionResult About() 
        {
            return View();
        }
    }
}