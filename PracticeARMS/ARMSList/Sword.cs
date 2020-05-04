using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeARMS
{
   public class Sword:InitialARMS
    {
        public Sword()
        {
            Description = "只有勇者才能拿的动的剑";
        }

        public override double Price()
        {
            return 15.0;
        }
    }
}
