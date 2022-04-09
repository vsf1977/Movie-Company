using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        public CityApplicationService _cityAppService;

        public CityController(CityApplicationService cityAppService)
        {
            _cityAppService = cityAppService;
        }


        /// <summary>
        /// Listado completo de ciudades
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<dynamic> GetALL()
        {
            return _cityAppService.GetAll();
        }
    }
}
