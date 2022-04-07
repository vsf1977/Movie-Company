using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaPNG.Application;
using PruebaPNG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviecompanyController : ControllerBase
    {
        public CityAppService _cityAppService;

        public MoviecompanyController(CityAppService cityAppService)
        {
            _cityAppService = cityAppService;
        }


        [HttpGet]
        public IEnumerable<City> Get()
        {
            return _cityAppService.GetAll();
        }
    }
}
