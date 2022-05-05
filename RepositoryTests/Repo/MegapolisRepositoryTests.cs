using System.Collections.Generic;
using lab3.Megapolis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryTests
{
    [TestClass]
    public class MegapolisRepositoryTests
    {
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
        public void SortingByPopulationTest()
        {
            _repository.SortDataByPopulation();
            Assert.AreEqual(_voronezh, _repository.Megapolis[0]);
        }
        
        [TestMethod]
        public void SortingByPopulationDescendingTest()
        {
            _repository.SortDataByPopulationDescending();
            Assert.AreEqual(_new_york, _repository.Megapolis[0]);
        }
        
        [TestMethod]
        public void SortingBySquareTest()
        {
            _repository.SortDataBySquare();
            Assert.AreEqual(_voronezh, _repository.Megapolis[0]);
        }
        
        [TestMethod]
        public void SortingBySquareDescendingTest()
        {
            _repository.SortDataBySquareDescending();
            Assert.AreEqual(_new_york, _repository.Megapolis[0]);
        }

        [TestMethod]
        public void AddObjectTest()
        {
            MegapolisEntity dubai = new MegapolisEntity("Dubai", 70000, 500);
            _repository.AddObject(dubai);
            Assert.IsTrue(_repository.Megapolis.Contains(dubai));   
        }

        [TestMethod]
        public void DeleteObjectTest()
        {
            Assert.IsTrue(_repository.Megapolis.Contains(_moscow));
            _repository.DeleteObject(0);
            Assert.IsFalse(_repository.Megapolis.Contains(_moscow));
        }
    
        [TestMethod]
        public void FilterDataByPopulation()
        {
            List<MegapolisEntity> cities = _repository.FilterDataByPopulation(300);
            Assert.IsFalse(cities.Contains(_voronezh));
            Assert.IsTrue(cities.Contains(_moscow));
        }
        
        [TestMethod]
        public void FilterDataBySquare()
        {
            List<MegapolisEntity> cities = _repository.FilterDataBySquare(14);
            Assert.IsFalse(cities.Contains(_voronezh));
            Assert.IsTrue(cities.Contains(_moscow));
        }
        
    }
}
