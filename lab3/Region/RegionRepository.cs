using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using lab3.FileWork.JSON;
using lab3.FileWork.Services;
using lab3.FileWork.XML;
using Newtonsoft.Json;
using ServiceStack.Text;

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
        
        public RegionRepository(string filePath, string extension)
        {
            IReader<Region> reader;
            switch (extension)
            {
                case string a when a.Contains("json"):
                    reader = new JsonReaderFile<Region>();
                    _region = reader.GetData(filePath);
                    break;
                case string a when a.Contains("xml"):
                    reader = new XMLReader<Region>();
                    _region = reader.GetData(filePath);
                    break;
                case string a when a.Contains("csv"):
                    RepositoryFromCsv(filePath);
                    break;
            }
        }
        
        private void RepositoryFromCsv(string filePath)
        {
            var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ","
            };
            StreamReader reader = new StreamReader(filePath);
            _region = new List<Region>();
            using (var csvReader = new CsvHelper.CsvReader(reader, csvConfig))
            {
                csvReader.Read();
                while (csvReader.Read())
                {
                    csvReader.TryGetField<string>(0, out var currentName);
                    csvReader.TryGetField<string>(1, out var currentPopulationStr);
                    csvReader.TryGetField<string>(2, out var currentSquareStr);
                    var currentPopulation = int.Parse(currentPopulationStr);
                    var currentSquare = int.Parse(currentSquareStr);
                    _region.Add(new Region(currentName, currentPopulation, currentSquare));
                }
            }
            reader.Close();
        }

        public void SortDataByPopulation()
        {
            _region = _region.OrderBy(o => o.Population).ToList();
            Log.Info("RegionRepository: Sorted data by population");
        }

        public void SortDataByPopulationDescending()
        {
            _region = _region.OrderByDescending(o => o.Population).ToList();
            Log.Info("RegionRepository: Sorted data by population (descending)");
        }

        public void SortDataBySquare()
        {
            _region = _region.OrderBy(o => o.Square).ToList();
            Log.Info("RegionRepository: Sorted data by square");
        }

        public void SortDataBySquareDescending()
        {
            _region = _region.OrderByDescending(o => o.Square).ToList();
            Log.Info("RegionRepository: Sorted data by square (descending)");
        }

        public void AddObject(Region obj)
        {
            _region.Add(obj);
            Log.Info("RegionRepository: Added city with ");
        }

        public void AddObject(string name, int population, int square)
        {
            _region.Add(new Region(name, population, square));
        }

        public void DeleteObject(int id)
        {
            Log.Info("RegionRepository: Removed city with " + _region[id]);
            _region.RemoveAt(id);
        }

        public List<Region> FilterDataByPopulation(int population)
        {
            Log.Info("RegionRepository: Filtered data by population >= " + population);
            return _region.Where(region => region.Population >= population).ToList();
        }

        public List<Region> FilterDataBySquare(int square)
        {
            Log.Info("RegionRepository: Filtered data by square >= " + square);
            return _region.Where(region => region.Square >= square).ToList();
        }

        public List<Region> GetData()
        {
            return Region;
        }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(_region);
        }

        public string ToCsv()
        {
            return CsvSerializer.SerializeToCsv(_region);
        }

        public string ToXml()
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System
                .Xml.Serialization.XmlSerializer(_region.GetType());
            using(StringWriter textWriter = new Utf8StringWriter())
            {
                xmlSerializer.Serialize(textWriter, _region);
                return textWriter.ToString();
            }
        }
    }
}