using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieByMultiplexController : ControllerBase
    {
        public MovieByMultiplexApplicationService _movieByMultiplexAppService;

        public MovieByMultiplexController(MovieByMultiplexApplicationService movieByMultiplexAppService)
        {
            _movieByMultiplexAppService = movieByMultiplexAppService;
        }


        /// <summary>
        /// Listado completo de peliculas por cine
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<dynamic> GetALL()
        {
            return _movieByMultiplexAppService.GetAll();
        }
    }
}
