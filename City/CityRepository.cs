using System.Collections.Generic;
using System.Linq;

namespace lab3.City
{
    public class CityRepository : IRepository<City>
    {
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
        }
        public void SortDataByPopulationDescending()
        {
            _city = _city.OrderByDescending(o => o.Population).ToList();
        }

        public void SortDataBySquare()
        {
            _city = _city.OrderBy(o => o.Square).ToList();
        }
        
        public void SortDataBySquareDescending()
        {
            _city = _city.OrderByDescending(o => o.Square).ToList();
        }

        public void AddObject(City obj)
        {
            _city.Add(obj);
        }

        public void DeleteObject(int id)
        {
            _city.RemoveAt(id);
        }

        public List<City> FilterDataByPopulation(int population)
        {
            return _city.Where(city => city.Population > population).ToList();
        }

        public List<City> FilterDataBySquare(int square)
        {
            return _city.Where(city => city.Square > square).ToList();
        }
    }
}