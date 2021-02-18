using ClaimsRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClaimsTests
{


    [TestClass]
    public class UnitTest1

    {

        private ClaimsEntry_Repo _repo;
        private ClaimEntry _claim;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimsEntry_Repo();
            // Seed content
            _claim = new ClaimEntry();
        }

        [TestMethod]
        public void AddContentToQueue()
        {
            _repo.AddItemToDirectory(_claim);
            int expected = 1;
            int actual = _repo.GetContents().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
