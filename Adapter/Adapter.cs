namespace Adapter
{
    //transforma adapte em target
    public class Adapter : Target
    {
        private Adaptee adaptee;
        public Adapter(){

            this.adaptee = new Adaptee();
        }
        public override void request(){
            
            adaptee.SpecificRequest();
        }
    }
}