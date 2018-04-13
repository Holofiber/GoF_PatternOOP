using AbstractFactory.Water.Common;

namespace AbstractFactory.Bottle.Common
{
    abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
    }
}
