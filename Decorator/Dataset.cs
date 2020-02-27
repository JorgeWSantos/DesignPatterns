using System;

namespace Decorator
{
    //concrete component
    public class Dataset : DatasetBase
    {
        public override void write(){

            Console.WriteLine("write dataset");
        }
    }
}