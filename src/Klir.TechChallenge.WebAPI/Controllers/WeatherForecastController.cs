﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Klir.TechChallenge.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecast>> GetAll()
        {
            var rng = new Random();
            var number = Math.Round((decimal)rng.Next(0, 100), 0);

            //Randomly return an Error
            if (number % 2 == 0)
            {
                return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                }));
            }
            else
            {
                return StatusCode(500);
            }
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
