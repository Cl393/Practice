using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("用翅膀飞，飞吧，上天");
        }
    }
}
