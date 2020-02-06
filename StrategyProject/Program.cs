using DesignPatterns.StrategyProject.Model;
using StrategyProject.Model.Tanks.Movement;
using StrategyProject.Model.Tanks.PrimaryWeapon;
using StrategyProject.Model.Tanks.SecondaryWeapon;

namespace DesignPatterns.StrategyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallTank smTank = new SmallTank(new MovementFast(), 
                                             new PrimaryWeaponCanon(),
                                             new SecondaryWeaponRocket());
            smTank.movement();
            smTank.primaryWeapon();
            smTank.secondaryWeapon();
            smTank.showTank();

            System.Console.WriteLine("==============");
            BigTank bgTank = new BigTank(new MovementLower(), 
                                         new PrimaryWeaponBow(),
                                         new SecondaryWeaponFlamethower());
            bgTank.movement();
            bgTank.primaryWeapon();
            bgTank.secondaryWeapon();
            bgTank.showTank();


            System.Console.WriteLine("==============");
            MediumTank mdTank = new MediumTank(new MovementLower(), 
                                                new PrimaryWeaponBow(),
                                                new SecondaryWeaponNoWeapon());
            mdTank.movement();
            mdTank.primaryWeapon();
            mdTank.secondaryWeapon();
            mdTank.showTank();
        }
    }
}
