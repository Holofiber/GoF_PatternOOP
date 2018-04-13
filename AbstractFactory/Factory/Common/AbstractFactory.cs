using AbstractFactory.Bottle.Common;
using AbstractFactory.Cover.Common;
using AbstractFactory.Water.Common;

namespace AbstractFactory.Factory.Common
{
    abstract class AbstractFactory
    {
        public abstract AbstractBottle CreateBottle();

        public abstract AbstractWater CreateWater();

        public abstract AbstractCover CreateCover();

    }
}
