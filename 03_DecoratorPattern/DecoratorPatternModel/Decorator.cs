using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternModel
{
  public abstract class Decorator : Component
    {
        private Component _component;
        public Decorator(Component component) 
        {
            this._component = component;
        }
        public virtual void Operation()
        {
            _component.Operation();
        }
    }
}
