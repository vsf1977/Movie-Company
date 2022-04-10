using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class MultiplexApplicationService
    {
        #region Fields
        private MultiplexDomainService _multiplexDomainService;
        #endregion 


        #region Constructor
        public MultiplexApplicationService(MultiplexDomainService multiplexDomainService)
        {
            _multiplexDomainService = multiplexDomainService;
        }
        #endregion 


        #region Methods
        public ActionResult<dynamic> GetAll()
        {
            try
            {
                var res = _multiplexDomainService.GetAll();
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
