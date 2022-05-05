using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using lab3.Megalopolis;

namespace RepositoryTests
{
    [TestClass]
    public class MegapolisRepositoryTests
    {
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
            Megapolis dubai = new Megapolis("Dubai", 70000, 500);
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
            List<Megapolis> cities = _repository.FilterDataByPopulation(300);
            Assert.IsFalse(cities.Contains(_voronezh));
            Assert.IsTrue(cities.Contains(_moscow));
        }
        
        [TestMethod]
        public void FilterDataBySquare()
        {
            List<Megapolis> cities = _repository.FilterDataBySquare(14);
            Assert.IsFalse(cities.Contains(_voronezh));
            Assert.IsTrue(cities.Contains(_moscow));
        }
        
    }
}
