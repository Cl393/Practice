using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    /// <summary>
    /// 木鸭子
    /// </summary>
   public class DecoyDuck:Duck
    {
        public DecoyDuck()
        {
            iQuackBehavior = new QuackMute();
            iFlyBehavior = new FlyNoWays();
        }
        public override void Display()
        {
            Console.WriteLine("木头鸭");
        }
    }
}
