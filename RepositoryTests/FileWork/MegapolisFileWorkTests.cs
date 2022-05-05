using System.Collections.Generic;
using System.IO;
using lab3.FileWork.CSV;
using lab3.FileWork.JSON;
using lab3.FileWork.Services;
using lab3.FileWork.XML;
using lab3.Megapolis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryTests.FileWork
{
    [TestClass]
    public class MegapolisFileWorkTests
    {
        private static readonly string _basePath = "../../FileWork/fixtures/";
        
        private MegapolisRepository _repository;
        private MegapolisEntity _moscow;
        private MegapolisEntity _voronezh;
        private MegapolisEntity _new_york;
        private MegapolisEntity _la;

        [TestInitialize]
        public void SetUp()
        {
            List<MegapolisEntity> cities = new List<MegapolisEntity>();
            _moscow = new MegapolisEntity("Moscow", 300, 14);
            _voronezh = new MegapolisEntity("Voronezh", 100, 3);
            _new_york = new MegapolisEntity("New York", 1000, 24);
            _la = new MegapolisEntity("LA", 500, 20);
            cities.Add(_moscow);
            cities.Add(_voronezh);
            cities.Add(_new_york);
            cities.Add(_la);
            _repository = new MegapolisRepository(cities);
        }
        
        [TestMethod]
        public void ToJsonTest()
        {
            string jsonFilePath = _basePath + "test_json_out.json";
            IReader<MegapolisEntity> reader = new JsonReaderFile<MegapolisEntity>();
            IWriter<MegapolisEntity> writer = new JsonWriter<MegapolisEntity>();
            writer.Write(jsonFilePath, _repository);
            List<MegapolisEntity> entities = reader.GetData(jsonFilePath);
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
            IReader<MegapolisEntity> reader = new XMLReader<MegapolisEntity>();
            IWriter<MegapolisEntity> writer = new XMLWriter<MegapolisEntity>();
            writer.Write(xmlFilePath, _repository);
            List<MegapolisEntity> entities = reader.GetData(xmlFilePath);
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
            IWriter<MegapolisEntity> writer = new CSVWriter<MegapolisEntity>();
            writer.Write(csvFilePath, _repository);
            MegapolisRepository repository = new MegapolisRepository(csvFilePath, "csv");
            Assert.AreEqual(_moscow.Name, repository.Megapolis[0].Name);
            Assert.AreEqual(_moscow.Population, repository.Megapolis[0].Population);
            Assert.AreEqual(_moscow.Square, repository.Megapolis[0].Square);
            Assert.AreEqual(_voronezh.Name, repository.Megapolis[1].Name);
            Assert.AreEqual(_voronezh.Population, repository.Megapolis[1].Population);
            Assert.AreEqual(_voronezh.Square, repository.Megapolis[1].Square);
            File.Delete(csvFilePath);
        }
    }
}