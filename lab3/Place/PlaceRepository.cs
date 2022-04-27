using System.Collections.Generic;
using System.Linq;

namespace lab3.Place
{
    public class PlaceRepository : IRepository<Place>
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
        
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
            Log.Info("PlaceRepository: Sorted data by population");
        }

        public void SortDataByPopulationDescending()
        {
            _place = _place.OrderByDescending(o => o.Population).ToList();
            Log.Info("PlaceRepository: Sorted data by population (descending)");
        }

        public void SortDataBySquare()
        {
            _place = _place.OrderBy(o => o.Square).ToList();
            Log.Info("PlaceRepository: Sorted data by square");
        }

        public void SortDataBySquareDescending()
        {
            _place = _place.OrderByDescending(o => o.Square).ToList();
            Log.Info("PlaceRepository: Sorted data by square (descending)");
        }

        public void AddObject(Place obj)
        {
            _place.Add(obj);
            Log.Info("PlaceRepository: Added place with " + obj);
        }

        public void DeleteObject(int id)
        {
            Log.Info("PlaceRepository: Removed place with " + _place[id]);
            _place.RemoveAt(id);
        }

        public List<Place> FilterDataByPopulation(int population)
        {
            Log.Info("PlaceRepository: Filtered data by population >= " + population);
            return _place.Where(place => place.Population >= population).ToList();
        }

        public List<Place> FilterDataBySquare(int square)
        {
            Log.Info("PlaceRepository: Filtered data by square >= " + square);
            return _place.Where(place => place.Square >= square).ToList();
        }
    }
}