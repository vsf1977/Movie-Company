using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        #region Fields
        public CityApplicationService _cityAppService;
        #endregion

        #region Constructor
        public CityController(CityApplicationService cityAppService)
        {
            _cityAppService = cityAppService;
        }
        #endregion

        /// <summary>
        /// Listado completo de ciudades
        /// </summary>
        /// <returns></returns>
        #region Methods
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<dynamic> GetALL()
        {
            return _cityAppService.GetAll();
        }
        #endregion

    }
}
