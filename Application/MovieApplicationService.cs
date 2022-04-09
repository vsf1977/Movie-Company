using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class MovieApplicationService
    {
        private MovieDomainService _movieDomainService;

        public MovieApplicationService(MovieDomainService movieDomainService)
        {
            _movieDomainService = movieDomainService;
        }


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

    }
}
