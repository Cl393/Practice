using Game.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Weapon_武器_
{
    //盾
  public class Shield: ISwordWeapon
    {
        public void Weapon()
        {
            Console.WriteLine("盾");
        }
    }
}
