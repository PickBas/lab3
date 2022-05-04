using System;
using System.Collections.Generic;
using lab3.City;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryTests.FileWork
{

    [TestClass]
    public class CityFileWorkTests
    {
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
            string json = _repository.ToJson();
            string csv = _repository.ToCsv();
            string xml = _repository.ToXml();
            Console.WriteLine(json);
            Console.WriteLine(csv);
            Console.WriteLine(xml);
            Assert.IsTrue(true);
        }

    }
}