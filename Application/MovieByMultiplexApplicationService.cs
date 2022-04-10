using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class MovieByMultiplexApplicationService
    {
        private MovieByMultiplexDomainService _movieByMultiplexDomainService;

        public MovieByMultiplexApplicationService(MovieByMultiplexDomainService movieByMultiplexDomainService)
        {
            _movieByMultiplexDomainService = movieByMultiplexDomainService;
        }


        public ActionResult<dynamic> GetAll()
        {
            try
            {
                var res = _movieByMultiplexDomainService.GetAll();
                return res;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
