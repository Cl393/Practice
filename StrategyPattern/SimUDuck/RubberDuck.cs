using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    /// <summary>
    /// 橡皮鸭
    /// </summary>
   public class RubberDuck:Duck,IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("吱吱吱");
        }
        public override void Display()
        {
            Console.WriteLine("橡皮鸭");
        }
    }
}
