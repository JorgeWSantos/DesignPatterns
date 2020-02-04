using System;

namespace DesignPatterns.Project3
{
    public class SoccerPlayer : Player
    {
        public SoccerPlayer(String name, Runnable runnable):base(name, runnable)
        {
            
        }
        public override void defineTatics(){

            Console.WriteLine(getName() + " tatics is Kick the ball to the goal");
        }
    }
}