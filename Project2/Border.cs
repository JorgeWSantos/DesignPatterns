namespace DesignPatterns.Project2
{
    public abstract class Border
    {
        private Container container;
        public Border(Container container)
        {
            this.container = container;
        }
         public abstract void generateBorder();
         public virtual Container getContainer(){
             
             return container;
         }

         public virtual void setContainer(Container container){
             this.container = container;
         }
    }
}