using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我坐火箭飞");
        }
    }
}
