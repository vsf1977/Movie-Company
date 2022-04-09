using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Models;
using System;
using System.Linq;

namespace PruebaPNG.Domain
{
    public class MultiplexDomainService
    {
        private MovieDbContext _context;
        public MultiplexDomainService(MovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }

        public ActionResult<dynamic> GetAll()
        {
            return _context.Multiplex.ToList();
        }

    }
}
