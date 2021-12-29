using Common.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.BusinessService;
using Web.Api.Repository;
using entity = Web.Api.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _proService;
        private readonly IProductRepository _proRepository;

        public ProductController(IProductService proService, IProductRepository proRepository)
        {
            _proService = proService;
            _proRepository = proRepository;
        }
        [HttpPost("post/product")]
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
        [HttpGet("get/product")]
        public IActionResult getproduct()
        {
            return Ok(_proRepository.SelectALLProduct());

        }
        [HttpPut("put/product/id")]
        public IActionResult Put([FromRoute] int id, [FromBody] Product proEntity)
        {
            //var proentity = new Entity.product();
            //proentity.price = prodto.price;
            //proentity.productname = prodto.productname;
            //return ok(_prorepository.updatedata(id, proentity));

            //var entity = _prorepository.updatedata(id, proentity);

            //var dto = new product();
            ////to do "mmapyour entity todto
            //dto.productname = proentity.productname;
            //dto.price = proentity.price;
            //return dto;


            ////return ok(_prorepository.updatedata(id, proentity));

            try
            {
                var entityObj = new entity.Product();
                entityObj.productName = proEntity.productName;
                entityObj.price = proEntity.price;

                return Ok(_proRepository.Updatedata(id, entityObj));

            }
            catch
            {
                throw;
            }
        }
      

    }
}
