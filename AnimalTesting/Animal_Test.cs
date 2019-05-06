using System;
using PRC2Toets2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace AnimalTesting
{
    [TestClass]
    public class AnimalImport_Test
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
        public void Animal_AllAnimals_CheckFirstAdded_is_FirstInList()
        {
            Assert.AreEqual(admin.AllAnimals[0], animala);
        }

        [TestMethod]
        public void Animal_AllAnimals_SortAnimalList_and_CheckIfFirst_has_LowestChip()
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
