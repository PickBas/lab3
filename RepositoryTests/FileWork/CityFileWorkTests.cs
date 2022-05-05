using System.Collections.Generic;
using System.IO;
using lab3.City;
using lab3.FileWork.CSV;
using lab3.FileWork.JSON;
using lab3.FileWork.Services;
using lab3.FileWork.XML;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryTests.FileWork
{

    [TestClass]
    public class CityFileWorkTests
    {
        private static readonly string _basePath = "../../FileWork/fixtures/";
        
        private CityRepository _repository;
        private CityEntity _moscow;
        private CityEntity _voronezh;
        private CityEntity _new_york;
        private CityEntity _la;

        [TestInitialize]
        public void SetUp()
        {
            List<CityEntity> cities = new List<CityEntity>();
            _moscow = new CityEntity("Moscow", 300, 14);
            _voronezh = new CityEntity("Voronezh", 100, 3);
            _new_york = new CityEntity("New York", 1000, 24);
            _la = new CityEntity("LA", 500, 20);
            cities.Add(_moscow);
            cities.Add(_voronezh);
            cities.Add(_new_york);
            cities.Add(_la);
            _repository = new CityRepository(cities);
        }
        
        [TestMethod]
        public void ToJsonTest()
        {
            string jsonFilePath = _basePath + "test_json_out.json";
            IReader<CityEntity> reader = new JsonReaderFile<CityEntity>();
            IWriter<CityEntity> writer = new JsonWriter<CityEntity>();
            writer.Write(jsonFilePath, _repository);
            List<CityEntity> entities = reader.GetData(jsonFilePath);
            Assert.AreEqual(_moscow.Name, entities[0].Name);
            Assert.AreEqual(_moscow.Population, entities[0].Population);
            Assert.AreEqual(_moscow.Square, entities[0].Square);
            Assert.AreEqual(_voronezh.Name, entities[1].Name);
            Assert.AreEqual(_voronezh.Population, entities[1].Population);
            Assert.AreEqual(_voronezh.Square, entities[1].Square);
            File.Delete(jsonFilePath);
        }

        [TestMethod]
        public void ToXmlTest()
        {
            string xmlFilePath = _basePath + "test_xml_out.xml";
            IReader<CityEntity> reader = new XMLReader<CityEntity>();
            IWriter<CityEntity> writer = new XMLWriter<CityEntity>();
            writer.Write(xmlFilePath, _repository);
            List<CityEntity> entities = reader.GetData(xmlFilePath);
            Assert.AreEqual(_moscow.Name, entities[0].Name);
            Assert.AreEqual(_moscow.Population, entities[0].Population);
            Assert.AreEqual(_moscow.Square, entities[0].Square);
            Assert.AreEqual(_voronezh.Name, entities[1].Name);
            Assert.AreEqual(_voronezh.Population, entities[1].Population);
            Assert.AreEqual(_voronezh.Square, entities[1].Square);
            File.Delete(xmlFilePath);
        }

        [TestMethod]
        public void ToCsvTest()
        {
            string csvFilePath = _basePath + "test_csv_out.csv";
            IWriter<CityEntity> writer = new CSVWriter<CityEntity>();
            writer.Write(csvFilePath, _repository);
            CityRepository repository = new CityRepository(csvFilePath, "csv");
            Assert.AreEqual(_moscow.Name, repository.Cities[0].Name);
            Assert.AreEqual(_moscow.Population, repository.Cities[0].Population);
            Assert.AreEqual(_moscow.Square, repository.Cities[0].Square);
            Assert.AreEqual(_voronezh.Name, repository.Cities[1].Name);
            Assert.AreEqual(_voronezh.Population, repository.Cities[1].Population);
            Assert.AreEqual(_voronezh.Square, repository.Cities[1].Square);
            File.Delete(csvFilePath);
        }
    }
}