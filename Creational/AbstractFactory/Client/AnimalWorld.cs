using AbstractFactory.Abstract;
using AbstractFactory.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Client
{
    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory continent)
        {
            _herbivore = continent.CreateHerbivore();
            _carnivore = continent.CreateCarnivore();
        }

        public void RunFood()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
