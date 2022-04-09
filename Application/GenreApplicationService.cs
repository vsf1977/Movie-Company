using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class GenreApplicationService
    {
        private GenreDomainService _genreDomainService;

        public GenreApplicationService(GenreDomainService genreDomainService)
        {
            _genreDomainService = genreDomainService;
        }


        public ActionResult<dynamic> GetAll()
        {
            try
            {
                var res = _genreDomainService.GetAll();
                return res;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
