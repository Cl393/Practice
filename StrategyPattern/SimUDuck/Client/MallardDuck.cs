﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    /// <summary>
    /// 青头鸭
    /// </summary>
  public  class MallardDuck:Duck
    {
        public MallardDuck()
        {
            iQuackBehavior = new Quackgaga();
            iFlyBehavior = new FlyWithWings();
        }
        public override void Display() 
        {
            Console.WriteLine("青头鸭");
        }
    }
}
