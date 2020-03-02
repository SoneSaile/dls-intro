using System;

namespace Inheritance.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing;

            do
            {
                Console.WriteLine("Do you wish do adopt a dog?");
                bool willAdopt = Console.ReadLine().ToLower() == "yes";
                Console.Clear();

                if (willAdopt)
                {
                    Console.WriteLine("Choose your dog:");
                    Console.WriteLine($"1. {nameof(Beagle)}");
                    Console.WriteLine($"0. Any");

                    string chosenOption = Console.ReadLine().ToLower();

                    switch(chosenOption)
                    {
                        case nameof(Beagle):
                            {
                                Beagle beagleDog = new Beagle("Tathy", 9);
                                beagleDog.Bark();
                                beagleDog.CheckForBlackSpots();
                                break;
                            }

                        default:
                            {
                                Dog anyDog = new Dog("Scooby", 4);
                                anyDog.Bark();
                                break;
                            }
                    }

                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("Do you wish to continue?");
                keepGoing = Console.ReadLine().ToLower() == "yes";
            } while (keepGoing);
        }
    }
}
