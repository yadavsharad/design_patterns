using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class AdvanceAccessories : CarAccessoriesDecorator
    {
        public AdvanceAccessories(ICar car)
            : base(car)
        {

        }

        public override double GetCost()
        {
            return base.GetCost() + 3000;
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Advance Accessories";
        }
    }
}
