using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class SuperLuxuryCar : ICar
    {
        public double GetCost()
        {
            return 1100000;
        }

        public string GetDescription()
        {
            return "Super Laxury Car";
        }
    }

}
