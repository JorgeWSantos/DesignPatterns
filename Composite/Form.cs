using System;
using System.Collections.Generic;

namespace Composite
{
    //composite
    public class Form : Component
    {
        List<Component> children;
        public Form(string name)
              :base(name)
        {
            children = new List<Component>();
        }

        public override void Add(Component component){
            this.children.Add(component);
        }

        public override void Display(){

            Console.WriteLine(name);
            
            foreach (var control in children)
            {
                control.Display();
            }
        }

        public override void Remove(Component component){
            this.children.Remove(component);

        }
    }
}