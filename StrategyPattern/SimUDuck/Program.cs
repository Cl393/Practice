using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace SimUDuck
{
    /// <summary>
    /// 需要会飞的鸭子
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>
            {
            new MallardDuck(),
            new RedheadDuck(),
            new RubberDuck(),
            new DecoyDuck()

            };
            foreach (var item in ducks)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(item.GetType());
                item.Display();
                item.Quack();                 
            }
        }
    }
}
