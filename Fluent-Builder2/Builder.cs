namespace Builder2
{
    //builder
    public abstract class Builder
    {
        protected Veiculo veiculo;

        public Builder(Veiculo veiculo){

            this.veiculo = veiculo;
        }

        public abstract  Builder doTipo(string tipo);
        public abstract Builder ComAPlaca(string placa);
        public abstract Builder ComCor(string cor);
        public virtual Builder totalDePortas(int portas){

            veiculo.portas = 0;
            return this;
        }
        public abstract Builder daMarca(string marca);
        public abstract Builder doAno(int ano);
        public abstract Veiculo Build();
    }
}