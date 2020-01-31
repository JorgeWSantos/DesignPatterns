
using System;
using System.Collections.Generic;

namespace DesignPatterns.Project2
{
    public class FlowContainer : Container
    {
        List<Component> components;

        public FlowContainer()
        {
            this.components = new List<Component>();
        }

        public override void addComponent(Component component){

            components.Add(component);
        }

        public override void removeComponent(Component component) {

            components.Remove(component);
        }
        public override void doLayout() {

            Console.WriteLine("---------");
            Console.WriteLine("flow container");
            foreach (var component in components)
            {
                Console.WriteLine(component);
            }
            this.dispose();
            Console.WriteLine("---------\n");
        }
    }
}