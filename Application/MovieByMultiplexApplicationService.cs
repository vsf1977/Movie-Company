using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class MovieByMultiplexApplicationService
    {
        #region Fields
        private MovieByMultiplexDomainService _movieByMultiplexDomainService;
        #endregion

        #region Constructor
        public MovieByMultiplexApplicationService(MovieByMultiplexDomainService movieByMultiplexDomainService)
        {
            _movieByMultiplexDomainService = movieByMultiplexDomainService;
        }
        #endregion

        #region Methods
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
        #endregion

    }
}
