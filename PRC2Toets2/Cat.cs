using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC2Toets2
{
    public class Cat : Animal
    {
        public string BadHabits { get; set; }
        public override decimal Price { get; set; }

        public Cat(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, string badHabits)
            : base(chipRegistrationNumber, dateOfBirth, name)
        {
            if (!string.IsNullOrEmpty(badHabits))
            {
                BadHabits = null;
            }
            else
            {
                BadHabits = badHabits;
            }
            Price = GetPrice();
        }

        public override decimal GetPrice()
        {
            decimal price = 60;
            if (BadHabits != null)
            {
                int length = BadHabits.Length;
                price -= length;
                if (price < 20)
                {
                    price = 20;
                }
            }
            return price;
        }

        public override string ToString()
        {
            return "Cat: " + base.ToString() + ", " + BadHabits;
        }
    }
}
