using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    public class QuackMute : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("沉默是金");
        }
    }
}
