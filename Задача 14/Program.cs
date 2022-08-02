using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
            static void Main(string[] args)
            {
            }
        abstract class Animal
        {
            public abstract string Name { get; set; }

            public Animal(string name)
            {
                Name = name;
            }
            public abstract void Say();

            public void ShowInfo()
            {
                Console.WriteLine(Name);
                Say();
            }
        }
        class Cat : Animal

        {
            string say;
            string name;
            public override string Name
            {
                get => name;
                set => name = value;
            }
            public Cat(string name, string say)
                : base(name)
            {
                this.say = say;
            }
            public override void Say()
            {
                Console.WriteLine(say);
                Console.ReadKey();
            }
        }
        class Dog : Animal
        {
            private string name;
            public override string Name
            {
                get => name;
                set => name = value;
            }
            public Dog(string name, string say)
                : base(name)
            {
            }
            public override void Say()
            {
                Console.WriteLine("Гав");
                Console.ReadKey();
            }
        }
    }
} 
