using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;
using Web.Mvc.Crud.Models.ViewModel;


namespace Web.Mvc.Crud.Controllers
{
    public class categorycontroller : Controller
    {

        private List<category> value = new List<category> {

            new category { Id = 1, Code = "hard", cName = "pipe" },
            new category { Id = 2, Code = "hard", cName = "tank" },
            new category { Id = 3, Code = "hard", cName = "light" },

        };
        public IActionResult Index()
        {
            return View(value);
        }
    }
}


