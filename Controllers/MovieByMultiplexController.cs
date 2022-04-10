using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieByMultiplexController : ControllerBase
    {
        #region Fields
        public MovieByMultiplexApplicationService _movieByMultiplexAppService;
        #endregion

        #region Constructor
        public MovieByMultiplexController(MovieByMultiplexApplicationService movieByMultiplexAppService)
        {
            _movieByMultiplexAppService = movieByMultiplexAppService;
        }
        #endregion

        /// <summary>
        /// Listado completo de peliculas por cine
        /// </summary>
        /// <returns></returns>

        #region Methods
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<dynamic> GetALL()
        {
            return _movieByMultiplexAppService.GetAll();
        }
        #endregion

    }
}
