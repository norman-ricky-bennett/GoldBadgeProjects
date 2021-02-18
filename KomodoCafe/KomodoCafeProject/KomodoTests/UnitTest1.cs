using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KomodoRepo;
using KomodoCafe;

namespace KomodoTests
{
    [TestClass]
    public class UnitTest1
    {
        private MenuItem_Repo _repo;

        private MenuItem _item;


        [TestMethod]
        public void AddToMenu()
        {
            MenuItem item = new MenuItem();

            item.MealNumber = 1;

            MenuItem_Repo repo = new MenuItem_Repo();

            repo.AddItemToDirectory(item);

            MenuItem itemFromDirectory = repo.GetMealByNum(1);

            Assert.IsNotNull(itemFromDirectory);
        }

        [TestMethod]

        public void DisplayContents()
        {
            Assert.IsNotNull(_repo);
        }
    }

        /*[TestMethod]

        *//*public void DeleteMenuItem()
        {
            MenuItem itemFromDirectory = _repo.GetMealByNum(1);

            _repo.DeleteContent(itemFromDirectory);


        }*/
    }
}
