using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using System.Linq;

namespace PruebaPNG.Domain
{
    public class MovieDomainService
    {
        #region Fields
        private MovieDbContext _context;
        #endregion


        #region Constructor
        public MovieDomainService(MovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }
        #endregion


        #region Methods
        public ActionResult<dynamic> GetAll()
        {
            return _context.Movie.Where(x => x.State).ToList();
        }
        #endregion

    }
}
