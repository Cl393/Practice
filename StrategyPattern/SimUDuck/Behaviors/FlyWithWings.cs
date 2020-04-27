using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("飞吧");
        }
    }
}
