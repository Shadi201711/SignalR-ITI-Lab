using Day1SignalIR.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1SignalIR.Controllers
{
    public class AddEmp : Controller
    {
        EmpContext db;
        public AddEmp(EmpContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var Emps = db.Table_1s.ToList();
            return View(Emps);
        }

        [HttpPost]
        public IActionResult Add(Table_1 emp)
        {
            db.Table_1s.Add(emp);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
