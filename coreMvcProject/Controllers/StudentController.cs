using coreMvcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcProject.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student(){ Id=101, Name="King Kochhar", Age=23},
            new Student(){ Id=102, Name="Gautam Bhalla", Age=42},
            new Student(){ Id=103, Name="Sarah Bowling", Age=30},
            new Student(){ Id=104, Name="John Smith", Age=43},
            new Student(){ Id=105, Name="Roger Lee", Age=34},
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Student Management System";
            ViewBag.StudentCount = students.Count();
            ViewBag.Students = students;
            return View();
        }
        public IActionResult Details()
        {
            ViewData["Message"] = "Student Management System";
            ViewData["StudentCount"] = students.Count();
            ViewData["Students"] = students;
            return View();
        }
        public IActionResult Info()
        {
            TempData["Message"] = "Student Management System";
            TempData["StudentCount"] = students.Count();
            TempData["Students"] = students;
            return View();
        }
        public IActionResult TestOne()
        {
            if (TempData["Message"] == null)
                return RedirectToAction("Index", "Home");
            ViewBag.Message = TempData["Message"];
            return View();
        }
    }
}


/* The Keep Function: Used to preserve the data of TempData object even after the value is read. */

/* The Peek Function: Used to readthe value without clearing it. */