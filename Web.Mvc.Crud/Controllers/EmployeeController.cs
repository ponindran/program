using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Mvc.Crud.Models.ViewModel;

namespace Web.Mvc.Crud.Controllers
{
    public class EmployeeController : Controller
    {
        private List<Employee> values = new List<Employee> {

            new Employee { EmployeeId = 1, Address = "Csk", Name="Dhoni", Designation = "Caption-Wk", JoiningDate = DateTime.Now.AddYears(-1) },
            new Employee { EmployeeId = 2, Address = "Csk", Name="Raina", Designation = "Batsman", JoiningDate = DateTime.Now.AddYears(-1) },
            new Employee { EmployeeId = 3, Address = "Csk", Name="Jadeja", Designation = "Bowler", JoiningDate = DateTime.Now.AddYears(-1) },
        };

        public IActionResult Index()
        {
            
            return View(values);
        }

        //AddOrEdit Get Method
        public async Task<IActionResult> AddOrEdit(int? employeeId)
        {
            var result = values.Find(x => x.EmployeeId == employeeId);
            return View(result);
        }

        //AddOrEdit Post Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int employeeId, [Bind("EmployeeId,Name,Designation,Address,Salary,JoiningDate")]
        Employee employeeData)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var maxValue = values.Max(x => x.EmployeeId);

                    employeeData.EmployeeId = maxValue +1 ;

                    values.Add(employeeData);

                }
                catch (Exception)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employeeData);
        }

        // Employee Details
        public async Task<IActionResult> Details(int? employeeId)
        {
            if (employeeId == null)
            {
                return NotFound();
            }

            var result = values.Find(x => x.EmployeeId == employeeId);
            return View(result);
        }

        // GET: Employees/Delete/1
        public async Task<IActionResult> Delete(int? employeeId)
        {
            if (employeeId == null)
            {
                return NotFound();
            }
            var result = values.Find(x => x.EmployeeId == employeeId);

            return View(result);
        }

        // POST: Employees/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int employeeId)
        {
            //TO Do : Employee 

            var result = values.Find(x => x.EmployeeId == employeeId);
            values.Remove(result);
            return RedirectToAction(nameof(Index));
        }

    }
}
