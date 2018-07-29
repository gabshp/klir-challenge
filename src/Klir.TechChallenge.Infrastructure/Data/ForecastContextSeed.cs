using Klir.TechChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Klir.TechChallenge.Infrastructure.Data
{
    public static class ForecastContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().HasData(
                new WeatherForecast { Id = 1, Summary = "Scorching", TemperatureC = 32, TemperatureF = 89, DateForecast = new DateTime(2018, 6, 24) },
                new WeatherForecast { Id = 2, Summary = "Mild", TemperatureC = 45, TemperatureF = 112, DateForecast = new DateTime(2018, 6, 25) },
                new WeatherForecast { Id = 3, Summary = "Mild", TemperatureC = -4, TemperatureF = 25, DateForecast = new DateTime(2018, 6, 26) },
                new WeatherForecast { Id = 4, Summary = "Balmy", TemperatureC = 16, TemperatureF = 60, DateForecast = new DateTime(2018, 6, 27) },
                new WeatherForecast { Id = 5, Summary = "Hot", TemperatureC = 53, TemperatureF = 127, DateForecast = new DateTime(2018, 6, 28) }
            );
        }
    }
}
