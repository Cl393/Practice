using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternModel
{
   public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component):base(component)
        {
        }
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
        }
        public void AddBehavior()
        {
            Console.WriteLine("为具体组件角色增加额外的功能A");
        }
    }
}
