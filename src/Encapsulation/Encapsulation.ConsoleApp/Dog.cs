using System;

namespace Encapsulation.ConsoleApp
{
    internal class Dog
    {
        private string _furColor;
        private string _eyeColor;

        public Dog(string furColor, string eyeColor)
        {
            _furColor = furColor;
            _eyeColor = eyeColor;
        }

        public void PaintFur(string newColor)
        {
            Console.WriteLine("What colour do you want to paint your dog?");
            newColor = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(newColor))
            {
                do
                {
                    Console.WriteLine("The new color can't be empty.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What colour do you want to paint your dog?");
                    newColor = Console.ReadLine();

                } while (String.IsNullOrWhiteSpace(newColor));
            }

            _furColor = newColor;
        }

        public string GetEyeColor()
        {
            return _eyeColor;
        }

        public string GetDogCharacteristics()
        {
            return $"It has {_furColor} fur and {_eyeColor} eyes.";
        }
    }
}
