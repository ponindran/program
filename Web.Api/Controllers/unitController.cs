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
    public class unitController : ControllerBase

    {
        private readonly IScaleService _sclService;

        public unitController(IScaleService sclService)
        {
            _sclService = sclService;
        }

        [HttpPost("Scale/QuantityDetails")]
        public void PostQuantityDetails([FromBody] Scale sclDTO)
        {


            _sclService.InsertData(sclDTO);
        }
    }
}
