using System;
using PRC2Toets2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTesting
{
    [TestClass]
    public class Reserving_And_Selling_Animals
    {
        Administration admin = new Administration();
        Animal animala = new Cat(13, new SimpleDate(9, 8, 1995), "Harry", "");

        Animal animalb = new Dog(14, new SimpleDate(9, 8, 1995), "Harry", new SimpleDate(9, 6, 2018));

        Animal animalc = new Dog(55000, new SimpleDate(9, 8, 1995), "Harry", new SimpleDate(9, 6, 2018));


        private void Add_Animal_To_AllAnimal_List()
        {
            admin.Add(animala);

            admin.Add(animalb);

            admin.Add(animalc);
        }

        [TestMethod]
        public void Test_Animal_Sell_For_Right_Price()
        {
            Add_Animal_To_AllAnimal_List();

            Assert.AreEqual(200, animalb.Price);
            Assert.AreEqual(60, animala.Price);
            Assert.AreEqual(350, animalc.Price);
        }

        [TestMethod]
        public void Test_Animal_Is_Not_Reserved()
        {
            Add_Animal_To_AllAnimal_List();

            Assert.IsFalse(animala.IsReserved);
        }

        [TestMethod]
        public void Test_Animal_Is_Reserved()
        {
            Add_Animal_To_AllAnimal_List();
            animala.IsReserved = true;

            Assert.IsTrue(animala.IsReserved);
        }

        [TestMethod]
        public void Test_Sell_And_Remove_Animal()
        {
            Add_Animal_To_AllAnimal_List();

            admin.RemoveAnimal(animalc.ChipRegistrationNumber);

            CollectionAssert.DoesNotContain(admin.AllAnimals, animalc);
            Assert.AreEqual(350, animalc.Price);
        }

        [TestMethod]
        public void Test_Remove_Animal()
        { 
            admin.RemoveAnimal(animala.ChipRegistrationNumber);

            Assert.AreEqual(null, admin.FindAnimal(13));
        }
    }
}
