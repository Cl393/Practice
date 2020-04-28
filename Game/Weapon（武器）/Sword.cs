using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Weapon_武器_
{
    //剑
   public  class Sword:Abstractions.ISwordWeapon
    {
        public void Weapon()
        {
            Console.WriteLine("长剑");
        }
    }
}
