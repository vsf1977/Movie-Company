using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class CityApplicationService
    {
        private CityDomainService _cityDomainService;
        private MovieDbContext _context;

        public CityApplicationService(CityDomainService cityDomainService, MovieDbContext MovieDbContext)
        {
            _cityDomainService = cityDomainService;
            _context = MovieDbContext;
        }


        public ActionResult<dynamic> GetAll()
        {
            try
            {
                var res = _cityDomainService.GetAll();
                return res;

            }
            catch (Exception ex)
            {
                _context.Database.RollbackTransaction();
                return ex.Message;
            }
        }

    }
}
