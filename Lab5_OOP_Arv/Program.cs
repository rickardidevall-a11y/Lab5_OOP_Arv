//Rickard Idevall NET26. Vill ni ha kommentarerna på engelska eller svenska? Har för mig det skulle vara på engelska.

namespace Lab5_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating animals using the argument constructors.
            Animal genericAnimal = new Animal();
            Dog dog = new Dog("Aldor", 5, "Brown", "Dog", 25, "Short");
            Cat cat = new Cat("Petter", 3, "White", "Cat", 4, "Blue");
            Crocodile croc = new Crocodile("Gustav", 12, "Green", "Crocodile", 350, "Long");
            Bulldog bulldog = new Bulldog("Kalle", 6, "Grey", "Bulldog", 30, "Short", true);
            Chihuahua chihuahua = new Chihuahua("Rille", 2, "Tan", "Chihuahua", 3, "Smooth", true);

            //Putting all animals in a list.
            List<Animal> animals = new List<Animal>()
            {
                genericAnimal,
                dog,
                cat,
                croc,
                bulldog,
                chihuahua
            };

            //Looping through the animals and making them do their sound.
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
