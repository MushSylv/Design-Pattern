using AbstractFactory.Client;
using AbstractFactory.Factory.Abstract;
using AbstractFactory.Factory.Implementation;
using System;

namespace AbstractFactory
{

    // Provide an interface for creating families of related or dependent objects without 
    // specifying their concrete classes.
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFood();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFood();

            Console.ReadKey();
        }
    }
}
