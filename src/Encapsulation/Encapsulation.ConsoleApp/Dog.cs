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
            if (string.IsNullOrWhiteSpace(newColor))
            {
                Console.WriteLine("The new color can't be empty.");
                return;
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
