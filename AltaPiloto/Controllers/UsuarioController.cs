using AltaPiloto.Dto;
using AltaPiloto.Models;
using AltaPiloto.Repository.Imp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaPiloto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly LoginRepository _loginRepository;
        public UsuarioController(LoginRepository _login)
        {
            _loginRepository = _login;
        }

        [HttpPost]
        public ActionResult validarUsuario([FromBody] DtoUsuario usuario)
        {
            if (usuario != null)
            {
                if (_loginRepository.Loggear(usuario))
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            else {
                return BadRequest();
            }
        }
    
    }
}
