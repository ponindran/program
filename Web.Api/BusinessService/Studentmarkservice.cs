using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Repository;

namespace Web.Api.BusinessService
{
    public class Studentmarkservice : IStudentmarkservice
    {
        private readonly IStudentmarkrepository _sturepository;
        public Studentmarkservice(IStudentmarkrepository sturepository)
        {
            _sturepository = sturepository;
        }
        public void Insertdata(StudentMarkDTO studentdto)
        {
            var Entity = new Web.Api.Entity.StudentMarkEntity();
            Entity.Id = studentdto.Id;
            Entity.name = studentdto.name;
            Entity.subject = studentdto.subject;
            Entity.mark = studentdto.mark;
            Entity.result = studentdto.result;
            // 
            _sturepository.Insertdata(Entity);
        }

    }
}