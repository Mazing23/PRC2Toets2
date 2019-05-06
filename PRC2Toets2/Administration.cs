using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

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
            catch (DirectoryNotFoundException ex)
            {
               throw new DirectoryNotFoundException($"Directory can not be found: {ex.Message}");
            }
            catch (IOException ex)
            {
                throw new IOException($"IO Excepttion: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException($"Null Argument Exception: {ex.Message}");
            }

        }

        public void Load(string fileName)
        {
            AllAnimals.Clear();
            List<Animal> animals = null;

            try
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    animals = bin.Deserialize(stream) as List<Animal>;
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException($"Directory can not be found: {ex.Message}");
            }
            catch (IOException ex)
            {
                throw new IOException($"IO Excepttion: {ex.Message}");
            }
            catch (SerializationException ex)
            {
                throw new SerializationException($"Serialization Exception: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException($"Null Argument Exception: {ex.Message}");
            }

            foreach (Animal a in animals)
                {
                    AllAnimals.Add(a);
                }         

        }

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
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException($"Directory can not be found: {ex.Message}");
            }
            catch (IOException ex)
            {
                throw new IOException($"IO Excepttion: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException($"Null Argument Exception: {ex.Message}");
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
