using AbstractFactory.Bottle;
using AbstractFactory.Bottle.Common;
using AbstractFactory.Cover;
using AbstractFactory.Cover.Common;
using AbstractFactory.Water;
using AbstractFactory.Water.Common;

namespace AbstractFactory.Factory
{
    class PepsiFactory : Factory.Common.AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }
    }
}
