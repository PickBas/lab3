using System.Collections.Generic;
using System.Linq;

namespace lab3.Megalopolis
{
    public class MegapolisRepository : IRepository<Megapolis>
    {
        private List<Megapolis> _megapolis;

        public List<Megapolis> Megapolis => _megapolis;

        public MegapolisRepository()
        {
            _megapolis = new List<Megapolis>();
        }
        
        public MegapolisRepository(List<Megapolis> megapolis)
        {
            _megapolis = megapolis;
        }

        public void SortDataByPopulation()
        {
            _megapolis = _megapolis.OrderBy(o => o.Population).ToList();
        }

        public void SortDataBySquare()
        {
            _megapolis = _megapolis.OrderBy(o => o.Square).ToList();
        }

        public void AddObject(Megapolis obj)
        {
            _megapolis.Add(obj);
        }

        public void DeleteObject(int id)
        {
            _megapolis.RemoveAt(id);
        }

        public List<Megapolis> FilterDataByPopulation(int population)
        {
            return _megapolis.Where(megapolis => megapolis.Population > population).ToList();
        }

        public List<Megapolis> FilterDataBySquare(int square)
        {
            return _megapolis.Where(megapolis => megapolis.Square > square).ToList();
        }
    }
}