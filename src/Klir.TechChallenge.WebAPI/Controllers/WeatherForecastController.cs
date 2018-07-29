using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Klir.TechChallenge.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;
        private readonly ILogger _logger;

        public WeatherForecastController(IWeatherForecastRepository weatherForecastRepository
            , ILogger<WeatherForecastController> logger)
        {
            _weatherForecastRepository = weatherForecastRepository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecast>> Get()
        {
            var rng = new Random();
            var number = rng.Next(0, 3);

            //Randomly return an Error
            if (number == 0)
            {
                _logger.LogError("Internal Server error");

                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
            else
            {
                if (number == 1)
                {
                    _logger.LogInformation("Add some delay to timeout");

                    Thread.Sleep(10000);
                }

                var forecasts = _weatherForecastRepository.GetAll();

                _logger.LogInformation("Get Weather Forecasts");

                return Ok(forecasts);
            }
        }
    }
}
