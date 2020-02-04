using System;

namespace DesignPatterns.Project3
{
    public class ChessPlayer : Player
    {
        public ChessPlayer(String name, Runnable runnable):base(name, runnable)
        {

        }

        public override void defineTatics(){

            Console.WriteLine(getName() + " tatics is predict moves.");
        }
    }
}