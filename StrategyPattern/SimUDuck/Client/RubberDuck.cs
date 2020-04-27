using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    /// <summary>
    /// 橡皮鸭
    /// </summary>
   public class RubberDuck:Duck
    {

        public RubberDuck() 
        {
            iQuackBehavior = new QuackZz();
            iFlyBehavior = new FlyNoWays();
        }
        public override void Display()
        {
            Console.WriteLine("橡皮鸭");
        }
    }
}
