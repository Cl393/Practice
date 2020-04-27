using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    /// <summary>
    /// 红头鸭
    /// </summary>
  public  class RedheadDuck :Duck,IFlyable,IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("红头鸭");
        }
        public void Fly()
        {
            Console.WriteLine("飞吧");
        }

        public void Quack()
        {
            Console.WriteLine("嘎嘎嘎");
        }
    }
}
