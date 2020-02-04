using System;

namespace DesignPatterns.Project3
{
    public class TenisPlayer : Player
    {
        public TenisPlayer(String name, Runnable runnable):base(name, runnable)
        {

        }
        public override void defineTatics(){

            Console.WriteLine(getName() + " tatics is strong serve");
        }
    }
}