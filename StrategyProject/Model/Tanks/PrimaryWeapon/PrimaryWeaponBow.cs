using System;

namespace StrategyProject.Model.Tanks.PrimaryWeapon
{
    public class PrimaryWeaponBow : PrimaryWeaponStrategy
    {
        public void useWeapon()
        {
            Console.WriteLine("Bow");
        }
    }
}