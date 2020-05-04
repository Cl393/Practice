using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeARMS
{
  public   class Gemstone:CondimentDecorator
    {
        private readonly InitialARMS Initialrams;
        public Gemstone(InitialARMS Initialrams)
        {
            this.Initialrams = Initialrams;
        }
        public override string Description
        {
            get { return $"{Initialrams.Description}, 镶入红宝石，合成愤怒的巨剑"; }
        }

        public override string Description1
        {
            get { return $"{Initialrams.Description1}, 镶入绿宝石，合成精灵的庇护"; }
        }

        public override double Price()
        {
            return .20 + Initialrams.Price();
        }
    }
}
