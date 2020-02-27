using System.Data;

namespace Decorator
{
    //client
    public class Program
    {
        static void Main(string[] args)
        {
            var dt = new Dataset();
            DatasetConcreteDecorator concreteDecorator = new DatasetConcreteDecorator();
            concreteDecorator.setDataset(dt);
            concreteDecorator.write();
            concreteDecorator.writeXml();
        }
    }
}
