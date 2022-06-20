using COMP2084_PROJECT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace COMP2084_PROJECT.Controllers
{
    public class EmployeesController : Controller
    {
        static List<EmployeesModel> employeeList = new List<EmployeesModel>
        {
            new EmployeesModel { Id = 1, Name = "Shahil", Age = 18, Contact = 6475028892, Gender = "Male"},
            new EmployeesModel { Id = 2, Name = "Shreya", Age = 26, Contact = 6475828892, Gender = "Female"},
            new EmployeesModel { Id = 3, Name = "Abhi", Age = 22, Contact = 6475628892, Gender = "Male"}
        };

        // GET: EmployeesController
        public ActionResult Index()
        {
            ViewBag.MyNumber = 1;

            return View(employeeList);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            var selected = employeeList.First<EmployeesModel>(x => x.Id == id);
            ViewBag.Message = "The selected Employee is " + selected.Name;
            return View();
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
