using System;

namespace Klir.TechChallenge.Domain.Entities
{
    public class WeatherForecast : BaseEntity
    {
        public string Summary { get; set; }
        public int TemperatureF { get; set; }
        public int TemperatureC { get; set; }
        public DateTime DateForecast { get; set; }
    }
}
