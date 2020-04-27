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
        public override void Quack()
        {
            //木鸭子不会叫，就啥事情都不做吧
        }
        public override void Display()
        {
            Console.WriteLine("木头鸭");
        }
        public override void Fly()
        {
            //木鸭子不会飞，就啥事情都不做吧
        }
    }
}
