using System;

namespace Encapsulation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing;

            do
            {
                Console.WriteLine("Do you wish to adopt a dog?");

                bool willAdopt = Console.ReadLine().ToLower() == "yes";

                Console.Clear();

                if (willAdopt)
                {
                    Console.Write("Type the fur color: ");
                    string furColor = Console.ReadLine();

                    Console.Write("Type the eye color: ");
                    string eyeColor = Console.ReadLine();

                    Dog yourNewDog = new Dog(furColor, eyeColor);

                    Console.Clear();

                    Console.WriteLine("Here's your new dog for adoption!");
                    Console.WriteLine(yourNewDog.GetDogCharacteristics());
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("Do you wish to continue?");
                keepGoing = Console.ReadLine().ToLower() == "yes";

            } while (keepGoing);
        }
    }
}
