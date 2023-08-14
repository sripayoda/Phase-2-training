using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Animal
    {
        private int eyes, ears, legs;

        public int Eyes { get => eyes; set => eyes = value; }
        public int Ears { get => ears; set => ears = value; }
        public int Legs { get => legs; set => legs = value; }

        public Animal(int eyes, int ears, int legs)
        {
            Eyes = eyes;
            Ears = ears;
            Legs = legs;
        }

        public static void Sleep()
        {
            Console.WriteLine("Sleeping Z z Z...");
        }

        public static void Eat()
        {
            Console.WriteLine("Eatings");
        }

        public void Aboutme() 
        {
            Console.WriteLine($"I have {Eyes} eyes {Ears} ears and {Legs} legs");
        }

        public abstract void Sound();
    }
}
