﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    /// <summary>
    /// 红头鸭
    /// </summary>
  public  class RedheadDuck :Duck
    {
        public RedheadDuck() 
        {
            iQuackBehavior = new Quackgaga();
            iFlyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("红头鸭");
        }

    }
}
