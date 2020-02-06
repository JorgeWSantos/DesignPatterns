using System;

namespace StrategyProject.Model.Tanks.SecondaryWeapon
{
    public class SecondaryWeaponNoWeapon : SecondaryWeaponStrategy
    {
        public void useWeapon(){

            Console.WriteLine("Withou Secondary weapon");
        }
    }
}