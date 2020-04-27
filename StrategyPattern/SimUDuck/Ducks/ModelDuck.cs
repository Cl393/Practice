using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    public class ModelDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("我是火箭鸭");
        }
        public ModelDuck() 
        {
            iFlyBehavior = new FlyNoWays();
            iQuackBehavior = new Quackgaga();
        }
    }
}
