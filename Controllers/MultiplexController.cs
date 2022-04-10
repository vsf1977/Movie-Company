using Microsoft.AspNetCore.Mvc;
using PruebaPNG.Application;

namespace PruebaPNG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiplexController : ControllerBase
    {
        #region Fields
        public MultiplexApplicationService _multiplexAppService;
        #endregion 

        #region Constructor
        public MultiplexController(MultiplexApplicationService multiplexAppService)
        {
            _multiplexAppService = multiplexAppService;
        }
        #endregion 

        /// <summary>
        /// Listado completo de multicines
        /// </summary>
        /// <returns></returns>
        #region Methods
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<dynamic> GetALL()
        {
            return _multiplexAppService.GetAll();
        }
        #endregion 
    }
}
