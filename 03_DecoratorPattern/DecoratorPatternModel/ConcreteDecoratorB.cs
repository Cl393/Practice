using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternModel
{
    public class ConcreteDecoratorB : Decorator
    {

        public ConcreteDecoratorB(Component component) : base(component)
        {
        }
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
        }
        public void AddBehavior()
        {
            Console.WriteLine("为具体组件角色增加额外的功能B");
        }
    }
}
