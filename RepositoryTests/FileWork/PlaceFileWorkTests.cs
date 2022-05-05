using System.Collections.Generic;
using System.IO;
using lab3.FileWork.CSV;
using lab3.FileWork.JSON;
using lab3.FileWork.Services;
using lab3.FileWork.XML;
using lab3.Place;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryTests.FileWork
{
    [TestClass]
    public class PlaceFileWorkTests
    {
        private static readonly string _basePath = "../../FileWork/fixtures/";
        
        private PlaceRepository _repository;
        private Place _moscow;
        private Place _voronezh;
        private Place _new_york;
        private Place _la;

        [TestInitialize]
        public void SetUp()
        {
            List<Place> cities = new List<Place>();
            _moscow = new Place("Moscow", 300, 14);
            _voronezh = new Place("Voronezh", 100, 3);
            _new_york = new Place("New York", 1000, 24);
            _la = new Place("LA", 500, 20);
            cities.Add(_moscow);
            cities.Add(_voronezh);
            cities.Add(_new_york);
            cities.Add(_la);
            _repository = new PlaceRepository(cities);
        }
        
        [TestMethod]
        public void ToJsonTest()
        {
            string jsonFilePath = _basePath + "test_json_out.json";
            IReader<Place> reader = new JsonReaderFile<Place>();
            IWriter<Place> writer = new JsonWriter<Place>();
            writer.Write(jsonFilePath, _repository);
            List<Place> entities = reader.GetData(jsonFilePath);
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
            IReader<Place> reader = new XMLReader<Place>();
            IWriter<Place> writer = new XMLWriter<Place>();
            writer.Write(xmlFilePath, _repository);
            List<Place> entities = reader.GetData(xmlFilePath);
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
            IWriter<Place> writer = new CSVWriter<Place>();
            writer.Write(csvFilePath, _repository);
            PlaceRepository repository = new PlaceRepository(csvFilePath, "csv");
            Assert.AreEqual(_moscow.Name, repository.Place[0].Name);
            Assert.AreEqual(_moscow.Population, repository.Place[0].Population);
            Assert.AreEqual(_moscow.Square, repository.Place[0].Square);
            Assert.AreEqual(_voronezh.Name, repository.Place[1].Name);
            Assert.AreEqual(_voronezh.Population, repository.Place[1].Population);
            Assert.AreEqual(_voronezh.Square, repository.Place[1].Square);
            File.Delete(csvFilePath);
        }
    }
}