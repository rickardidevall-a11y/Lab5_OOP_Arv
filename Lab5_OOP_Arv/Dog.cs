using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    public class Dog : Animal
    {
        public string FurType { get; set; } = "Unknown";

        public Dog() : base()
        {
            Species = "Dog";
        }
        public Dog(string name, int age, string color, string species, int weight, string furType) 
            : base(name, age, color, species, weight)
        {
            FurType = furType;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is saying woff!");
        }
        public override void IsMoving()
        {
            Console.WriteLine($"{Name} is running");
        }

        public void Play()
        {
            Console.WriteLine($"The dog {Name} is playing");
        }
    }
}
