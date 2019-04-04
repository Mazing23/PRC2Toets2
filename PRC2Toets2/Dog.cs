﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC2Toets2
{
    public class Dog : Animal
    {
        public SimpleDate LastWalkDate { get; set; }
        public override decimal Price { get; set; }

        public Dog(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, SimpleDate lastWalkDate) : base(chipRegistrationNumber, dateOfBirth, name)
        {
            LastWalkDate = lastWalkDate;
            Price = GetPrice();
        }

        public override decimal GetPrice()
        {
            if (ChipRegistrationNumber < 50000) return 200;
            else return 350;
        }

        public override string ToString()
        {
            string walk;
            if (LastWalkDate == null)
            {
                walk = "Please Walk!";
            }
            else
            {
                walk = LastWalkDate.ToString();
            }
            return "Dog: "
                + base.ToString()
                + ", "
                + walk;
        }
    }
}
