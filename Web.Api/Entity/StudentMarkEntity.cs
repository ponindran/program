using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Entity
{
    public class StudentMarkEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public int mark { get; set; }
        public string result { get; set; }
    }
}
