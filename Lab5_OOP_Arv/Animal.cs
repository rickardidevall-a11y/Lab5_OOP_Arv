using System;
using System.Collections.Generic;
using System.Text;
 


namespace Lab5_OOP_Arv
{
    public class Animal
    {
        //Behöver jag verkligen deafault värden när jag använder konstruktor som kräver ett värde? Sätter default värden ändå "Unknown" och "0" i basklassen. 
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 0;
        public string Color { get; set; } = "Unknown";
        public string Species { get; set; } = "Unknown";
        public int Weight { get; set; } = 0;

        public Animal() { } // Constructor that uses the default values and dont have to take any arguments for a new animal to be made. 

        public Animal(string name, int age, string color, string species, int weight) //Constructor that must take arguments for making a new object. 
        {
            Name = name;
            Age = age;
            Color = color;
            Species = species;
            Weight = weight;
        }
        public virtual void MakeSound()// The subclasses is going to override this method therefore using virtual because their MakeSound is specifik and unique so dont have to put anything in there
        {
            
        }
        public void IsEating() // This method is generic for all and the subclasses wont override anything. Using GetType() so the printout gets more precise. And dont have to write anything in the subclass method. 
        {
            Console.WriteLine($"{GetType().Name} is eating");
        }
        public virtual void IsMoving() // The subclasses is going to override this method therefore using virtual because their IsMoving is specifik and unique so dont have to put anything in there
        {
            
        }


    }
}
