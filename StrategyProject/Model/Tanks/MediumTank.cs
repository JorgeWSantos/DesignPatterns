using System;
using StrategyProject.Model.Tanks;
using StrategyProject.Model.Tanks.PrimaryWeapon;
using StrategyProject.Model.Tanks.SecondaryWeapon;

namespace DesignPatterns.StrategyProject.Model
{
    public class MediumTank : Tank
    {
        public MediumTank(MovementStrategy _movement, 
                         PrimaryWeaponStrategy _primaryWeapon,
                         SecondaryWeaponStrategy _secondaryWeapon)
                        :base(_movement, _primaryWeapon, _secondaryWeapon)
        {
            
        }

        public override void showTank(){

            Console.WriteLine("medium tank.");
        }
    }
}