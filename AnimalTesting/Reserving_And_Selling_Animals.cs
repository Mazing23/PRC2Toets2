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
        public void Test_Reserving_Animal()
        {
            Add_Animal_To_AllAnimal_List();

            Assert.IsFalse(animala.IsReserved);
        }
    }
}
