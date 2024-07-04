using AltaPiloto.Models;

namespace AltaPiloto.Repository.Interfaz
{
    public interface IPilotoRepository
    {
        public Piloto getById(int id);

        public Boolean Post(Piloto p);
        public Boolean Put(Piloto p);       
        public Boolean Delete(int id);

    }
}
