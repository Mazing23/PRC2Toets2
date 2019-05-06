using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRC2Toets2;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System;

namespace AnimalTesting
{
    [TestClass]
    public class AnimalFileImporter_Test
    {
        Animal animala;
        Animal animalb;
        Animal animalc;

        [TestInitialize]
        public void Setup()
        {
            animala = new Cat(13, new SimpleDate(9, 8, 1995), "Harry", "");
            animalb = new Dog(14, new SimpleDate(9, 8, 1995), "Harry", new SimpleDate(9, 6, 2018));
            animalc = new Dog(15, new SimpleDate(9, 8, 1995), "Harry", new SimpleDate(9, 6, 2018));



            var dir = @"C:\\PRCTOETS3";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string fileNameBinairy = @"C:\\PRCTOETS3\\ANIMALSBinairy.txt";
            if (!File.Exists(fileNameBinairy))
            {
                File.Create(fileNameBinairy);
            }
            using (Stream stream = File.Open(fileNameBinairy, FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, animala);
                bin.Serialize(stream, animalb);
                bin.Serialize(stream, animalc);
            }

            string fileNameRegular = @"C:\\PRCTOETS3\\ANIMALSRegular.txt";
            if (!File.Exists(fileNameRegular))
            {
                File.Create(fileNameRegular);
            }
            using (StreamWriter stream = new StreamWriter(fileNameRegular))
            {
                stream.WriteLine(animala.ToString());
                stream.WriteLine(animalb.ToString());
                stream.WriteLine(animalc.ToString());
            }
        }


        [TestMethod]
        public void CheckContents_SerializationException()
        {

        }

        [TestMethod]
        public void CheckContents_IOException()
        {

        }
    }
}
