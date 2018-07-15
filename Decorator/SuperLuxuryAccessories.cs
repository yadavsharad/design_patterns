using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class SuperLuxuryAccessories : CarAccessoriesDecorator
    {
        public SuperLuxuryAccessories(ICar car)
            : base(car)
        {

        }

        public override double GetCost()
        {
            return base.GetCost() + 21000;
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()} , Super Laxury Accessories Package";
        }
    }
}
