using System;

namespace cpt3
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Animal RomaPeskov = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            RomaPeskov.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }

    }
}