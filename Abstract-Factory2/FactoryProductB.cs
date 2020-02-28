namespace AbstractFactory2
{
    public class FactoryProductB : AbstractFactory
    {
        public override Product createProduct(){
            
            return new ProductB();
        }
    }
}