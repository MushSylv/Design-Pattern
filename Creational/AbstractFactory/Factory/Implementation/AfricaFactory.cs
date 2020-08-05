using AbstractFactory.Abstract;
using AbstractFactory.Class;
using AbstractFactory.Class.Carni;
using AbstractFactory.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory.Implementation
{
    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new WildeBeest();
        }
    }
}
