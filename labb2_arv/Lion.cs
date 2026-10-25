using System;
using System.Collections.Generic;
using System.Text;

namespace labb2_arv
{
    public class Lion : Animal
    {
        public double ManeLength { get; set; }

        public Lion(string name = "Simba", int age = 5, double weight = 190, string color = "Yellow", double maneLength = 25)
            : base(name, age, weight, color)
        {
            ManeLength = maneLength;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: ROAR!");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting.");
            IsHungry = true;
        }
    }
}
