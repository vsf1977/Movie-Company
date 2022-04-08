using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaPNG.Models;

namespace PruebaPNG.DataAccess
{
    public class MovieDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MovieDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            options.UseNpgsql(Configuration.GetValue<string>("ConnectionString"));
        }

        public DbSet<City> City { get; set; }
    }
}
