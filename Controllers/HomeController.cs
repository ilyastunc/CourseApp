using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;
using CourseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
             int saat = DateTime.Now.Hour;

             ViewBag.Greeting = saat > 12 ? "İyi günler" : "Günaydın";
             ViewBag.UserName = "Barış";
            
            return View();
            //return Content("Hello World");  -- Direkt bir content döndürmek için
            //return NotFound();    --Not found sayfası döndürmek için
            //return new EmptyResult(); --boş sayfa döndürmek için
            //return RedirectToAction("List","Course"); -- başka bir Controller'ın bir view'ini döndürmek için
        }

        public IActionResult Index2()
        {
            var categories = new List<Category>() 
            {
                new Category(){Name="Category 1"},
                new Category(){Name="Category 2"},
                new Category(){Name="Category 3"}
            };

            var products = new List<Product>()
            {
                new Product(){Name="Product 1"},
                new Product(){Name="Product 2"},
                new Product(){Name="Product 3"}
            };

            var productCategory = new ProductsCategoriesViewModel();
            productCategory.Categories = categories;
            productCategory.Products = products;


            return View(productCategory);
        }

        public IActionResult About() 
        {
            var categories = new List<Category>() 
            {
                new Category(){Name="Category 1"},
                new Category(){Name="Category 2"},
                new Category(){Name="Category 3"}
            };

            var products = new List<Product>()
            {
                new Product(){Name="Product 1"},
                new Product(){Name="Product 2"},
                new Product(){Name="Product 3"}
            };

            var productCategory = new ProductsCategoriesViewModel();
            productCategory.Categories = categories;
            productCategory.Products = products;


            return View(productCategory);
        }
    }
}