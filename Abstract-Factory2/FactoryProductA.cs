namespace AbstractFactory2
{
    public class FactoryProductA : AbstractFactory
    {
        public override Product createProduct(){
            
            return new ProductA();
        }
    }
}