using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DeluxCar : ICar
    {
        public double GetCost()
        {
            return 600000;
        }

        public string GetDescription()
        {
            return "Delux car...";
        }
    }
}
