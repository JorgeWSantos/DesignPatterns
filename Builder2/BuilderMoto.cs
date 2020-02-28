using System;
namespace Builder2
{
    //concrete builder
    public class BuilderMoto : Builder
    {
        public BuilderMoto()
            :base(new Veiculo())
        {
        }

        public override Veiculo Build(){

            return veiculo;
        }

        public override void ComAPlaca(){

            veiculo.placa = "03467";
        }

        public override void ComCor(){

            veiculo.cor = "Vermelho";
        }

        public override void daMarca(){

            veiculo.marca = "Hyunday";
        }

        public override void doAno(){

            veiculo.ano = DateTime.Now.Year;
        }

        public override void doTipo(){

            veiculo.tipo = "XRE";
        }
    }
}