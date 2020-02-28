namespace Builder2
{
    //builder
    public abstract class Builder
    {
        protected Veiculo veiculo;

        public Builder(Veiculo veiculo){

            this.veiculo = veiculo;
        }

        public abstract void doTipo();
        public abstract void ComAPlaca();
        public abstract void ComCor();
        public virtual void totalDePortas(){

            veiculo.portas = 0;
        }
        public abstract void daMarca();
        public abstract void doAno();
        public abstract Veiculo Build();
    }
}