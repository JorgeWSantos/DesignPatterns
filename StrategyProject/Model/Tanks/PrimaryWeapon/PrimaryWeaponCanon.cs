using System;

namespace StrategyProject.Model.Tanks.PrimaryWeapon
{
    public class PrimaryWeaponCanon : PrimaryWeaponStrategy
    {

        public void useWeapon(){

            Console.WriteLine("PW Cannon");
        }
    }
}