using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class MovieApplicationService
    {
        #region Fields
        private MovieDomainService _movieDomainService;
        #endregion

        #region Constructor
        public MovieApplicationService(MovieDomainService movieDomainService)
        {
            _movieDomainService = movieDomainService;
        }
        #endregion

        #region Methods
        public ActionResult<dynamic> GetAll()
        {
            try
            {
                var res = _movieDomainService.GetAll();
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
