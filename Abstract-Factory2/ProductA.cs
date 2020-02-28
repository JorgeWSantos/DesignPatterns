using System;
namespace AbstractFactory2
{
    //concrete product
    public class ProductA : Product
    {
        public override void AddProduct(){

            Console.WriteLine("add product a");
        }

        public override void RemoveProduct(){
            
            Console.WriteLine("remove product a");
        }
    }
}