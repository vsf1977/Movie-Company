using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class GenreApplicationService
    {
        #region Fields
        private GenreDomainService _genreDomainService;
        #endregion 

        #region Constructor
        public GenreApplicationService(GenreDomainService genreDomainService)
        {
            _genreDomainService = genreDomainService;
        }
        #endregion 


        #region Methods
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
        #endregion

    }
}
