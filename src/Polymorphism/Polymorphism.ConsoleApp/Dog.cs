using System;

namespace Polymorphism.ConsoleApp
{
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
            Console.WriteLine("Woof!");
        }
    }
}
