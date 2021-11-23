
using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api.BusinessService
{
    public interface IStudentmarkservice
    {
        public void Insertdata(StudentMarkDTO studentdto);
 
    }
}
