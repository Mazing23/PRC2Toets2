using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRC2Toets2;


namespace AnimalTesting
{
    [TestClass]
    public class Dog_Test
    {
        Administration admin;
        Animal animala;
        Animal animalb;
        Animal animalc;

        [TestInitialize]
        public void Setup()
        {
            admin = new Administration();
            animala = new Dog(8, new SimpleDate(9, 8, 2017), "Sam", new SimpleDate(5, 7, 2018));
            animalb = new Dog(14, new SimpleDate(9, 8, 1995), "Harry", new SimpleDate(9, 6, 2018));
            animalc = new Dog(55000, new SimpleDate(9, 8, 1995), "Harry", new SimpleDate(9, 6, 2018));
        }

        [TestMethod]
        public void Price_WillBe_High_BasedOn_Chip_Number()
        {
            admin.Add(animalc);
            decimal price = animalc.Price;
            Assert.AreEqual(350, price);
        }

        [TestMethod]
        public void Price_WillBe_Low_BasedOn_Chip_Number()
        {
            admin.Add(animala);
            decimal price = animala.Price;
            Assert.AreEqual(200, price);
        }

        [TestMethod]
        public void Price_WillNotBe_Equal_and_WillNotMatch_LowBased_AnimalChip()
        {
            admin.Add(animala);
            admin.Add(animalc);
            decimal price = animala.Price;
            Assert.AreNotEqual(animalc.Price, price);
        }
    }
}
