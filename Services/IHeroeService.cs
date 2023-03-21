using ASPTEst.Models;

namespace ASPTEst.Services
{
    public interface IHeroeService
    {
        public IEnumerable<Heroe> Get();
        public Heroe? Get(int id);
    }
}
