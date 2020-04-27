using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
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
    }
}
