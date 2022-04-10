using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using System.Linq;

namespace PruebaPNG.Domain
{
    public class MultiplexDomainService
    {
        #region Fields
        private MovieDbContext _context;
        #endregion

        #region Constructor
        public MultiplexDomainService(MovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }
        #endregion

        #region Methods
        public ActionResult<dynamic> GetAll()
        {
            return _context.Multiplex.Where(x => x.State).ToList();
        }
        #endregion

    }
}
