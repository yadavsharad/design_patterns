using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class LuxuryCar : ICar
    {
        public double GetCost()
        {
            return 800000;
        }

        public string GetDescription()
        {
            return "Luxury Car...";
        }
    }
}
