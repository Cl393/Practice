﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
   public class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("嘎嘎嘎");
        }
        public void Swim()
        {
            Console.WriteLine("划水让我快乐");
        }
        public virtual void Display()
        {
            Console.WriteLine("我是只快乐的小鸭子");
        }
    }
}
