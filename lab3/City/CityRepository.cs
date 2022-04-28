using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using lab3.FileWork.JSON;
using lab3.FileWork.Services;
using lab3.FileWork.XML;
using Newtonsoft.Json;
using ServiceStack.Text;

namespace lab3.City
{
    public class CityRepository : IRepository<City>
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
        
        private List<City> _cities;

        public List<City> Cities => _cities;

        public CityRepository()
        {
            _cities = new List<City>();
        }

        public CityRepository(List<City> cities)
        {
            _cities = cities;
        }
        
        public CityRepository(string filePath, string extension)
        {
            IReader<City> reader;
            switch (extension)
            {
                case string a when a.Contains("json"):
                    reader = new JsonReaderFile<City>();
                    _cities = reader.GetData(filePath);
                    break;
                case string a when a.Contains("xml"):
                    reader = new XMLReader<City>();
                    _cities = reader.GetData(filePath);
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
            _cities = new List<City>();
            using (var csvReader = new CsvHelper.CsvReader(reader, csvConfig))
            {
                csvReader.Read();
                while (csvReader.Read())
                {
                    csvReader.TryGetField<string>(0, out var currentName);
                    csvReader.TryGetField<string>(1, out var currentPopulationStr);
                    csvReader.TryGetField<string>(1, out var currentSquareStr);
                    var currentPopulation = int.Parse(currentPopulationStr);
                    var currentSquare = int.Parse(currentSquareStr);
                    _cities.Add(new City(currentName, currentPopulation, currentSquare));
                }
            }
            reader.Close();
        }

        public void SortDataByPopulation()
        {
            _cities = _cities.OrderBy(o => o.Population).ToList();
            Log.Info("CityRepository: Sorted data by population");
        }
        public void SortDataByPopulationDescending()
        {
            _cities = _cities.OrderByDescending(o => o.Population).ToList();
            Log.Info("CityRepository: Sorted data by population (descending)");
        }

        public void SortDataBySquare()
        {
            _cities = _cities.OrderBy(o => o.Square).ToList();
            Log.Info("CityRepository: Sorted data by square");
        }
        
        public void SortDataBySquareDescending()
        {
            _cities = _cities.OrderByDescending(o => o.Square).ToList();
            Log.Info("CityRepository: Sorted data by square (descending)");
        }

        public void AddObject(City obj)
        {
            _cities.Add(obj);
            Log.Info("CityRepository: Added city with " + obj);
        }

        public void DeleteObject(int id)
        {
            Log.Info("CityRepository: Removed city with " + _cities[id]);
            _cities.RemoveAt(id);
        }

        public List<City> FilterDataByPopulation(int population)
        {
            Log.Info("CityRepository: Filtered data by population >= " + population);
            return _cities.Where(city => city.Population >= population).ToList();
        }

        public List<City> FilterDataBySquare(int square)
        {
            Log.Info("CityRepository: Filtered data by square >= " + square);
            return _cities.Where(city => city.Square >= square).ToList();
        }

        public List<City> GetData()
        {
            return Cities;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(_cities);
        }

        public string ToCsv()
        {
            return CsvSerializer.SerializeToCsv(_cities);
        }

        public string ToXml()
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System
                .Xml.Serialization.XmlSerializer(_cities.GetType());
            using(StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, _cities);
                return textWriter.ToString();
            }
        }
    }
}