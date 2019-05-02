using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PRC2Toets2
{
    
    public class Administration
    {
        private readonly List<Animal> allAnimals = new List<Animal>();
        public List<Animal> AllAnimals { get { return this.allAnimals; } private set {; } }
       
        public Administration()
        {
            AllAnimals = new List<Animal>();
            
        }

        /// <summary>
        /// Saves all animals to a file with the given file name using serialisation.
        /// </summary>
        /// <param name="fileName">The file to write to.</param>
        public void Save(string fileName)
        {
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, AllAnimals);
                }
            }
            catch (IOException ex)
            {
                throw new IOException(ex.ToString());
            }
        }

        /// <summary>
        /// Loads all animals from a file with the given file name using deserialisation.
        /// All animals currently in the administration are removed.
        /// </summary>
        /// <param name="fileName">The file to read from.</param>
        public void Load(string fileName)
        {
            AllAnimals.Clear();
            // what to do when file is empty???
            List<Animal> animals = null;
            
            try
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    animals = bin.Deserialize(stream) as List<Animal>;
                }
            }
            catch (IOException ex)
            {
                throw new IOException(ex.ToString());
            }

            foreach (Animal a in animals)
            {
                AllAnimals.Add(a);
            }

        }

        /// <summary>
        /// Exports the info of all animals to a text file with the given file name.
        /// 
        /// Each line of the file contains the info about exactly one animal.
        /// Each line starts with the type of animal and a colon (e.g. 'Cat:' or 'Dog:')
        /// followed by the properties of the animal seperated by comma's.
        /// </summary>
        /// <param name="fileName">The text file to write to.</param>
        public void Export(string fileName)
        {
            try
            {
                using (StreamWriter stream = new StreamWriter(fileName))
                {
                    foreach (Animal a in AllAnimals)
                    {
                        stream.WriteLine(a.ToString());
                    }
                }
            }
            catch (IOException ex)
            {
                throw new IOException(ex.ToString());
            }
        }



        public bool Add(Animal animal)
        {
            foreach (Animal a in AllAnimals)
            {
                if (a.ChipRegistrationNumber == animal.ChipRegistrationNumber)
                {
                    return false;
                }
            }
            AllAnimals.Add(animal);
            return true;
        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            foreach (Animal a in AllAnimals)
            {
                if (a.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    AllAnimals.Remove(a);
                    return true;
                }
            }
            return false;
        }

        public Animal FindAnimal(int chipRegistrationNumber)
        {
            foreach (Animal a in AllAnimals)
            {
                if (a.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
