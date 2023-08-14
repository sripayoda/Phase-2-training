using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class MyPetsWithInterface : IAnimal
    {
        private int eyes, ears, legs;
        private string? name = string.Empty;
        public int Eyes { get => eyes; set => eyes = value; }
        public int Ears { get => ears; set => ears = value; }
        public int Legs { get => legs; set => legs = value; }
        public string? Name { get => name; set => name = value; }

        public void Aboutme()
        {
            Console.WriteLine($"I have {Eyes} eyes {Ears} ears and {Legs} legs");
        }

        public void Sound()
        {
            Console.WriteLine($"{Name}");
            if (Name.ToLower().Equals("dog"))
                Console.WriteLine("Bow Bowwww");
            else if (Name.ToLower().Equals("cat"))
                Console.WriteLine("Meow Meowww");
        }

        public MyPetsWithInterface(int eyes, int ears, int legs, string? name)
        {
            Eyes = eyes;
            Ears = ears;
            Legs = legs;
            Name = name;
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping Z z Z...");
        }

        public void Eat()
        {
            Console.WriteLine("Eatings");
        }
    }
}
