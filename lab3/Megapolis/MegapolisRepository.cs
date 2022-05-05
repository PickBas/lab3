using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using lab3.FileWork.JSON;
using lab3.FileWork.Services;
using lab3.FileWork.XML;
using Newtonsoft.Json;
using ServiceStack.Text;

namespace lab3.Megapolis
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
        
        public MegapolisRepository(string filePath, string extension)
        {
            IReader<Megapolis> reader;
            switch (extension)
            {
                case string a when a.Contains("json"):
                    reader = new JsonReaderFile<Megapolis>();
                    _megapolis = reader.GetData(filePath);
                    break;
                case string a when a.Contains("xml"):
                    reader = new XMLReader<Megapolis>();
                    _megapolis = reader.GetData(filePath);
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
            _megapolis = new List<Megapolis>();
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
                    _megapolis.Add(new Megapolis(currentName, currentPopulation, currentSquare));
                }
            }
            reader.Close();
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

        public void AddObject(string name, int population, int square)
        {
            _megapolis.Add(new Megapolis(name, population, square));
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

        public List<Megapolis> GetData()
        {
            return Megapolis;
        }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(_megapolis);
        }

        public string ToCsv()
        {
            return CsvSerializer.SerializeToCsv(_megapolis);
        }

        public string ToXml()
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System
                .Xml.Serialization.XmlSerializer(_megapolis.GetType());
            using(StringWriter textWriter = new Utf8StringWriter())
            {
                xmlSerializer.Serialize(textWriter, _megapolis);
                return textWriter.ToString();
            }
        }
    }
}