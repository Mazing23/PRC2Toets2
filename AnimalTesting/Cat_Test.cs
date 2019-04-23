using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRC2Toets2;

namespace AnimalTesting
{
    [TestClass]
    public class Cat_Test
    {
        Administration admin;
        Animal animala;
        Animal animalb;
        Animal animalc;

        [TestInitialize]
        public void Setup()
        {
            admin = new Administration();
            animala = new Cat(13, new SimpleDate(9, 8, 1995), "Harry", "");
            animalb = new Cat(13, new SimpleDate(9, 8, 1998), "Lerry", "Bites, Growls, Spits, does a lot of humping");
            animalc = new Cat(16, new SimpleDate(9, 8, 2005), "Kit", "Bites");
        }

        [TestMethod]
        public void Price_ReturnsFullPriceWhenNo_BadHabits()
        {
            admin.Add(animala);
            decimal price = animala.Price;
            Assert.AreEqual(60, price);
        }

        [TestMethod]
        public void Price_ReturnsCalculatedPriceWhenYes_BadHabits()
        {
            admin.Add(animalc);
            decimal price = animalc.Price;
            Assert.AreEqual(55, price);
        }

        [TestMethod]
        public void Price_ReturnsMinimumPriceWhenYes_BadHabits()
        {
            admin.Add(animalb);
            decimal price = animalb.Price;
            Assert.AreEqual(20, price);
        }
    }
}
