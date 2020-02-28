using System;
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

        public override void ComAPlaca(){

            veiculo.placa = "eg5f12";
        }

        public override void ComCor(){

            veiculo.cor = "Rosa";
        }

        public override void daMarca(){

            veiculo.marca = "Hyunday";
        }

        public override void doAno(){

            veiculo.ano = DateTime.Now.Year;
        }

        public override void doTipo(){

            veiculo.tipo = "Duster";
        }

        public override void totalDePortas(){

            veiculo.portas = 4;
        }
    }
}