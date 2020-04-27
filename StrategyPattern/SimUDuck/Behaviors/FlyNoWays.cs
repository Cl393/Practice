using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    public class FlyNoWays : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我飞不了");
        }
    }
}
