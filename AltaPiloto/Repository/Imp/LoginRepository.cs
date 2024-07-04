using AltaPiloto.Dto;
using AltaPiloto.Models;

namespace AltaPiloto.Repository.Imp
{
    public class LoginRepository
    {

        private readonly PilotoContext _context;


        public LoginRepository(PilotoContext c)
        {
            _context = c;
        }

        public Boolean Loggear(DtoUsuario user)
        {
            if (user == null)
            {
                return false;
            }
            else
            {

                var entity = _context.usuarios.FirstOrDefault(x => x.contraseña == user.contraseña && x.email == user.email);

                if (entity != null)
                {
                    return true;
                }
                else {
                    return false;

                }
            }
        }
    } 
}
