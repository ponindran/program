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
        public IActionResult Put(int id, [FromBody]  Web.Api.Entity.Scale sclEntity)
        {
           return Ok ( _sclRepository.UpdateData(id,sclEntity));
             

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _sclRepository.DeleteData(id);
        }

    }
}
