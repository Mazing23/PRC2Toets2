using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRC2Toets2;

namespace AnimalTesting
{
    [TestClass]
    public class Administration_Test
    {
        Administration admin ;
        Animal animala;
        Animal animalb;
        Animal animalc;

        [TestInitialize]
        public void Setup()
        {
            admin = new Administration();
            animala = new Cat(13, new SimpleDate(9, 8, 1995), "Harry", "");
            animalb = new Dog(14, new SimpleDate(9, 8, 1995), "Harry", new SimpleDate(9, 6, 2018));
            animalc = new Dog(15, new SimpleDate(9, 8, 1995), "Harry", new SimpleDate(9, 6, 2018));
        }

        [TestMethod]
        public void Add_WillAddAnimaltoAllAnimals_and_return_True()
        {
            bool result = admin.Add(animala);
            Assert.IsTrue(result);
            CollectionAssert.AreEquivalent(new[] { animala }, admin.AllAnimals);
        }

        [TestMethod]
        public void Add_WillNotAddDuplicateAnimal()
        {           
            admin.Add(animala);
            bool result = admin.Add(animala);
            Assert.IsFalse(result);
            CollectionAssert.AreEquivalent(new[] { animala }, admin.AllAnimals);
        }

        [TestMethod]
        public void Remove_WillReturnFalseWhenAnimalNotPresent()
        {
            bool result = admin.RemoveAnimal(13);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Remove_WillRemoveAnimalFromList()
        {
            admin.Add(animala);
            bool result = admin.RemoveAnimal(animala.ChipRegistrationNumber);
            Assert.AreEqual(null, admin.FindAnimal(13));
            Assert.IsTrue(result);
            CollectionAssert.DoesNotContain(admin.AllAnimals, animala);
        }

        [TestMethod]
        public void FindAnimal_ReturnsAnimalWith_ID_Number()
        {
            admin.Add(animala);
            Assert.AreEqual(admin.FindAnimal(13), animala);
        }

        [TestMethod]
        public void FindAnimal_ReturnsNullWith_ID_Number()
        {
            Assert.AreEqual(admin.FindAnimal(12), null);
        }

        [TestMethod]
        public void Test_Animal_Will_Change_Number()
        {
            admin.Add(animala);
            admin.Add(animalb);
            admin.Add(animalc);

            int number = 13;
            Animal animale = new Dog(number, new SimpleDate(9, 8, 2017), "Louise", new SimpleDate(7, 8, 2018));
            while (!admin.Add(animale))
            {
                number++;
                animale = new Dog(number, new SimpleDate(9, 8, 2017), "Louise", new SimpleDate(7, 8, 2018));
            }

            Assert.AreEqual(16, animale.ChipRegistrationNumber);
        }

    }
}
