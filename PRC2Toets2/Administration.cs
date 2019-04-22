using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC2Toets2
{
    public class Administration
    {
        private List<Animal> allAnimals;
        //auto properties
        //backingfiels/calculated !!!!!!!!!!!!

        public Administration()
        {
            allAnimals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {
            foreach (Animal a in allAnimals)
            {
                if (a.ChipRegistrationNumber == animal.ChipRegistrationNumber)
                {
                    return false;
                }
            }
            allAnimals.Add(animal);
            return true;
        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            foreach (Animal a in allAnimals)
            {
                if (a.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    allAnimals.Remove(a);
                    return true;
                }
            }
            return false;
        }

        public Animal FindAnimal(int chipRegistrationNumber)
        {
            foreach (Animal a in allAnimals)
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
