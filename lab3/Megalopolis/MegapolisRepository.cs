using System.Collections.Generic;
using System.Linq;

namespace lab3.Megalopolis
{
    public class MegapolisRepository : IRepository<Megapolis>
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
        
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
            Log.Info("MegapolisRepository: Sorted data by population");
        }

        public void SortDataByPopulationDescending()
        {
            _megapolis = _megapolis.OrderByDescending(o => o.Population).ToList();
            Log.Info("MegapolisRepository: Sorted data by population (descending)");
        }

        public void SortDataBySquare()
        {
            _megapolis = _megapolis.OrderBy(o => o.Square).ToList();
            Log.Info("MegapolisRepository: Sorted data by square");
        }

        public void SortDataBySquareDescending()
        {
            _megapolis = _megapolis.OrderByDescending(o => o.Square).ToList();
            Log.Info("MegapolisRepository: Sorted data by square (descending)");
        }

        public void AddObject(Megapolis obj)
        {
            _megapolis.Add(obj);
            Log.Info("MegapolisRepository: Added megapolis with " + obj);
        }

        public void DeleteObject(int id)
        {
            Log.Info("MegapolisRepository: Removed megapolis with " + _megapolis[id]);
            _megapolis.RemoveAt(id);
        }

        public List<Megapolis> FilterDataByPopulation(int population)
        {
            Log.Info("MegapolisRepository: Filtered data by population >= " + population);
            return _megapolis.Where(megapolis => megapolis.Population >= population).ToList();
        }

        public List<Megapolis> FilterDataBySquare(int square)
        {
            Log.Info("MegapolisRepository: Filtered data by square >= " + square);
            return _megapolis.Where(megapolis => megapolis.Square >= square).ToList();
        }
    }
}