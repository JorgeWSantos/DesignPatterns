using System;

namespace StrategyProject.Model.Tanks.SecondaryWeapon
{
    public class SecondaryWeaponFlamethower : SecondaryWeaponStrategy
    {
        public void useWeapon()
        {
            Console.WriteLine("FlameTower");
        }
    }
}