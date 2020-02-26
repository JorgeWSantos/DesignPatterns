using System;

namespace Composite
{
    //leaf
    public class TextBox : Component
    {
        public TextBox(string name)
            :base(name)
        {
            
        }
        public override void Add(Component component){

            Console.WriteLine("Não é possível adicionar elementos a esse component.");
        }

        public override void Display(){

            Console.WriteLine(name);
        }

        public override void Remove(Component component){

            Console.WriteLine("Não é possível remover esse elemento.");
        }
    }
}