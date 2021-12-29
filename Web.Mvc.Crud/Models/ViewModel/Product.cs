using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Mvc.Crud.Models.ViewModel
{
    public class Product
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
    }
}
