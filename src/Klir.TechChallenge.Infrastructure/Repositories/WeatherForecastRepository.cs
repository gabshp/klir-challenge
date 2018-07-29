using Klir.TechChallenge.Domain.Entities;
using Klir.TechChallenge.Domain.Interfaces;
using Klir.TechChallenge.Infrastructure.Data;
using System.Collections.Generic;

namespace Klir.TechChallenge.Infrastructure.Repositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private ForecastContext _context;

        public WeatherForecastRepository(ForecastContext context)
        {
            _context = context;
        }

        public IEnumerable<WeatherForecast> GetAll()
        {
            return _context.WeatherForecasts;
        }
    }
}
