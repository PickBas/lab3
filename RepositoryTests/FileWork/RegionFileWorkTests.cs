using System.Collections.Generic;
using System.IO;
using lab3.FileWork.CSV;
using lab3.FileWork.JSON;
using lab3.FileWork.Services;
using lab3.FileWork.XML;
using lab3.Region;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryTests.FileWork
{
    [TestClass]
    public class RegionFileWorkTests
    {
        private static readonly string _basePath = "../../FileWork/fixtures/";
        
        private RegionRepository _repository;
        private Region _moscow;
        private Region _voronezh;
        private Region _new_york;
        private Region _la;

        [TestInitialize]
        public void SetUp()
        {
            List<Region> cities = new List<Region>();
            _moscow = new Region("Moscow", 300, 14);
            _voronezh = new Region("Voronezh", 100, 3);
            _new_york = new Region("New York", 1000, 24);
            _la = new Region("LA", 500, 20);
            cities.Add(_moscow);
            cities.Add(_voronezh);
            cities.Add(_new_york);
            cities.Add(_la);
            _repository = new RegionRepository(cities);
        }
        
        [TestMethod]
        public void ToJsonTest()
        {
            string jsonFilePath = _basePath + "test_json_out.json";
            IReader<Region> reader = new JsonReaderFile<Region>();
            IWriter<Region> writer = new JsonWriter<Region>();
            writer.Write(jsonFilePath, _repository);
            List<Region> entities = reader.GetData(jsonFilePath);
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
            IReader<Region> reader = new XMLReader<Region>();
            IWriter<Region> writer = new XMLWriter<Region>();
            writer.Write(xmlFilePath, _repository);
            List<Region> entities = reader.GetData(xmlFilePath);
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
            IWriter<Region> writer = new CSVWriter<Region>();
            writer.Write(csvFilePath, _repository);
            RegionRepository repository = new RegionRepository(csvFilePath, "csv");
            Assert.AreEqual(_moscow.Name, repository.Region[0].Name);
            Assert.AreEqual(_moscow.Population, repository.Region[0].Population);
            Assert.AreEqual(_moscow.Square, repository.Region[0].Square);
            Assert.AreEqual(_voronezh.Name, repository.Region[1].Name);
            Assert.AreEqual(_voronezh.Population, repository.Region[1].Population);
            Assert.AreEqual(_voronezh.Square, repository.Region[1].Square);
            File.Delete(csvFilePath);
        }
    }
}