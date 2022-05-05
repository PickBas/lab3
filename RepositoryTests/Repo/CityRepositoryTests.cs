using System.Collections.Generic;
using lab3.City;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryTests
{
    [TestClass]
    public class CityRepositoryTests
    {
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
        public void SortingByPopulationTest()
        {
            _repository.SortDataByPopulation();
            Assert.AreEqual(_voronezh, _repository.Cities[0]);
        }
        
        [TestMethod]
        public void SortingByPopulationDescendingTest()
        {
            _repository.SortDataByPopulationDescending();
            Assert.AreEqual(_new_york, _repository.Cities[0]);
        }
        
        [TestMethod]
        public void SortingBySquareTest()
        {
            _repository.SortDataBySquare();
            Assert.AreEqual(_voronezh, _repository.Cities[0]);
        }
        
        [TestMethod]
        public void SortingBySquareDescendingTest()
        {
            _repository.SortDataBySquareDescending();
            Assert.AreEqual(_new_york, _repository.Cities[0]);
        }

        [TestMethod]
        public void AddObjectTest()
        {
            CityEntity dubai = new CityEntity("Dubai", 70000, 500);
            _repository.AddObject(dubai);
            Assert.IsTrue(_repository.Cities.Contains(dubai));   
        }

        [TestMethod]
        public void DeleteObjectTest()
        {
            Assert.IsTrue(_repository.Cities.Contains(_moscow));
            _repository.DeleteObject(0);
            Assert.IsFalse(_repository.Cities.Contains(_moscow));
        }
    
        [TestMethod]
        public void FilterDataByPopulation()
        {
            List<CityEntity> cities = _repository.FilterDataByPopulation(300);
            Assert.IsFalse(cities.Contains(_voronezh));
            Assert.IsTrue(cities.Contains(_moscow));
        }
        
        [TestMethod]
        public void FilterDataBySquare()
        {
            List<CityEntity> cities = _repository.FilterDataBySquare(14);
            Assert.IsFalse(cities.Contains(_voronezh));
            Assert.IsTrue(cities.Contains(_moscow));
        }
        
    }
}
