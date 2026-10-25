using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace labb2_arv
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name = "Unknown", int age = 1, double weight = 10, string color = "Gray", bool isHungry = true)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
            IsHungry = isHungry;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
            IsHungry = false;
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public void Describe()
        {
            Console.WriteLine($"{Name}, {Age} years, {Weight} kg, {Color}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
}
