using System;

namespace DesignPatterns.Project3
{
    public abstract class Player
    {
        private string name;
        private Runnable runnable;

        protected Player(string name, Runnable runnable){

            this.name = name;
            this.runnable = runnable;
        }

        public void train(){

            Console.WriteLine(name + " trains hard.");
        }

        public void compete(){

            Console.WriteLine(name + " is very competitive.");
        }

        public void performRunning(){

            runnable.doRunning();
        }

        protected string getName(){

            return name;
        }
        
        public abstract void defineTatics();
    }
}