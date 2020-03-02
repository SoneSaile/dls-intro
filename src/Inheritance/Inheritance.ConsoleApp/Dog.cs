using System;

namespace Inheritance.ConsoleApp
{
    public class Dog
    {
        protected string _name;
        protected int _age;

        public Dog(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
}
