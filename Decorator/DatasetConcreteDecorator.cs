using System;
namespace Decorator
{
    public class DatasetConcreteDecorator :DatasetDecorator
    {
        public override void write(){
            Console.WriteLine("dataset concrete decorator write");
            this.datasetBase.write();
        }
        public void writeXml(){

            Console.WriteLine("dataset concrete decorator xml");
        }
    }
}