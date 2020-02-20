using System;

namespace StrategyProject.Model.Tanks.Movement
{
    public class MovementFast : MovementStrategy
    {
        public void Move(){

            ExecuteMove();
        }

        private void ExecuteMove(){

            Console.WriteLine("Move Fast!");
        }
    }
}