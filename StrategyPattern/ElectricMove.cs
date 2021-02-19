using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move by electric.");
        }
    }
}
