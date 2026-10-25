using System.Security.Cryptography.X509Certificates;

namespace labb2_arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog();
            Cat misse = new Cat();
            Lion simba = new Lion();
            Bulldog bruno = new Bulldog();
            Chihuahua taco = new Chihuahua();
            Dog bella = new Dog("Bella", 5, 15, "White", "Stick");

            // All animals make their sound
            rex.MakeSound();
            misse.MakeSound();
            simba.MakeSound();
            bruno.MakeSound();
            taco.MakeSound();
            bella.MakeSound();

            Console.WriteLine();

            // Shared methods from Animal
            rex.Describe();
            misse.Eat();
            simba.Sleep();

            Console.WriteLine();

            // Each animal's own methods
            rex.Fetch();
            misse.Climb();
            simba.Hunt();
            bruno.Snore();
            bruno.Fetch(); 
            taco.Shiver();
        }
    }
}
