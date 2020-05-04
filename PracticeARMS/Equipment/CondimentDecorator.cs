using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeARMS
{
    public abstract class CondimentDecorator : InitialARMS
    {
        public abstract override string Description { get; }
        public abstract override string Description1 { get; }
    }
}
