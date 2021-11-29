using Common.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.BusinessService;
using Web.Api.Repository;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentmarkController : ControllerBase
    {
        private readonly IStudentmarkservice _stuService;
        private readonly IStudentmarkrepository _sturepository;

        public StudentmarkController(IStudentmarkservice stuService,IStudentmarkrepository sturepository)

        {
            _stuService = stuService;
            _sturepository = sturepository;
        }
        [HttpGet("Student/MarkList")]
        public IActionResult Getstudentmark()
        {
            return Ok(_sturepository.selectALLQuantity());
        }

        [HttpPost("Student/MarkList")]
        public void PostQuantityDetails([FromBody] StudentMarkDTO stu)
        {
            _stuService.Insertdata(stu);

        }
    }
}
