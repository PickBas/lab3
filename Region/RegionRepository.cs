using System.Collections.Generic;
using System.Linq;

namespace lab3.Region
{
    public class RegionRepository : IRepository<Region>
    {
        private List<Region> _region;

        public List<Region> Region => _region;

        public RegionRepository()
        {
            _region = new List<Region>();
        }
        
        public RegionRepository(List<Region> region)
        {
            _region = region;
        }

        public void SortDataByPopulation()
        {
            _region = _region.OrderBy(o => o.Population).ToList();
        }

        public void SortDataBySquare()
        {
            _region = _region.OrderBy(o => o.Square).ToList();
        }

        public void AddObject(Region obj)
        {
            _region.Add(obj);
        }

        public void DeleteObject(int id)
        {
            _region.RemoveAt(id);
        }

        public List<Region> FilterDataByPopulation(int population)
        {
            return _region.Where(region => region.Population > population).ToList();
        }

        public List<Region> FilterDataBySquare(int square)
        {
            return _region.Where(region => region.Square > square).ToList();
        }
    }
}