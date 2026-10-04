using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    public class Cat : Animal
    {
        public string EyeColor { get; set; } = "Uknown";

        public Cat() : base()
        {
            Species = "Cat";
        }
        public Cat(string name, int age, string color, string species, int weight, string eyeColor)
            : base(name, age, color, species, weight)
        {
            EyeColor = eyeColor;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Meow");
        }
        public override void IsMoving()
        {
            Console.WriteLine($"{Name} is sneaking");
        }
        public void Pounce()
        {
            Console.WriteLine($"The cat {Name} is pouncing!");
        }
    }
}
