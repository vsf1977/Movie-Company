using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        #region Fields
        public MovieApplicationService _movieAppService;
        #endregion 


        #region Constructor
        public MovieController(MovieApplicationService movieAppService)
        {
            _movieAppService = movieAppService;
        }
        #endregion 

        /// <summary>
        /// Listado completo de peliculas
        /// </summary>
        /// <returns></returns>

        #region Methods
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<dynamic> GetALL()
        {
            return _movieAppService.GetAll();
        }
        #endregion 

    }
}
