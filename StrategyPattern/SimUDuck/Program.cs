using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>
            {
            new MallardDuck(),
            new RedheadDuck(),
            new RubberDuck()
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
