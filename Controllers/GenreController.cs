using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : ControllerBase
    {
        public GenreApplicationService _genreAppService;

        public GenreController(GenreApplicationService genreAppService)
        {
            _genreAppService = genreAppService;
        }



        /// <summary>
        /// Listado completo de generos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<dynamic> GetALL()
        {
            return _genreAppService.GetAll();
        }
    }
}
