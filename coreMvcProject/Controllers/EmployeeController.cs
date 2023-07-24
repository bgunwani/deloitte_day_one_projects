using coreMvcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcProject.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee(){ Id=101, Name="King Kochhar", Age=23},
            new Employee(){ Id=102, Name="Gautam Bhalla", Age=42},
            new Employee(){ Id=103, Name="Sarah Bowling", Age=30},
            new Employee(){ Id=104, Name="John Smith", Age=43},
            new Employee(){ Id=105, Name="Roger Lee", Age=34},
        };
        public IActionResult Index()
        {
            return View(employees);
        }
        public IActionResult Details(int id)
        {
            /*var employee = employees[id];*/
            var employee = employees.Find(x => x.Id == id);
            return View(employee);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee) 
        {
            employees.Add(employee);
            return RedirectToAction("Index");
        }
    }
}
