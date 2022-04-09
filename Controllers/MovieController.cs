using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public MovieApplicationService _movieAppService;

        public MovieController(MovieApplicationService movieAppService)
        {
            _movieAppService = movieAppService;
        }


        /// <summary>
        /// Listado completo de peliculas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<dynamic> GetALL()
        {
            return _movieAppService.GetAll();
        }
    }
}
