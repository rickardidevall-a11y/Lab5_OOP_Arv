using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    public class Bulldog : Dog
    {
        //Unique property.
        public bool IsCute { get; set; } = false;

        //Default constructor uses default values from Dog/Animal.
        public Bulldog() : base()
        {
            Species = "Bulldog";
        }

        //Constructor with arguments allows creating a specific bulldog.
        public Bulldog(string name, int age, string color, string species, int weight, string furType, bool isCute)
            : base(name, age, color, species, weight, furType)
        {
            IsCute = isCute;
        }

        //Overrides.
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Grumph");
        }

        public override void IsMoving()
        {
            Console.WriteLine($"{Name} is waddling slowly");
        }

        //Unique method.
        public void Guard()
        {
            Console.WriteLine($"The bulldog {Name} is guarding the house");
        }
    }
}
