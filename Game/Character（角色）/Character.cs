using Game.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Character_角色_
{
    public abstract class Character
    {
        public ISwordWeapon iSwordWeapon;

        public abstract void flight();
        public void PerFormWeapon()
        {
            iSwordWeapon.Weapon();
        }
        public void setSwordWeapon(ISwordWeapon sw)
        {
            iSwordWeapon = sw;
        }

    }

}
