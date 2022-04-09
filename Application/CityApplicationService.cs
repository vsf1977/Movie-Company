﻿using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Domain;
using System;

namespace PruebaPNG.Application
{
    public class CityApplicationService
    {
        private CityDomainService _cityDomainService;

        public CityApplicationService(CityDomainService cityDomainService)
        {
            _cityDomainService = cityDomainService;
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
                return ex.Message;
            }
        }

    }
}
