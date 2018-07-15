using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar car)
            : base(car)
        {

        }

        public override double GetCost()
        {
            return base.GetCost() + 20000.0;
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()} , Basic Accesssories Package";
        }
    }
}
