using AltaPiloto.Models;

namespace AltaPiloto.Repository.Imp
{
    public class NacionalidadRepository
    {

        private readonly PilotoContext _context;


        public NacionalidadRepository(PilotoContext c)
        {
            _context = c;
        }

        public List<Nacionalidad> GetAll()
        {
           var entities = _context.nacionalidades.ToList();

            if (entities.Any())
            {
                return entities;
            }
            else
            {
                return null;
            }

        }
    }
}
