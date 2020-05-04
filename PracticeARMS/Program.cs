using System;

namespace PracticeARMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一把铁剑
            var sword = new Sword();
            //显示铁剑信息和价格
            Console.WriteLine($"{sword.Description} $ {sword.Price()}");

            //创建一把铁剑
            InitialARMS sword2 = new Sword();
            //附加宝石
            sword2 = new Gemstone(sword2);
            //赋予特殊力量
            sword2 = new Empower(sword2);
            Console.WriteLine($"{sword2.Description} $ {sword2.Price()}");
            Console.WriteLine();
            var wand= new Wand();
            //显示权杖信息和价格
            Console.WriteLine($"{sword.Description1} $ {sword.Price()}");

            InitialARMS wand2 = new Wand();
            wand2 = new Gemstone(wand2);
            //赋予特殊力量
            wand2 = new Empower(wand2);
            //显示加强权杖信息和价格
            Console.WriteLine($"{wand2.Description1} $ {wand2.Price()}");

        }
    }
}
