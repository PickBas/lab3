using System.Collections.Generic;
using System.Linq;

namespace lab3.Region
{
    public class RegionRepository : IRepository<Region>
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
        
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
            Log.Info("CityRepository: Sorted data by population");
        }

        public void SortDataByPopulationDescending()
        {
            _region = _region.OrderByDescending(o => o.Population).ToList();
            Log.Info("CityRepository: Sorted data by population (descending)");
        }

        public void SortDataBySquare()
        {
            _region = _region.OrderBy(o => o.Square).ToList();
            Log.Info("CityRepository: Sorted data by square");
        }

        public void SortDataBySquareDescending()
        {
            _region = _region.OrderByDescending(o => o.Square).ToList();
            Log.Info("CityRepository: Sorted data by square (descending)");
        }

        public void AddObject(Region obj)
        {
            _region.Add(obj);
            Log.Info("CityRepository: Added city with ");
        }

        public void DeleteObject(int id)
        {
            Log.Info("CityRepository: Removed city with " + _region[id]);
            _region.RemoveAt(id);
        }

        public List<Region> FilterDataByPopulation(int population)
        {
            Log.Info("CityRepository: Filtered data by population >= " + population);
            return _region.Where(region => region.Population >= population).ToList();
        }

        public List<Region> FilterDataBySquare(int square)
        {
            Log.Info("CityRepository: Filtered data by square >= " + square);
            return _region.Where(region => region.Square >= square).ToList();
        }
    }
}