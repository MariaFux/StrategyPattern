using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class SunMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move by sun.");
        }
    }
}
