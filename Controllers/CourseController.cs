using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using CourseApp.ViewModels;

namespace CourseApp.Controllers
{
    public class CourseController:Controller
    {
        //action method
        public IActionResult Index()
        {
            var kurs = new Course() { Id=1, Name="Komple Uyglamalı Web Geliştirme"};
            var ogrenciler = new List<Student> {
                new Student() {Name = "Ahmet"},
                new Student() {Name = "Ayşe"}
            };
            // ViewData["course"] = kurs;
            // ViewBag.course = kurs;

            var viewModel = new CourseStudentsViewModel();
            viewModel.Course = kurs;
            viewModel.Students = ogrenciler;
            return View(viewModel);
        }

        public IActionResult ByReleased(int year, int month)
        {
            return Content("year:" + year + " month:" + month);
        }

        [HttpGet]
        public IActionResult Apply()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Apply(StudentResponse student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            } else {
                return View(student);
            }
            
        }

        public IActionResult Details()
        {
            var course = new Course();
            course.Name = ".Net Core Eğitim Kursu";
            course.description = "yararlı bir eğitim";
            course.isPublished = true;
            return View(course);
        }

        public IActionResult List()
        {
            var students = Repository.Students.Where(i=>i.Confirm==true);
            return View(students);
        }
    }
}