using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeARMS
{
    public abstract class InitialARMS
    {
        public virtual string Description { get; protected set; } = "铁剑";

        public virtual string Description1 { get; protected set; } = "香木法杖";
        public abstract double Price();
    }
}
