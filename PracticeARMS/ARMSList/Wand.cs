using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeARMS
{
    public class Wand : InitialARMS
    {
        public Wand()
        {
            Description = "只有IQ达到250才能拿的动的魔杖";
        }
        public override double Price()
        {
            return 100;
        }
    }
}
