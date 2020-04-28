using System;
using System.Collections.Generic;
using System.Text;
using Game.Abstractions;

namespace Game.Weapon_武器_
{
    //长矛
    public class Spear:ISwordWeapon
    {
        public void Weapon()
        {
            Console.WriteLine("长矛");
        }
    }
}
