using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class MultiplexApplicationService
    {
        private MultiplexDomainService _multiplexDomainService;

        public MultiplexApplicationService(MultiplexDomainService multiplexDomainService)
        {
            _multiplexDomainService = multiplexDomainService;
        }


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

    }
}
