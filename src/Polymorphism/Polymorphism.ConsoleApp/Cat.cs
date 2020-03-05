using System;

namespace Polymorphism.ConsoleApp
{
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Miow... Miah!");
        }
    }
}
