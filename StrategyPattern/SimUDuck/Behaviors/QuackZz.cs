using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class QuackZz : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("吱吱吱");
        }
    }
}
