namespace Builder2
{
    //concrete builder
    public class BuilderCarro : Builder
    {

        public BuilderCarro()
            :base(new Veiculo())
        {

        }

        public override Veiculo Build(){

            return veiculo;
        }

        public override Builder ComAPlaca(string placa){

            veiculo.placa = placa;
            return this;
        }

        public override Builder ComCor(string cor){

            veiculo.cor = cor;
            return this;
        }

        public override Builder daMarca(string marca){

            veiculo.marca = marca;
            return this;
        }

        public override Builder doAno(int ano){

            veiculo.ano = ano;
            return this;
        }

        public override Builder doTipo(string tipo){

            veiculo.tipo = tipo;
            return this;
        }

        public override Builder totalDePortas(int portas){

            veiculo.portas = portas;
            return this;
        }
    }
}