using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : ControllerBase
    {
        #region Fields
        public GenreApplicationService _genreAppService;
        #endregion

        #region Constructor
        public GenreController(GenreApplicationService genreAppService)
        {
            _genreAppService = genreAppService;
        }
        #endregion


        /// <summary>
        /// Listado completo de generos
        /// </summary>
        /// <returns></returns>
        #region Methods
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<dynamic> GetALL()
        {
            return _genreAppService.GetAll();
        }
        #endregion

    }
}
