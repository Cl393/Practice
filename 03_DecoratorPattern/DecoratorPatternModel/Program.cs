using System;

namespace DecoratorPatternModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------构建组件--------");
            Component p = new ConcreteComponent();
            p.Operation();
            Console.WriteLine("---------增加装饰A--------");
            p = new ConcreteDecoratorA(p);
            p.Operation();
            Console.WriteLine("----------增加装饰B---------");
            p= new ConcreteDecoratorB(p);
            p.Operation();
        }
    }
}
