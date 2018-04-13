using System;
using AbstractFactory.Bottle.Common;
using AbstractFactory.Water.Common;

namespace AbstractFactory.Bottle
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interact with " + water);
        }
    }
}
