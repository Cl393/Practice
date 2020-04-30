using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternModel
{
  public  class ConcreteComponent : Component
    {
        public void Operation()
        {
            Console.WriteLine("调用具体组件的方法Operation");
        }
    }
}
