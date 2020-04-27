using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
   public abstract class Duck
    {
      public   IFlyBehavior iFlyBehavior;
      public   IQuackBehavior iQuackBehavior;
        public void Swim()
        {
            Console.WriteLine("划水让我快乐");
        }
        public abstract  void Display();

        public void PerFormQuack() 
        {
            iQuackBehavior.Quack();
        }
        public void PerFormFly()
        {
            iFlyBehavior.Fly();
        }
        public void setFlyBehavior(IFlyBehavior fb)
        {
            iFlyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            iQuackBehavior = qb;

        }
    }
}
