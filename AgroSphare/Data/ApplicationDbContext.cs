using Microsoft.EntityFrameworkCore;
using AgroSphare.Models;

namespace AgroSphare.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<SoilData> SoilData { get; set; }
        public DbSet<WeatherLog> WeatherLogs { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<YieldPrediction> YieldPredictions { get; set; }

    }
}