using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    public class Chihuahua : Dog
    {
        //Unique property.
        public bool IsNervous { get; set; } = false;

        //Default constructor uses default values from Dog/Animal.
        public Chihuahua() : base()
        {
            Species = "Chihuahua";
        }

        //Constructor with arguments allows creating a specific chihuahua.
        public Chihuahua(string name, int age, string color, string species, int weight, string furType, bool isNervous)
            : base(name, age, color, species, weight, furType)
        {
            IsNervous = isNervous;
        }

        //Overrides.
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Wieee");
        }

        public override void IsMoving()
        {
            Console.WriteLine($"{Name} is shaking while walking");
        }

        //Unique method.
        public void Shake()
        {
            Console.WriteLine($"The chihuahua {Name} is shaking nervously");
        }
    }
}
