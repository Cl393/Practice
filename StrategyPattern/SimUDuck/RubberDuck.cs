﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    /// <summary>
    /// 橡皮鸭
    /// </summary>
   public class RubberDuck:Duck
    {
        public override void Quack()
        {
            Console.WriteLine("吱吱吱");
        }
        public override void Display()
        {
            Console.WriteLine("橡皮鸭");
        }
        public override void Fly()
        {
           //橡皮鸭子不会飞，就啥事情都不做吧
        }
    }
}
