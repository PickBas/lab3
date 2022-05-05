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
        private Megapolis _moscow;
        private Megapolis _voronezh;
        private Megapolis _new_york;
        private Megapolis _la;

        [TestInitialize]
        public void SetUp()
        {
            List<Megapolis> cities = new List<Megapolis>();
            _moscow = new Megapolis("Moscow", 300, 14);
            _voronezh = new Megapolis("Voronezh", 100, 3);
            _new_york = new Megapolis("New York", 1000, 24);
            _la = new Megapolis("LA", 500, 20);
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
            IReader<Megapolis> reader = new JsonReaderFile<Megapolis>();
            IWriter<Megapolis> writer = new JsonWriter<Megapolis>();
            writer.Write(jsonFilePath, _repository);
            List<Megapolis> entities = reader.GetData(jsonFilePath);
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
            IReader<Megapolis> reader = new XMLReader<Megapolis>();
            IWriter<Megapolis> writer = new XMLWriter<Megapolis>();
            writer.Write(xmlFilePath, _repository);
            List<Megapolis> entities = reader.GetData(xmlFilePath);
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
            IWriter<Megapolis> writer = new CSVWriter<Megapolis>();
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