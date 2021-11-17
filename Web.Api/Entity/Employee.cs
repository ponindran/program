using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Entity
{
    /// <summary>
    /// Is used to map the table "employee" in the database
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }
        public string Email { get; set; }
    }
}
