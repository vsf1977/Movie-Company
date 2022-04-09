using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Models;
using System;
using System.Linq;

namespace PruebaPNG.Domain
{
    public class GenreDomainService
    {
        private MovieDbContext _context;
        public GenreDomainService(MovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }

        public ActionResult<dynamic> GetAll()
        {
            return _context.Genre.ToList();
        }

    }
}
