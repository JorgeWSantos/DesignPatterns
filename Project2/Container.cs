using System;

namespace DesignPatterns.Project2
{
    public abstract class Container
    {
        public abstract void addComponent(Component component);
        public abstract void removeComponent(Component component);
        public abstract void doLayout();
        public void dispose(){

            Console.WriteLine("dispose container");
        }
    }
}