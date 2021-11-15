using Common.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/  fwlink/?LinkID=397860

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITableRepository _tableRepo;

        public ValuesController(ITableRepository tableRe)
        {
            _tableRepo = tableRe;
        }

        // GET: api/values/get
        [HttpGet("get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "selva", "value2" };
        }


        [HttpGet("get/second")]
        public IEnumerable<string> GetSecond()
        {

            string[] obj = new string[] { "selva", "value2"  };


            return new string[] { "selva", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("test/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost("test/post/singleparmater")]
        public void Post([FromBody] string us)
        { 
        }


        [HttpPost("test/post/userdetail")]
        public IActionResult PostUserDetsail([FromBody] UserDetail user)
        {
                                       
            try
            {
                if (user.FirstName == null)
                {
                    throw new InvalidOperationException("");
                }

                //To Do : Add validation
                //1. Empty or not 
                //Valid email ID
                //Valid Age

                //Connect

              // await _tableRepo.InterData(user);

                return Ok("test");
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex);
            }
            catch (Exception ex)
            {
                return Unauthorized(ex);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        { 
        }
    }
}
