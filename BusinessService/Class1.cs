using BusinessService.Dto;
using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessService
{
    public class Class1
    {

        private static readonly string[] Summaries = new[]
       {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public IEnumerable<WeatherForecast> GetRandom()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        public void GetRandomUserDetail(UserDetail user)
        {

        }
    }
}
