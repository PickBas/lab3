using System.Collections.Generic;
using System.Linq;

namespace lab3.Place
{
    public class PlaceRepository : IRepository<Place>
    {
        private List<Place> _place;

        public List<Place> Place => _place;

        public PlaceRepository()
        {
            _place = new List<Place>();
        }
        
        public PlaceRepository(List<Place> place)
        {
            _place = place;
        }

        public void SortDataByPopulation()
        {
            _place = _place.OrderBy(o => o.Population).ToList();
        }

        public void SortDataBySquare()
        {
            _place = _place.OrderBy(o => o.Square).ToList();
        }

        public void AddObject(Place obj)
        {
            _place.Add(obj);
        }

        public void DeleteObject(int id)
        {
            _place.RemoveAt(id);
        }

        public List<Place> FilterDataByPopulation(int population)
        {
            return _place.Where(place => place.Population > population).ToList();
        }

        public List<Place> FilterDataBySquare(int square)
        {
            return _place.Where(place => place.Square > square).ToList();
        }
    }
}