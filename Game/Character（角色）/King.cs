using Game.Weapon_武器_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Character_角色_
{
    //国王

   public class King:Character
    {
        public King()
        {
            iSwordWeapon = new Sword();
        }
        public override void flight()
        {
            Console.WriteLine("当前角色为“王”");
        }
    }
}
