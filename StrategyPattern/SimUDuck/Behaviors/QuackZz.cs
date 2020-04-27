using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    public class QuackZz : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("吱吱吱");
        }
    }
}
