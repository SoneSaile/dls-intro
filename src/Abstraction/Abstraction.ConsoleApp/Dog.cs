using System;

namespace Abstraction.ConsoleApp
{
    public class Dog : IDog
    {
        private int _age;

        public Dog(int age)
        {
            _age = age;
        }

        private bool IsYoung => _age < 2;

        public void Bark()
        {
            if (IsYoung) Console.WriteLine("Woooooof!");
            else Console.WriteLine("Woof!!!!!");
        }
    }
}
