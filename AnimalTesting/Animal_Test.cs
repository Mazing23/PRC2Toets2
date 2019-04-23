using System;
using PRC2Toets2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTesting
{
    [TestClass]
    public class Animal_Test
    {
        Administration admin = new Administration();
        Animal animala = new Cat(13, new SimpleDate(9, 8, 1998), "Lerry", "");
        Animal animalb = new Dog(24, new SimpleDate(9, 8, 1996), "Harry", new SimpleDate(8, 9, 2019));
        Animal animalc = new Dog(8, new SimpleDate(9, 8, 2017), "Sam", new SimpleDate(5, 7, 2018));
        Animal animald = new Cat(11, new SimpleDate(9, 8, 2005), "Kit", "Bites");

        private void Add_Animal_To_AllAnimal_List()
        {
            admin.Add(animala);

            admin.Add(animalb);

            admin.Add(animalc);

            admin.Add(animald);
        }

        [TestMethod]
        public void Test_CompareTo_Sort_List()
        {
            Add_Animal_To_AllAnimal_List();

            admin.AllAnimals.Sort();
            Assert.AreEqual(admin.AllAnimals[0], animalc);
        }


    }
}
