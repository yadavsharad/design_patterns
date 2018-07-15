using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// decorator
    /// </summary>
    public abstract class CarAccessoriesDecorator : ICar
    {
        private readonly ICar _car;

        public CarAccessoriesDecorator(ICar car)
        {
            _car = car;
        }

        public virtual double GetCost()
        {
            return _car.GetCost();
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }
    }
}
