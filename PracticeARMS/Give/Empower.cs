using System;
using System.Collections.Generic;
using System.Text;


namespace PracticeARMS
{
    public class Empower : CondimentDecorator

    {
        private readonly InitialARMS Initialrams;
        public Empower(InitialARMS Initialrams)
        {
            this.Initialrams  = Initialrams;
        }
        public override string Description
        {
            get { return $"{Initialrams.Description}, 附上大天使的光翼，合成大天使的光芒"; }
        }

        public override string Description1
        {
            get { return $"{Initialrams.Description1}, 注入贤者的宝石，合成贤者法杖"; }
        }

        public override double Price()
        {
            return .3600 + Initialrams.Price();
        }
    }
}
