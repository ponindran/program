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
    public class categoryController1 : ControllerBase
    {
        private readonly Icategoryservice _catService;
        public categoryController1(Icategoryservice catService)
        {
            _catService = catService;
        }

        [HttpPost("get/arivu")]
        public IActionResult categoryDetails(category catDTO)
        {
            try
            {

                _catService.Insertdata(catDTO);
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

        [HttpPut("put/arivu")]

        private IActionResult categoryDetails1(category catDTO)
        {

            try
            {
                _catService.Updatedata(catDTO);
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
        [HttpGet("get\arivu")]
        private IActionResult categorydetails2(category catDTO)
        {
            try
            {
                _catService.Selectdata(catDTO);
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

            [HttpDelete("delete\arivu")]

            Public IActionResult categorydetails3(category catDTO)
                {

                try
                {
                    _catService.Selectdata(catDTO);
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
}


















