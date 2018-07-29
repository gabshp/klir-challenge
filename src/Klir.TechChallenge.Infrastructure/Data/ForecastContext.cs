using Klir.TechChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Klir.TechChallenge.Infrastructure.Data
{
    public class ForecastContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public ForecastContext(DbContextOptions<ForecastContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WeatherForecast>(entity =>
            {
                entity.ToTable("WeatherForecast");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Summary)
                    .HasColumnType("varchar(100)")
                    .IsRequired();

                entity.Property(e => e.TemperatureC).IsRequired();

                entity.Property(e => e.TemperatureF).IsRequired();

                entity.Property(e => e.DateForecast)
                    .HasColumnType("datetime2(0)")
                    .IsRequired();
            });
        }
    }
}
