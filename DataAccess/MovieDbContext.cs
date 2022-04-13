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
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }
        #endregion

    }
}
