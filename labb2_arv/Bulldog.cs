using System;
using System.Collections.Generic;
using System.Text;

namespace labb2_arv
{
    public class Bulldog : Dog
    {
        public int Wrinkles { get; set; }

        public Bulldog(string name = "Bruno", int age = 4, double weight = 25, string color = "White", string favoriteToy = "Rope", int wrinkles = 20)
            : base(name, age, weight, color, favoriteToy)
        {
            Wrinkles = wrinkles;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Gruff gruff!");
        }

        public void Snore()
        {
            Console.WriteLine($"{Name} snores loudly. Zzz...");
        }
    }
}
