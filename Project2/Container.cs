using System;

namespace DesignPatterns.Project2
{
    public abstract class Container
    {
        public abstract void addComponent();
        public abstract void removeComponent();
        public abstract void doLayout();
        
        public void dispose(){

            Console.WriteLine("dispose container");
        }
    }
}