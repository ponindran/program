using Common.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.BusinessService;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentmarkController : ControllerBase
    {
        private readonly IStudentmarkservice _stuService;

        public StudentmarkController(IStudentmarkservice stuService)
        {
            _stuService = stuService;
        }

        [HttpPost("Student/MarkList")]
        public void PostQuantityDetails([FromBody] StudentMarkDTO stu)
        {
            _stuService.Insertdata(stu);

        }
    }
}
