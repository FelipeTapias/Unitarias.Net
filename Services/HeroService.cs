using ASPTEst.Models;

namespace ASPTEst.Services
{
    public class HeroService: IHeroeService
    {

        private List<Heroe> _heroes = new List<Heroe>()
        {
            new Heroe(){ Id = 1, Name = "Superman", Power = "Fly" },
            new Heroe(){ Id = 2, Name = "Batman", Power = "Smart" } 
        };

        public IEnumerable<Heroe> Get() => _heroes;

        public Heroe? Get(int id) => _heroes.FirstOrDefault(heroe => heroe.Id == id);
    }
}
