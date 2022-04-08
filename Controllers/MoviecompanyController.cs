using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviecompanyController : ControllerBase
    {
        public CityApplicationService _cityAppService;

        public MoviecompanyController(CityApplicationService cityAppService)
        {
            _cityAppService = cityAppService;
        }


        [HttpGet]
        public ActionResult<dynamic> GetALL()
        {
            return _cityAppService.GetAll();
        }
    }
}
