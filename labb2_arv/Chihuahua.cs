using System;
using System.Collections.Generic;
using System.Text;

namespace labb2_arv
{
    public class Chihuahua : Dog
    {
        public bool FitsInBag { get; set; }

        public Chihuahua(string name = "Taco", int age = 2, double weight = 2, string color = "Tan", string favoriteToy = "Sock", bool fitsInBag = true)
            : base(name, age, weight, color, favoriteToy)
        {
            FitsInBag = fitsInBag;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Yip yip!");
        }

        public void Shiver()
        {
            Console.WriteLine($"{Name} is shivering.");
        }
    }
}
