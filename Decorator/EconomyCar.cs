using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class EconomyCar : ICar
    {
        public double GetCost()
        {
            return 400000;
        }

        public string GetDescription()
        {
            return "Economy Car...";
        }
    }
}
