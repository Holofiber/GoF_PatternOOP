using AbstractFactory.Bottle;
using AbstractFactory.Bottle.Common;
using AbstractFactory.Cover;
using AbstractFactory.Cover.Common;
using AbstractFactory.Water;
using AbstractFactory.Water.Common;

namespace AbstractFactory.Factory
{
    class SchweppesFactory : Common.AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return  new SchweppesBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new SchweppesWater();
        }

        public override AbstractCover CreateCover()
        {
            return new SchweppesCover();
        }
    }
}
