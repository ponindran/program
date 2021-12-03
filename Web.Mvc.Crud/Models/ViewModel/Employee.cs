using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Mvc.Crud.Models.ViewModel
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
        [DisplayName("Joining Date")]
        public DateTime JoiningDate { get; set; }
    }
}
