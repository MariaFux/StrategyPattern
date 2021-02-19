using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();
            Car auto2 = new Car(4, "Tesla", new ElectricMove());
            auto2.Move();
            auto2.Movable = new SunMove();
            auto2.Move();
        }
    }
}
