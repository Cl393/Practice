using Game.Weapon_武器_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Character_角色_
{
   public  class Tolrl:Character
    {
        public Tolrl ()
        {
            iSwordWeapon = new Spear();
        }
        public override void flight()
        {
            Console.WriteLine("当前角色为“妖怪”");
        }

    }
}
