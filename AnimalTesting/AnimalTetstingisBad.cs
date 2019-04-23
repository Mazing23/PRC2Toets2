﻿using System;
using PRC2Toets2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalTesting
{
    [TestClass]
    public class AnimalTetstingisBad
    {
        [TestMethod]
        public void TestAddingAnimal()
        {
            int number = 13;
            Animal animal = new Cat(number, new SimpleDate(9, 8, 1995), "Harry", "");
            Administration admin = new Administration();
            while(!admin.Add(animal))
            {
                number++;
                animal = new Cat(number, new SimpleDate(9, 8, 1995), "Harry", "");
            }
            Animal animalb = new Dog(number, new SimpleDate(9, 8, 2017), "Louise", new SimpleDate(7, 8, 2018));
            while(!admin.Add(animalb))
            {
                number++;
                animalb = new Dog(number, new SimpleDate(9, 8, 2017), "Louise", new SimpleDate(7, 8, 2018));
            }

            Assert.AreEqual(14, animalb.ChipRegistrationNumber);
        }

        [TestMethod]
        public void TestAddingAnimalPartTwo()
        {
            //minder cmplex
            int number = 13;
            Animal animal = new Cat(number, new SimpleDate(9, 8, 1995), "Harry", "");
            Administration admin = new Administration();
            while (!admin.Add(animal))
            {
                number++;
                animal = new Cat(number, new SimpleDate(9, 8, 1995), "Harry", "");
            }
            Animal animalb = new Dog(number, new SimpleDate(9, 8, 2017), "Louise", new SimpleDate(7, 8, 2018));
            while (!admin.Add(animalb))
            {
                number++;
                animalb = new Dog(number, new SimpleDate(9, 8, 2017), "Louise", new SimpleDate(7, 8, 2018));
            }

            Assert.AreEqual(animalb, admin.FindAnimal(14));
            Assert.AreEqual(animal, admin.FindAnimal(13));
        }

        [TestMethod]
        public void Test_WillFail_To_Add_SecondAnimal() //name test will fail to add second animal
        {
            SimpleDate date = new SimpleDate(9, 6, 1995);
            Animal animal = new Cat(13, date, "harry", "");
            Administration admin = new Administration();
            admin.Add(animal);
            Animal animalTwo = new Dog(13, date, "HarryTwo", date);
            bool b = admin.Add(animalTwo);

            Assert.IsFalse(b); //assert.isfalse(b)
            //collection
            //eerst test schrijven, dan code.
            //simple, simple, simple
            //first test than simple code, then test, then simple code//
        }

        [TestMethod]
        public void AnimalAddTestPass()
        {
            SimpleDate date = new SimpleDate(9, 6, 1995);
            Animal animal = new Cat(13, date, "harry", "");
            Administration admin = new Administration();

            bool a = admin.Add(animal);

            Animal animalTwo = new Dog(12, date, "HarryTwo", date);
            bool b = admin.Add(animalTwo);

            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void TestAnimalRemove()
        {
            int number = 13;
            Animal animal = new Cat(number, new SimpleDate(9, 8, 1995), "Harry", "");
            Administration admin = new Administration();
            admin.Add(animal);

            admin.RemoveAnimal(number);

            Assert.AreEqual(null, admin.FindAnimal(number));
        }

        [TestMethod]
        public void TestSellAnimal()
        {
            int number = 13;
            Animal animala = new Cat(number, new SimpleDate(9, 8, 1995), "Harry", "");
            Administration admin = new Administration();
            admin.Add(animala);

            Animal animalb = new Dog(14, new SimpleDate(9, 8, 1995), "Harry", new SimpleDate(9,6,2018));
            admin.Add(animalb);

            Animal animalc = new Dog(55000, new SimpleDate(9, 8, 1995), "Harry", new SimpleDate(9, 6, 2018));
            admin.Add(animalc);

            Assert.AreEqual(200, animalb.Price);
            Assert.AreEqual(60, animala.Price);
            Assert.AreEqual(350, animalc.Price);
        }

        [TestMethod]
        public void TestAddTrueAnimal()
        {
            Animal animala = new Cat(14, new SimpleDate(9, 8, 1995), "Harry", "");
            Administration admin = new Administration();

            bool b = admin.Add(animala);

            Assert.AreEqual(true, b);

        }
    }
}
