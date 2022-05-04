using System;
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
        private City _moscow;
        private City _voronezh;
        private City _new_york;
        private City _la;

        [TestInitialize]
        public void SetUp()
        {
            List<City> cities = new List<City>();
            _moscow = new City("Moscow", 300, 14);
            _voronezh = new City("Voronezh", 100, 3);
            _new_york = new City("New York", 1000, 24);
            _la = new City("LA", 500, 20);
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
            IReader<City> reader = new JsonReaderFile<City>();
            IWriter<City> writer = new JsonWriter<City>();
            writer.Write(jsonFilePath, _repository);
            List<City> entities = reader.GetData(jsonFilePath);
            Assert.AreEqual(_moscow.Name, entities[0].Name);
            Assert.AreEqual(_moscow.Population, entities[0].Population);
            Assert.AreEqual(_moscow.Square, entities[0].Square);
            Assert.AreEqual(_voronezh.Name, entities[1].Name);
            Assert.AreEqual(_voronezh.Population, entities[1].Population);
            Assert.AreEqual(_voronezh.Square, entities[1].Square);

        }

        [TestMethod]
        public void ToXmlTest()
        {
            string xmlFilePath = _basePath + "test_xml_out.xml";
            IReader<City> reader = new XMLReader<City>();
            IWriter<City> writer = new XMLWriter<City>();
            writer.Write(xmlFilePath, _repository);
            List<City> entities = reader.GetData(xmlFilePath);
            Assert.AreEqual(_moscow.Name, entities[0].Name);
            Assert.AreEqual(_moscow.Population, entities[0].Population);
            Assert.AreEqual(_moscow.Square, entities[0].Square);
            Assert.AreEqual(_voronezh.Name, entities[1].Name);
            Assert.AreEqual(_voronezh.Population, entities[1].Population);
            Assert.AreEqual(_voronezh.Square, entities[1].Square);
        }

        [TestMethod]
        public void ToCsvTest()
        {
            string csvFilePath = _basePath + "test_csv_out.csv";
            IWriter<City> writer = new CSVWriter<City>();
            writer.Write(csvFilePath, _repository);
            CityRepository repository = new CityRepository(csvFilePath, "csv");
            Assert.AreEqual(_moscow.Name, repository.Cities[0].Name);
            Assert.AreEqual(_moscow.Population, repository.Cities[0].Population);
            Assert.AreEqual(_moscow.Square, repository.Cities[0].Square);
            Assert.AreEqual(_voronezh.Name, repository.Cities[1].Name);
            Assert.AreEqual(_voronezh.Population, repository.Cities[1].Population);
            Assert.AreEqual(_voronezh.Square, repository.Cities[1].Square);
        }
    }
}