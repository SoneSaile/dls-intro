using System;

namespace Polymorphism.ConsoleApp
{
    class Program
    {
        private static Random _random;

        static void Main(string[] args)
        {
            bool keepGoing;

            _random = new Random();

            do
            {
                Console.WriteLine("Do you wish do adopt an animal?");
                bool willAdopt = Console.ReadLine().ToLower() == "yes";

                if (willAdopt)
                {
                    Console.Clear();

                    IAnimal newAnimal = _random.Next(1, 2) switch
                    {
                        1 => new Cat(),
                        2 => new Dog(),
                        _ => new Dog()
                    };

                    newAnimal.MakeSound();

                    Console.ReadKey();
                }

                Console.Clear();
                Console.WriteLine("Do you wish to continue?");
                keepGoing = Console.ReadLine().ToLower() == "yes";
            } while (keepGoing);
        }
    }
}
