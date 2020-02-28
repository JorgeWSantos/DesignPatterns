namespace Builder2
{
    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        } 

        public Veiculo construct(){

            builder.ComAPlaca();
            builder.ComCor();
            builder.doTipo();
            builder.totalDePortas();
            builder.doAno();
            builder.daMarca();

            return builder.Build();
        }
    }
}