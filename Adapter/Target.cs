using System;

namespace Adapter
{
    public class Target
    {
        public virtual void request(){

            Console.WriteLine("Metodo request de target");
        }
    }
}