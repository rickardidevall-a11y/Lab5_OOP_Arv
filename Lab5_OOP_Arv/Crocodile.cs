using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    public class Crocodile : Animal
    {
        //Unique property.
        public string TailType { get; set; } = "Unknown";

        //Do I need both constructors? The empty one except for species thats reasonably. 
        public Crocodile() : base()
        {
            Species = "Crocodile";
        }

        //Constructor with arguments that allows to create a specifik crocodile. 
        public Crocodile(string name, int age, string color, string species, int weight, string tailType)
            : base(name, age, color, species, weight)
        {
            TailType = tailType;
        }
        //The methods.
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is growling..?");
        }
        public override void IsMoving()
        {
            Console.WriteLine($"{Name} slowly crawls");
        }

        public void Sleeps()
        {
            Console.WriteLine($"The crocodile {Name} is sleeping");
        }
    }
}
