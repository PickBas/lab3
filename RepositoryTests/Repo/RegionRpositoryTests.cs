using System.Collections.Generic;
using lab3.Region;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryTests
{
    [TestClass]
    public class RegionRepositoryTests
    {
        private RegionRepository _repository;
        private RegionEntity _moscow;
        private RegionEntity _voronezh;
        private RegionEntity _new_york;
        private RegionEntity _la;
        
        [TestInitialize]
        public void SetUp()
        {
            List<RegionEntity> cities = new List<RegionEntity>();
            _moscow = new RegionEntity("Moscow", 300, 14);
            _voronezh = new RegionEntity("Voronezh", 100, 3);
            _new_york = new RegionEntity("New York", 1000, 24);
            _la = new RegionEntity("LA", 500, 20);
            cities.Add(_moscow);
            cities.Add(_voronezh);
            cities.Add(_new_york);
            cities.Add(_la);
            _repository = new RegionRepository(cities);
        }
        
        [TestMethod]
        public void SortingByPopulationTest()
        {
            _repository.SortDataByPopulation();
            Assert.AreEqual(_voronezh, _repository.Region[0]);
        }
        
        [TestMethod]
        public void SortingByPopulationDescendingTest()
        {
            _repository.SortDataByPopulationDescending();
            Assert.AreEqual(_new_york, _repository.Region[0]);
        }
        
        [TestMethod]
        public void SortingBySquareTest()
        {
            _repository.SortDataBySquare();
            Assert.AreEqual(_voronezh, _repository.Region[0]);
        }
        
        [TestMethod]
        public void SortingBySquareDescendingTest()
        {
            _repository.SortDataBySquareDescending();
            Assert.AreEqual(_new_york, _repository.Region[0]);
        }

        [TestMethod]
        public void AddObjectTest()
        {
            RegionEntity dubai = new RegionEntity("Dubai", 70000, 500);
            _repository.AddObject(dubai);
            Assert.IsTrue(_repository.Region.Contains(dubai));   
        }

        [TestMethod]
        public void DeleteObjectTest()
        {
            Assert.IsTrue(_repository.Region.Contains(_moscow));
            _repository.DeleteObject(0);
            Assert.IsFalse(_repository.Region.Contains(_moscow));
        }
    
        [TestMethod]
        public void FilterDataByPopulation()
        {
            List<RegionEntity> cities = _repository.FilterDataByPopulation(300);
            Assert.IsFalse(cities.Contains(_voronezh));
            Assert.IsTrue(cities.Contains(_moscow));
        }
        
        [TestMethod]
        public void FilterDataBySquare()
        {
            List<RegionEntity> cities = _repository.FilterDataBySquare(14);
            Assert.IsFalse(cities.Contains(_voronezh));
            Assert.IsTrue(cities.Contains(_moscow));
        }
        
    }
}
