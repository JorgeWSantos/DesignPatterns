using System;

namespace AbstractFactory2
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            // AbstractFactory absFactory = new FactoryProductB();
            AbstractFactory absFactory = new FactoryProductA();
            Product product = absFactory.createProduct();
            product.AddProduct();
            product.RemoveProduct();
        }
    }
}
