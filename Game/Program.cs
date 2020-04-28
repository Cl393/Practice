using Game.Character_角色_;
using Game.Weapon_武器_;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var md = new Queen();
            Console.WriteLine("---------------");
            Console.WriteLine(md.GetType());
            md.flight();
            Console.WriteLine("初始装备-------------");
            md.PerFormWeapon();

            md.setSwordWeapon(new Shield());
            Console.WriteLine("---更换武器---");
            md.PerFormWeapon();
        }
    }
}
