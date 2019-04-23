using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
