using AbstractFactory.Bottle;
using AbstractFactory.Bottle.Common;
using AbstractFactory.Cover;
using AbstractFactory.Cover.Common;
using AbstractFactory.Water;
using AbstractFactory.Water.Common;

namespace AbstractFactory.Factory
{
    class CocaColaFactory : Factory.Common.AbstractFactory

    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractCover CreateCover()
        {
            return  new CocaColaCover();
        }
    }
}
