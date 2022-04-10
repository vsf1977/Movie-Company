using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Models;
using System;
using System.Linq;

namespace PruebaPNG.Domain
{
    public class MovieDomainService
    {
        private MovieDbContext _context;
        public MovieDomainService(MovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }

        public ActionResult<dynamic> GetAll()
        {
            return _context.Movie.Where(x => x.State).ToList();
        }

    }
}
