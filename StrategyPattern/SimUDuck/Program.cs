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
            //List<Duck> ducks = new List<Duck>
            //{
            //new MallardDuck(),
            //new RedheadDuck(),
            //new RubberDuck(),
            //new DecoyDuck()           

            //};
            //foreach (var item in ducks)
            //{
            //    Console.WriteLine("---------------");
            //    Console.WriteLine(item.GetType());
            //    item.Display();               
            //    item.PerFormQuack();
            //    item.PerFormFly();
            //}

            var md = new ModelDuck();
            Console.WriteLine("---------------");
            Console.WriteLine(md.GetType());
            md.Display();
            md.PerFormQuack();
            md.PerFormFly();

            md.setFlyBehavior(new FlyRocketPowered());
            Console.WriteLine("----模型鸭改了设置-----");
            md.PerFormFly();

        }
    }
}
