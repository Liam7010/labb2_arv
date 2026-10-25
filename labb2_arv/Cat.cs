using System;
using System.Collections.Generic;
using System.Text;

namespace labb2_arv
{
    public class Cat : Animal
    {
        public int LivesLeft { get; set; }

        public Cat(string name = "Misse", int age = 2, double weight = 4, string color = "Black", int livesLeft = 9) 
            : base(name, age, weight, color)
        {
            LivesLeft = livesLeft;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }

        public void Climb()
        {
            Console.WriteLine($"{Name} climbs a tree. Lives left: {LivesLeft}");
        }
    }
}
