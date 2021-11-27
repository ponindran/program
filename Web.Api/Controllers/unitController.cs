using Common.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.BusinessService;
using Web.Api.Repository;
using entity = Web.Api.Entity;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class unitController : ControllerBase

    {
        private readonly IScaleService _sclService;
        private readonly IScalerepository _sclRepository;

        public unitController(IScaleService sclService, IScalerepository sclRepository)
        {
            _sclService = sclService;
            _sclRepository = sclRepository;
        }

        
        [HttpGet("get/Quantity")]
        public IActionResult getQuantity() 
        {
           
            return Ok( _sclRepository.SelectALLQuantity());

         }
        [HttpPost("Scale/QuantityDetails")]
        public IActionResult PostQuantityDetails([FromBody] Scale sclDTO)
        {
            try
            {

                _sclService.InsertData(sclDTO);
                return Ok("test");
            }
            catch (Exception ex) 
            {
                return Unauthorized(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Scale sclEntity)
        {
            try
            {
                var entityObj = new entity.Scale();
                entityObj.code = sclEntity.code;
                entityObj.name = sclEntity.name;



                return Ok(_sclRepository.UpdateData(id, entityObj));
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_sclRepository.DeleteData(id));
        }

    }
}
