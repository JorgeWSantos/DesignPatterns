using System;

namespace StrategyProject.Model.Tanks.SecondaryWeapon
{
    public class SecondaryWeaponRocket : SecondaryWeaponStrategy
    {
        public void useWeapon()
        {
            Console.WriteLine("Rocket");
        }
    }
}