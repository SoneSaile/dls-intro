﻿using System;

namespace Abstraction.ConsoleApp
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
                Console.WriteLine("Do you want to adopt a dog?");
                bool willAdopt = Console.ReadLine().ToLower() == "yes";

                if (willAdopt)
                {
                    Console.Clear();

                    int age = _random.Next(0, 15);
                    IDog newDog = new Dog(age);
                    newDog.Bark();

                    Console.ReadKey();
                }

                Console.Clear();
                Console.WriteLine("Do you wish to continue?");
                keepGoing = Console.ReadLine().ToLower() == "yes";

            } while (keepGoing);
        }
    }
}
