using System;
using PRC2Toets2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTesting
{
    [TestClass]
    public class Animal_Test
    {
        Administration admin;
        Animal animala;
        Animal animalb;
        Animal animalc;
        Animal animald;

        [TestInitialize]
        public void Setup()
        {
            admin = new Administration();
            animala = new Cat(13, new SimpleDate(9, 8, 1998), "Lerry", "");
            animalb = new Dog(24, new SimpleDate(9, 8, 1996), "Harry", new SimpleDate(8, 9, 2019));
            animalc = new Dog(8, new SimpleDate(9, 8, 2017), "Sam", new SimpleDate(5, 7, 2018));
            animald = new Cat(11, new SimpleDate(9, 8, 2005), "Kit", "Bites");
            admin.Add(animala);
            admin.Add(animalb);
            admin.Add(animalc);
            admin.Add(animald);
            animalb.IsReserved = true;
        }

        [TestMethod]
        public void Test_AnimalList_First()
        {
            Assert.AreEqual(admin.AllAnimals[0], animala);
        }

        [TestMethod]
        public void Test_CompareTo_Sort_List()
        {
            admin.AllAnimals.Sort();
            Assert.AreEqual(admin.AllAnimals[0], animalc);
        }

        [TestMethod]
        public void Reserved_CheckReservedStatus()
        {
            Assert.IsTrue(animalb.IsReserved);
            Assert.IsFalse(animala.IsReserved);
        }




    }
}
