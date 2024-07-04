using AltaPiloto.Models;
using AltaPiloto.Repository.Interfaz;

namespace AltaPiloto.Repository.Imp
{
    public class PilotoRepository : IPilotoRepository
    {
        private readonly PilotoContext _context;

        public PilotoRepository(PilotoContext context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {
            var entity = _context.pilotos.FirstOrDefault(x=>x.id_Piloto==id);
            if (entity != null) {
                _context.Remove(entity);
                if (_context.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
                return false;     
        }

        public Piloto getById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(Piloto p)
        {
            throw new NotImplementedException();
        }

        public bool Put(Piloto p)
        {
            throw new NotImplementedException();
        }
    }
}
