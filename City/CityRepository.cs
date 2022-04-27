using System.Collections.Generic;
using System.Linq;

namespace lab3.City
{
    public class CityRepository : IRepository<City>
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
        
        private List<City> _city;

        public List<City> City => _city;

        public CityRepository()
        {
            _city = new List<City>();
        }
        
        public CityRepository(List<City> city)
        {
            _city = city;
        }

        public void SortDataByPopulation()
        {
            _city = _city.OrderBy(o => o.Population).ToList();
            Log.Info("CityRepository: Sorted data by population");
        }
        public void SortDataByPopulationDescending()
        {
            _city = _city.OrderByDescending(o => o.Population).ToList();
            Log.Info("CityRepository: Sorted data by population (descending)");
        }

        public void SortDataBySquare()
        {
            _city = _city.OrderBy(o => o.Square).ToList();
            Log.Info("CityRepository: Sorted data by square");
        }
        
        public void SortDataBySquareDescending()
        {
            _city = _city.OrderByDescending(o => o.Square).ToList();
            Log.Info("CityRepository: Sorted data by square (descending)");
        }

        public void AddObject(City obj)
        {
            _city.Add(obj);
            Log.Info("CityRepository: Added city with " + obj + ".");
        }

        public void DeleteObject(int id)
        {
            Log.Info("CityRepository: Removed city with " + _city[id] + ".");
            _city.RemoveAt(id);
        }

        public List<City> FilterDataByPopulation(int population)
        {
            Log.Info("CityRepository: Filtered data by population >= " + population);
            return _city.Where(city => city.Population >= population).ToList();
        }

        public List<City> FilterDataBySquare(int square)
        {
            Log.Info("CityRepository: Filtered data by population >= " + square);
            return _city.Where(city => city.Square >= square).ToList();
        }
    }
}