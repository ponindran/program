using BusinessService;
using BusinessService.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Repository;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ITableRepository _tableRepo;
        

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;   

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ITableRepository tableRepo)
        {
            _logger = logger;
            _tableRepo = tableRepo;
        }

        /// <summary>
        /// Used to get the weather report
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {

            var result = await  _tableRepo.GetCompanies();

             Class1 obj = new Class1();

            return obj.GetRandom();
        }
    }
}
