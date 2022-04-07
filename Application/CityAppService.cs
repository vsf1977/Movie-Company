using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaPNG.Application
{
    public class CityAppService
    {
        private MovieDbContext _context;


        public CityAppService(MovieDbContext MovieDbContext)
        {
            _context = MovieDbContext;
        }


        public IEnumerable<City> GetAll()
        {
            return _context.City.ToList();
        }

    }
}
