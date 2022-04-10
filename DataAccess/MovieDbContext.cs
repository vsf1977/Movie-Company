using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaPNG.Models;

namespace PruebaPNG.DataAccess
{
    public class MovieDbContext : DbContext
    {
        #region Fields
        protected readonly IConfiguration Configuration;
        public DbSet<City> City { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Multiplex> Multiplex { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieByMultiplex> MovieByMultiplex { get; set; }
        #endregion

        #region Constructor
        public MovieDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            options.UseNpgsql(Configuration.GetValue<string>("ConnectionString"));
        }     
        #endregion
    }
}
