using AltaPiloto.Models;
using AltaPiloto.Repository.Imp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace AltaPiloto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NacionalidadController : ControllerBase
    {
        private readonly NacionalidadRepository _nacionalidadRepository;

        public NacionalidadController(NacionalidadRepository nacionalidadRepository)
        {
            _nacionalidadRepository = nacionalidadRepository;
        }

  


        [HttpGet]
        [Route("/GetAllNacionalities")]
        public ActionResult<Nacionalidad> GetAll()
        {
           var entities = _nacionalidadRepository.GetAll();
            if (entities.Any())
            {
                return Ok(entities);
            }
            else { 
            return BadRequest();    
            }

                
        }
    }
}
