using System;
using PRC2Toets2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTesting
{
    [TestClass]
    public class Adding_Animal
    {
        Administration admin = new Administration();
        Animal animala = new Cat(13, new SimpleDate(9, 8, 1998), "Lerry", "");
        Animal animalb = new Dog(14, new SimpleDate(9, 8, 1996), "Harry", new SimpleDate(8, 9, 2019));
        Animal animalc = new Dog(15, new SimpleDate(9, 8, 2017), "Sam", new SimpleDate(5, 7, 2018));
        Animal animald = new Cat(16, new SimpleDate(9, 8, 2005), "Kit", "Bites");

        private void Add_Animal_To_AllAnimal_List()
        {
            admin.Add(animala);

            admin.Add(animalb);

            admin.Add(animalc);

            admin.Add(animald);
        }

        [TestMethod]
        public void Test_Add_Animal()
        {
            bool a = admin.Add(animala);
            Assert.IsTrue(a);
        }

        [TestMethod]
        public void Test_Animal_Will_Change_Number()
        {
            Add_Animal_To_AllAnimal_List();

            int number = 16;
            Animal animale = new Dog(number, new SimpleDate(9, 8, 2017), "Louise", new SimpleDate(7, 8, 2018));
            while (!admin.Add(animale))
            {
                number++;
                animale = new Dog(number, new SimpleDate(9, 8, 2017), "Louise", new SimpleDate(7, 8, 2018));
            }

            Assert.AreEqual(17, animale.ChipRegistrationNumber);
        }

        [TestMethod]
        public void Test_Add_And_Find_Animal()
        {
            Add_Animal_To_AllAnimal_List();

            admin.Add(animala);      
            
            Assert.AreEqual(animala, admin.FindAnimal(13));
        }

        [TestMethod]
        public void Test_All_Added_Animals_Are_Animals()
        {
            Add_Animal_To_AllAnimal_List();

            CollectionAssert.AllItemsAreInstancesOfType(admin.AllAnimals, typeof(Animal));
        }

        [TestMethod]
        public void Test_Will_Fail_To_Add_Second_Animal_w_Same_ID()
        {
            Add_Animal_To_AllAnimal_List();

            Animal animalTwo = new Dog(13, new SimpleDate(9, 6, 1995), "HarryTwo", new SimpleDate(9, 6, 1995));
            bool b = admin.Add(animalTwo);

            Assert.IsFalse(b);
        }
    }
}
