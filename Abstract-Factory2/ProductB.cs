using System;
namespace AbstractFactory2
{
    //concrete product
    public class ProductB : Product
    {
        public override void AddProduct(){
            
            Console.WriteLine("add product b");
        }

        public override void RemoveProduct(){

            Console.WriteLine("remove product b");
        }
    }
}