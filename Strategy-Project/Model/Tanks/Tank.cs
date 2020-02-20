using StrategyProject.Model.Tanks;
using StrategyProject.Model.Tanks.PrimaryWeapon;
using StrategyProject.Model.Tanks.SecondaryWeapon;

namespace DesignPatterns.StrategyProject.Model
{
    public abstract class Tank
    {
        private MovementStrategy _movement;
        private PrimaryWeaponStrategy _primaryWeapon; 
        private SecondaryWeaponStrategy _secondaryWeapon; 

        public Tank(
                    MovementStrategy _movement, 
                    PrimaryWeaponStrategy _primaryWeapon,
                    SecondaryWeaponStrategy _secondaryWeapon)
        {

            this._movement = _movement;
            this._primaryWeapon = _primaryWeapon;
            this._secondaryWeapon = _secondaryWeapon;
        }

        public void movement(){

            _movement.Move();
        }
        public void primaryWeapon(){
            
            _primaryWeapon.useWeapon();
        }
        public void secondaryWeapon(){
            
            _secondaryWeapon.useWeapon();
        }
        public abstract void showTank();
    }
}