using labb2_arv;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace labb2_arv
{
    public class Dog : Animal
    {
        public string FavoriteToy { get; set; }

        public Dog(string name = "Rex", int age = 3, double weight = 20, string color = "Brown", string favoriteToy = "Ball")
            : base(name, age, weight, color)
        {
            FavoriteToy = favoriteToy;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} fetches the {FavoriteToy}.");
        }
    }

}




