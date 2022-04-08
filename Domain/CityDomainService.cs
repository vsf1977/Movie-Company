using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using System.Linq;

namespace PruebaPNG.Domain
{
    public class CityDomainService
    {
        private MovieDbContext _context;
        public CityDomainService(MovieDbContext MovieDbContext)
        {
            _context = MovieDbContext;
        }

        public ActionResult<dynamic> GetAll()
        {
            return _context.City.ToList();
        }

    }
}
