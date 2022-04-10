using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using System.Linq;

namespace PruebaPNG.Domain
{
    public class GenreDomainService
    {
        #region Fields
        private MovieDbContext _context;
        #endregion


        #region Constructor
        public GenreDomainService(MovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }
        #endregion


        #region Methods
        public ActionResult<dynamic> GetAll()
        {
            return _context.Genre.ToList();
        }
        #endregion
    }
}
