using AbstractFactory.Abstract;
using AbstractFactory.Class.Carni;
using AbstractFactory.Class.Herbi;
using AbstractFactory.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory.Implementation
{
    class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
