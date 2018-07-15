using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling decorator

            ICar car = new EconomyCar();

            CarAccessoriesDecorator decorator = new BasicAccessories(car);
            decorator = new AdvanceAccessories(decorator);

            Console.WriteLine($"Car Details : { decorator.GetDescription()}");
            Console.WriteLine($"Car Cost : { decorator.GetCost()}");
            
            car = new SuperLuxuryCar();
            decorator = new SuperLuxuryAccessories(car);

            Console.WriteLine($"Super Car Details : { decorator.GetDescription()}");
            Console.WriteLine($"Super Car Cost : { decorator.GetCost()}");

            Console.ReadKey();
        }
    }
}
