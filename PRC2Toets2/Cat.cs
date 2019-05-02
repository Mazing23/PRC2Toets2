using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC2Toets2
{
    [Serializable]
    public class Cat : Animal
    {
        public string BadHabits { get; set; }
        public override decimal Price { get { decimal price = 60;
                if (BadHabits != null)
                {
                    int length = BadHabits.Length;
                    price -= length;
                    if (price < 20)
                    {
                        price = 20;
                    }
                }
                return price; }
        } 

        public Cat(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, string badHabits)
            : base(chipRegistrationNumber, dateOfBirth, name)
        {
            BadHabits = badHabits;
        }

        public override string ToString()
        {
            return "Cat: " + base.ToString() + ", " + BadHabits;
        }
    }
}
