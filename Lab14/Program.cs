using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Cat cat = new Cat("Мурка");
                cat.Say();
                Dog dog = new Dog("Бобик");
                dog.Say();
                Console.ReadKey();
            }
        }
        abstract class Animal
        {
            public abstract string name { get; set; }
            public Animal(string name)
            {
                this.name = name;
            }
            public abstract void Say();
            public void ShowInfo()
            {
                Console.WriteLine(name);
                Say();
            }
        }
        class Cat : Animal
        {
            public override string name { get; set; }
            public Cat(string name) : base(name)
            {
            }
            public override void Say()
            {
                Console.WriteLine ("Мяу!");
            }
        }
        class Dog : Animal
        {
            public override string name { get; set; }
            public Dog(string name) : base(name)
            {
            }
            public override void Say()
            {
                Console.WriteLine ("Гав!");
            }
        }
    }
}
