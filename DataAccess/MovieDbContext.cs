using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaPNG.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

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
            options.UseSqlServer(Configuration.GetValue<string>("ConnectionString"));
        }

        public DbSet<City> City { get; set; }
    }
}
