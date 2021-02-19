using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move by petrol.");
        }
    }
}
