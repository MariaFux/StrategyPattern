using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Car
    {
        protected int passengers;
        protected string model;

        public IMovable Movable { private get; set; }

        public Car(int passengers, string model, IMovable move)
        {
            this.passengers = passengers;
            this.model = model;
            Movable = move;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}
