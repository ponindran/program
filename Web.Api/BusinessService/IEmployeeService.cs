using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.BusinessService
{
    public interface IEmployeeService
    {
        public void InserData(Employee empdto);
    }
}
