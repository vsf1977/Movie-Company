using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class CityApplicationService
    {
        #region Fields
        private CityDomainService _cityDomainService;
        #endregion

        #region Constructor
        public CityApplicationService(CityDomainService cityDomainService)
        {
            _cityDomainService = cityDomainService;
        }
        #endregion


        #region Methods
        public ActionResult<dynamic> GetAll()
        {
            try
            {
                var res = _cityDomainService.GetAll();
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
