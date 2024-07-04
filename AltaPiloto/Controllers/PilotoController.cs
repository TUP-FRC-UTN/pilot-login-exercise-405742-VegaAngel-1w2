using AltaPiloto.Repository.Imp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaPiloto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotoController : ControllerBase
    {
        private readonly PilotoRepository _poitoRepository;

        public PilotoController(PilotoRepository poitoRepository)
        {
            _poitoRepository = poitoRepository;
        }

        [HttpGet]
        [Route("/GetById{id}")]
        public ActionResult Get() {




            return null;
        
        }

    }
}
