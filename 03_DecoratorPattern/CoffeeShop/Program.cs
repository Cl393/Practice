using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一杯浓缩型咖啡
            var beverage = new Espresso();
            //显示咖啡信息和价格
            Console.WriteLine($"{beverage.Description} $ {beverage.Cost()}");
            
            //创建一杯首选咖啡
            Beverage beverage2 = new HouseBlend();
            //加份摩卡
            beverage2 = new Mocha(beverage2);
            //再加份摩卡
            beverage2 = new Mocha(beverage2);
            //加份奶油
            beverage2 = new Whip(beverage2);
            //显示咖啡信息和价格
            Console.WriteLine($"{beverage2.Description} $ {beverage2.Cost()}");
        }
    }
}
