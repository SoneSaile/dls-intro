using System;

namespace Inheritance.ConsoleApp
{
    public class Beagle : Dog
    {
        private bool _hasBlackSpots;

        public Beagle(string name, int age) : base(name, age)
        {
            _hasBlackSpots = age < 5;
        }

        public bool LikesToBreakStuff()
        {
            return _age < 3;
        }

        public void MakesBirthday()
        {
            _age++;

            if (_age >= 5)
                _hasBlackSpots = false;
        }

        public void CheckForBlackSpots()
        {
            if (_hasBlackSpots)
                Console.WriteLine("Your beagle has black spots!");
            else
                Console.WriteLine("Your beagle does not have black spots :(");
        }
    }
}
