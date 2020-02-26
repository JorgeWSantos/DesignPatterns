namespace bridge
{
    //abstract
    public abstract class Exportacao
    {
        //composição
        protected ImplementorExportar _implementor;
        public ImplementorExportar setImplementor{

            set{ this._implementor = value; }
        }
        public virtual void Exportar(){

            //implementação por delegação
            _implementor.Exportar();
        }
    }
}