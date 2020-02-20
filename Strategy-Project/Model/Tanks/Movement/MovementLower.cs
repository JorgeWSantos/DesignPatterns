using System;

namespace StrategyProject.Model.Tanks.Movement
{
    public class MovementLower : MovementStrategy
    {
        public void Move(){

            ExecuteMovement();
        }

        private void ExecuteMovement(){

            Console.WriteLine("Move Lower!");
        }
    }
}