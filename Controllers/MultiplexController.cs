using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiplexController : ControllerBase
    {
        public MultiplexApplicationService _multiplexAppService;

        public MultiplexController(MultiplexApplicationService multiplexAppService)
        {
            _multiplexAppService = multiplexAppService;
        }


        /// <summary>
        /// Listado completo de multicines
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<dynamic> GetALL()
        {
            return _multiplexAppService.GetAll();
        }
    }
}
