using Common.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.BusinessService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _proService;

        public ProductController(IProductService proService)
        {
            _proService = proService;
        }
        [HttpPost("product/details")]
        public IActionResult productdetails([FromBody] Product prodto)
        {
            try
            {
                _proService.InserData(prodto);

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










       
    }
}
